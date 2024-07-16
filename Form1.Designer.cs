using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.DirectoryServices.ActiveDirectorySecurity activeDirectorySecurity2 = new System.DirectoryServices.ActiveDirectorySecurity();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            radioButton4 = new RadioButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.Size = new Size(421, 611);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 551);
            button1.Name = "button1";
            button1.Size = new Size(415, 57);
            button1.TabIndex = 2;
            button1.Text = "Modify";
            button1.Click += Button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.MaxLength = 0;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(415, 402);
            textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 411);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 134);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Modify type";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(206, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Padding = new Padding(7);
            radioButton3.Size = new Size(194, 38);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Tag = "InsertInto";
            radioButton3.Text = "INSERT INTO #Tmp (' ')";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(109, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(7);
            radioButton2.Size = new Size(67, 38);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Tag = "ValuesList";
            radioButton2.Text = "(' '),";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(9, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(7);
            radioButton1.Size = new Size(57, 38);
            radioButton1.TabIndex = 0;
            radioButton1.Tag = "InList";
            radioButton1.Text = "' ',";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // directoryEntry1
            // 
            directoryEntry1.ObjectSecurity = activeDirectorySecurity2;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 80);
            radioButton4.Name = "radioButton4";
            radioButton4.Padding = new Padding(7);
            radioButton4.Size = new Size(94, 38);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Tag = "Custom";
            radioButton4.Text = "Custom";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(102, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(247, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(102, 27);
            textBox3.TabIndex = 5;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 67);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 6;
            label1.Text = "Prefix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 67);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Suffix";
            // 
            // Form1
            // 
            AutoScaleBaseSize = new Size(7, 20);
            ClientSize = new Size(421, 611);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "TextModifier";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private Button button1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private System.ComponentModel.IContainer components;
        private TextBox textBox3;
        private TextBox textBox2;
        private RadioButton radioButton4;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private Label label2;
        private Label label1;
    }
}

