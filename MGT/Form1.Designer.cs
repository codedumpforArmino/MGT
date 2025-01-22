namespace MGT
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
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            txtBox_TimerOutput = new TextBox();
            txtBox_ConsoleOutput = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            btn_Add = new Button();
            btn_Log = new Button();
            lbl_Add = new Label();
            cmb_Select = new ComboBox();
            txtb_GameName = new TextBox();
            timer_LogLapsed = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            saveGameLibraryToolStripMenuItem = new ToolStripMenuItem();
            loadGameLibraryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 33);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(800, 417);
            splitContainer1.SplitterDistance = 179;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(61, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 317);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer2.Size = new Size(617, 417);
            splitContainer2.SplitterDistance = 213;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(txtBox_TimerOutput);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(txtBox_ConsoleOutput);
            splitContainer3.Size = new Size(617, 213);
            splitContainer3.SplitterDistance = 205;
            splitContainer3.TabIndex = 0;
            // 
            // txtBox_TimerOutput
            // 
            txtBox_TimerOutput.Location = new Point(26, 111);
            txtBox_TimerOutput.Name = "txtBox_TimerOutput";
            txtBox_TimerOutput.Size = new Size(150, 31);
            txtBox_TimerOutput.TabIndex = 0;
            txtBox_TimerOutput.Text = "00 : 00";
            txtBox_TimerOutput.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_ConsoleOutput
            // 
            txtBox_ConsoleOutput.Location = new Point(18, 37);
            txtBox_ConsoleOutput.Multiline = true;
            txtBox_ConsoleOutput.Name = "txtBox_ConsoleOutput";
            txtBox_ConsoleOutput.Size = new Size(378, 163);
            txtBox_ConsoleOutput.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_Add, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_Log, 1, 2);
            tableLayoutPanel1.Controls.Add(lbl_Add, 0, 0);
            tableLayoutPanel1.Controls.Add(cmb_Select, 1, 1);
            tableLayoutPanel1.Controls.Add(txtb_GameName, 0, 1);
            tableLayoutPanel1.Location = new Point(23, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.Size = new Size(557, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 4;
            label1.Text = "Select Game:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(3, 105);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(112, 34);
            btn_Add.TabIndex = 0;
            btn_Add.Text = "Add Game";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Log
            // 
            btn_Log.Location = new Point(281, 105);
            btn_Log.Name = "btn_Log";
            btn_Log.Size = new Size(112, 34);
            btn_Log.TabIndex = 1;
            btn_Log.Text = "Start Game";
            btn_Log.UseVisualStyleBackColor = true;
            btn_Log.Click += btn_Log_Click;
            // 
            // lbl_Add
            // 
            lbl_Add.AutoSize = true;
            lbl_Add.Location = new Point(3, 0);
            lbl_Add.Name = "lbl_Add";
            lbl_Add.Size = new Size(155, 25);
            lbl_Add.TabIndex = 3;
            lbl_Add.Text = "Add a New Game:";
            // 
            // cmb_Select
            // 
            cmb_Select.FormattingEnabled = true;
            cmb_Select.Location = new Point(281, 54);
            cmb_Select.Name = "cmb_Select";
            cmb_Select.Size = new Size(182, 33);
            cmb_Select.TabIndex = 2;
            // 
            // txtb_GameName
            // 
            txtb_GameName.Location = new Point(3, 54);
            txtb_GameName.Name = "txtb_GameName";
            txtb_GameName.Size = new Size(150, 31);
            txtb_GameName.TabIndex = 5;
            // 
            // timer_LogLapsed
            // 
            timer_LogLapsed.Interval = 1000;
            timer_LogLapsed.Tick += timer_LogLapsed_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveGameLibraryToolStripMenuItem, loadGameLibraryToolStripMenuItem });
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(62, 29);
            filesToolStripMenuItem.Text = "Files";
            // 
            // saveGameLibraryToolStripMenuItem
            // 
            saveGameLibraryToolStripMenuItem.Name = "saveGameLibraryToolStripMenuItem";
            saveGameLibraryToolStripMenuItem.Size = new Size(270, 34);
            saveGameLibraryToolStripMenuItem.Text = "Save Game Library";
            saveGameLibraryToolStripMenuItem.Click += saveGameLibraryToolStripMenuItem_Click;
            // 
            // loadGameLibraryToolStripMenuItem
            // 
            loadGameLibraryToolStripMenuItem.Name = "loadGameLibraryToolStripMenuItem";
            loadGameLibraryToolStripMenuItem.Size = new Size(270, 34);
            loadGameLibraryToolStripMenuItem.Text = "Load Game Library";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_Add;
        private Button btn_Log;
        private ComboBox cmb_Select;
        private Label lbl_Add;
        private Label label1;
        private TextBox txtb_GameName;
        private SplitContainer splitContainer3;
        private TextBox txtBox_ConsoleOutput;
        private TextBox txtBox_TimerOutput;
        private System.Windows.Forms.Timer timer_LogLapsed;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem saveGameLibraryToolStripMenuItem;
        private ToolStripMenuItem loadGameLibraryToolStripMenuItem;
    }
}
