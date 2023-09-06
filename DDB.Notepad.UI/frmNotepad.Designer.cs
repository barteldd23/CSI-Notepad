namespace DDB.Notepad.UI
{
    partial class frmNotepad
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
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileNew = new ToolStripMenuItem();
            mnuFileOpen = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuFileExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            btnTimerToggle = new Button();
            btnWrite = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            btnWriteAppend = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            btnReadByLine = new Button();
            btnCopy = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            lblInfo = new Label();
            txtInfo = new TextBox();
            lbxInfo = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            trackBar1 = new TrackBar();
            menuStrip1.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1010, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNew, mnuFileOpen, toolStripMenuItem1, mnuFileExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            mnuFileNew.Name = "mnuFileNew";
            mnuFileNew.Size = new Size(135, 22);
            mnuFileNew.Text = "&New";
            // 
            // mnuFileOpen
            // 
            mnuFileOpen.Name = "mnuFileOpen";
            mnuFileOpen.Size = new Size(135, 22);
            mnuFileOpen.Text = "&Open";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(132, 6);
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuFileExit.Size = new Size(135, 22);
            mnuFileExit.Text = "E&xit";
            mnuFileExit.Click += mnuFileExit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(103, 22);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // btnTimerToggle
            // 
            btnTimerToggle.Location = new Point(12, 43);
            btnTimerToggle.Name = "btnTimerToggle";
            btnTimerToggle.Size = new Size(99, 23);
            btnTimerToggle.TabIndex = 1;
            btnTimerToggle.Text = "ON";
            btnTimerToggle.UseVisualStyleBackColor = true;
            btnTimerToggle.Click += btnTimerToggle_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(12, 72);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(99, 23);
            btnWrite.TabIndex = 2;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(12, 101);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(99, 23);
            btnRead.TabIndex = 3;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnWriteAppend
            // 
            btnWriteAppend.Location = new Point(12, 159);
            btnWriteAppend.Name = "btnWriteAppend";
            btnWriteAppend.Size = new Size(99, 23);
            btnWriteAppend.TabIndex = 5;
            btnWriteAppend.Text = "Write Append";
            btnWriteAppend.UseVisualStyleBackColor = true;
            btnWriteAppend.Click += btnWriteAppend_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 304);
            button6.Name = "button6";
            button6.Size = new Size(99, 23);
            button6.TabIndex = 10;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 275);
            button7.Name = "button7";
            button7.Size = new Size(99, 23);
            button7.TabIndex = 9;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(12, 246);
            button8.Name = "button8";
            button8.Size = new Size(99, 23);
            button8.TabIndex = 8;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // btnReadByLine
            // 
            btnReadByLine.Location = new Point(12, 217);
            btnReadByLine.Name = "btnReadByLine";
            btnReadByLine.Size = new Size(99, 23);
            btnReadByLine.TabIndex = 7;
            btnReadByLine.Text = "Read By Line";
            btnReadByLine.UseVisualStyleBackColor = true;
            btnReadByLine.Click += btnReadByLine_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(12, 188);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(99, 23);
            btnCopy.TabIndex = 6;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // button12
            // 
            button12.Location = new Point(12, 420);
            button12.Name = "button12";
            button12.Size = new Size(99, 23);
            button12.TabIndex = 14;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(12, 391);
            button13.Name = "button13";
            button13.Size = new Size(99, 23);
            button13.TabIndex = 13;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(12, 362);
            button14.Name = "button14";
            button14.Size = new Size(99, 23);
            button14.TabIndex = 12;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(12, 333);
            button15.Name = "button15";
            button15.Size = new Size(99, 23);
            button15.TabIndex = 11;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            lblInfo.BorderStyle = BorderStyle.FixedSingle;
            lblInfo.Location = new Point(133, 43);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(433, 197);
            lblInfo.TabIndex = 15;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(133, 247);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(433, 196);
            txtInfo.TabIndex = 16;
            // 
            // lbxInfo
            // 
            lbxInfo.FormattingEnabled = true;
            lbxInfo.ItemHeight = 15;
            lbxInfo.Location = new Point(613, 43);
            lbxInfo.Name = "lbxInfo";
            lbxInfo.Size = new Size(368, 409);
            lbxInfo.TabIndex = 17;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 500);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1010, 22);
            statusStrip.TabIndex = 18;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 17);
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(137, 449);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(429, 45);
            trackBar1.TabIndex = 19;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // frmNotepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 522);
            Controls.Add(trackBar1);
            Controls.Add(statusStrip);
            Controls.Add(lbxInfo);
            Controls.Add(txtInfo);
            Controls.Add(lblInfo);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(btnReadByLine);
            Controls.Add(btnCopy);
            Controls.Add(btnWriteAppend);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Controls.Add(btnTimerToggle);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmNotepad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notepad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem mnuFileExit;
        private Button btnTimerToggle;
        private Button btnWrite;
        private Button btnRead;
        private Button btnDelete;
        private Button btnWriteAppend;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btnReadByLine;
        private Button btnCopy;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Label lblInfo;
        private TextBox txtInfo;
        private ListBox lbxInfo;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private TrackBar trackBar1;
    }
}