using System.Reflection.Emit;
using System.Windows.Forms;

namespace Suits
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TabControl tabControl1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            label4 = new System.Windows.Forms.Label();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            comboBox1 = new ComboBox();
            splitContainer1 = new SplitContainer();
            pictureBox7 = new PictureBox();
            label2 = new System.Windows.Forms.Label();
            pictureBox2 = new PictureBox();
            tabPage4 = new TabPage();
            comboBox2 = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            label5 = new System.Windows.Forms.Label();
            pictureBox3 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            pictureBox4 = new PictureBox();
            tabPage6 = new TabPage();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new TextBox();
            pictureBox6 = new PictureBox();
            listBox1 = new ListBox();
            tabPage7 = new TabPage();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            tabControl1 = new TabControl();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.HotTrack = true;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1232, 632);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DimGray;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1224, 599);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Inicio";
            tabPage1.Click += tabPage1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(290, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(727, 370);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sinopse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(17, 38);
            label4.MaximumSize = new Size(680, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-80, -81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 227);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DimGray;
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1224, 599);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Atores";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(240, 6);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox7);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(976, 686);
            splitContainer1.SplitterDistance = 325;
            splitContainer1.TabIndex = 2;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(64, 94);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(194, 259);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(73, 14);
            label2.MaximumSize = new Size(560, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 0;
            label2.Text = "Selecione uma opção";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-80, -81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(314, 229);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.DimGray;
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(comboBox2);
            tabPage4.Controls.Add(tableLayoutPanel1);
            tabPage4.Controls.Add(pictureBox4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1224, 599);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Temporadas";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(110, 227);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(checkBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 0, 1);
            tableLayoutPanel1.Location = new Point(379, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(677, 547);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            checkBox1.Location = new Point(341, 276);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 25);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Já assistiu?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(341, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 2;
            label5.Text = "Qual temporada? ";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(332, 267);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(3, 276);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(76, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-80, -81);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(314, 226);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.DimGray;
            tabPage6.BackgroundImageLayout = ImageLayout.None;
            tabPage6.Controls.Add(label1);
            tabPage6.Controls.Add(textBox1);
            tabPage6.Controls.Add(pictureBox6);
            tabPage6.Controls.Add(listBox1);
            tabPage6.ForeColor = SystemColors.ActiveCaption;
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1224, 599);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Curiosidades";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(966, 20);
            label1.MaximumSize = new Size(200, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 7;
            label1.Text = "Selecione uma opção";
            label1.AutoSizeChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DimGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(252, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "Selecione a curiosidade para mais informações";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(-80, -81);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(314, 229);
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DimGray;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Cursor = Cursors.Hand;
            listBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(252, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(680, 126);
            listBox1.TabIndex = 2;
            listBox1.Click += listBox1_SelectedIndexChanged;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(axWindowsMediaPlayer1);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1224, 599);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Erros de gravação";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(3, 3);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1218, 593);
            axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(23, 41);
            label3.MaximumSize = new Size(680, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(110, 324);
            label6.Name = "label6";
            label6.Size = new Size(263, 21);
            label6.TabIndex = 4;
            label6.Text = "Nota de 0 a 10 para a temporada:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1232, 632);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Suits";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage6;
        private ListBox listBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private TabPage tabPage7;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox7;
        private ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private PictureBox pictureBox3;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
    } 
}
