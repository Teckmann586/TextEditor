using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace TextEditor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            var rb = this.RadioButtonChecked();

            if (rb == null)
            {
                MessageBox.Show(this, "Make a selection", "Exception", MessageBoxButtons.OK);
                return;
            }
            string ModifyType = rb.GetModifyType();
            try
            {
                if (ModifyType == "InList")
                {
                    try
                    {
                        int num = textBox1.Lines.Length;

                        StringBuilder newString = new ();

                        if (num < 1)
                        {
                            MessageBox.Show(this, "Enter text to modify", "Exception", MessageBoxButtons.OK);
                            return;
                        }

                        var textItems = textBox1.Lines.ToArray();
                        ref var searchSpace = ref MemoryMarshal.GetArrayDataReference(textItems);

                        textBox1.Text = String.Empty;

                        for (var i = 0; i < textItems.Length; i++)
                        {
                            if (i == textItems.Length - 1)
                            { 
                                var item = Unsafe.Add(ref searchSpace, i);
                                string valueToAdd = "'" + item + "'";

                                newString.Append(valueToAdd);
                            }
                            else
                            {
                                var item = Unsafe.Add(ref searchSpace, i);
                                string valueToAdd = "'" + item + "',";
                                newString.Append(valueToAdd + Environment.NewLine);
                            }
                        }
                        textBox1.Text = newString.ToString();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Unknown error, Radiobutton tag not set try again.", "Exception", MessageBoxButtons.OK);
                    }
                    return;
                }
                if (ModifyType == "ValuesList")
                {
                    int num = textBox1.Lines.Length;

                    StringBuilder newString = new();

                    if (num < 1)
                    {
                        MessageBox.Show(this, "Enter text to modify", "Exception", MessageBoxButtons.OK);
                        return;
                    }
                    try
                    {
                        var textItems = textBox1.Lines.ToArray();
                        ref var searchSpace = ref MemoryMarshal.GetArrayDataReference(textItems);

                        textBox1.Text = String.Empty;

                        for (var i = 0; i < textItems.Length; i++)
                        {
                            if (i == textItems.Length - 1)
                            {
                                var item = Unsafe.Add(ref searchSpace, i);
                                string valueToAdd = "('" + item.TrimStart().TrimEnd().ToString() + "')";

                                newString.Append(valueToAdd);
                            }
                            else
                            {
                                var item = Unsafe.Add(ref searchSpace, i);
                                string valueToAdd = "('" + item.TrimStart().TrimEnd().ToString() + "'),";

                                newString.Append(valueToAdd + Environment.NewLine);
                            }
                        }

                        textBox1.Text = newString.ToString();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Unknown error, Radiobutton tag not set try again.", "Exception", MessageBoxButtons.OK);
                    }
                    return;
                }
                if (ModifyType == "InsertInto")
                {
                    int num = textBox1.Lines.Length;

                    StringBuilder newString = new();

                    if (num < 1)
                    {
                        MessageBox.Show(this, "Enter text to modify", "Exception", MessageBoxButtons.OK);
                        return;
                    }
                    try
                    {
                        var textItems = textBox1.Lines.ToArray();
                        ref var searchSpace = ref MemoryMarshal.GetArrayDataReference(textItems);

                        textBox1.Text = String.Empty;

                        for (var i = 0; i < textItems.Length; i++)
                        {
                            var item = Unsafe.Add(ref searchSpace, i);
                            string valueToAdd = "INSERT INTO #TMP (SN) VALUES ('" + item.TrimStart().TrimEnd().ToString() + "');";

                            newString.Append(valueToAdd + Environment.NewLine);
                        }

                        textBox1.Text = newString.ToString();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Unknown error, Radiobutton tag not set try again.", "Exception", MessageBoxButtons.OK);
                    }
                return;
                }
                if (ModifyType == "Custom")
                {
                    int num = textBox1.Lines.Length;

                    StringBuilder newString = new();

                    if (num < 1)
                    {
                        MessageBox.Show(this, "Enter text to modify", "Exception", MessageBoxButtons.OK);
                        return;
                    }
                    try
                    {
                        var prefix = textBox2.Text.ToString();
                        var suffix = textBox3.Text.ToString();

                        var textItems = textBox1.Lines.ToArray();
                        ref var searchSpace = ref MemoryMarshal.GetArrayDataReference(textItems);

                        textBox1.Text = String.Empty;

                        for (var i = 0; i < textItems.Length; i++)
                        {
                            if (i == textItems.Length - 1)
                            {
                                var item = Unsafe.Add(ref searchSpace, i);
                                string valueToAdd = prefix + item.TrimStart().TrimEnd().ToString() + suffix;

                                newString.Append(valueToAdd);
                            }
                            else
                            {
                                var item = Unsafe.Add(ref searchSpace, i);
                                string valueToAdd = prefix + item.TrimStart().TrimEnd().ToString() + suffix;

                                newString.Append(valueToAdd + Environment.NewLine);
                            }
                        }

                        textBox1.Text = newString.ToString();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Unknown error, Radiobutton tag not set try again.", "Exception", MessageBoxButtons.OK);
                    }
                    return;
                }

                MessageBox.Show(this, "Unknown error, Radiobutton tag not set try again.", "Exception", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "Unknown error, Radiobutton tag not set: " + ex.Message.ToString() , "Exception", MessageBoxButtons.OK); 
            }
        }
    }

    public static class ControlExtensions
    {
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                if (child is T thisControl)
                    yield return thisControl;
                if (!child.HasChildren) continue;
                foreach (T descendant in Descendants<T>(child))
                    yield return descendant;
            }
        }

        public static RadioButton RadioButtonChecked(this Control control, bool @checked = true)
        {
            return control.Descendants<RadioButton>().ToList().Find((radioButton) => radioButton.Checked == @checked);
        }

        public static string GetModifyType(this RadioButton radioButton)
            => radioButton.Tag.ToString();
    }
}
