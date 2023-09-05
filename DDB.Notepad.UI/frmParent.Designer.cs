namespace DDB.Notepad.UI
{
    partial class frmParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileAddChild = new ToolStripMenuItem();
            mnuFileTileHorizontal = new ToolStripMenuItem();
            mnuFileCloseAll = new ToolStripMenuItem();
            mnuFileAddMany = new ToolStripMenuItem();
            mnuFileTileCascade = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileAddChild, mnuFileTileHorizontal, mnuFileCloseAll, mnuFileAddMany, mnuFileTileCascade });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "&File";
            // 
            // mnuFileAddChild
            // 
            mnuFileAddChild.Name = "mnuFileAddChild";
            mnuFileAddChild.ShortcutKeys = Keys.Control | Keys.A;
            mnuFileAddChild.Size = new Size(187, 22);
            mnuFileAddChild.Text = "Add Child";
            mnuFileAddChild.Click += mnuFileAddChild_Click;
            // 
            // mnuFileTileHorizontal
            // 
            mnuFileTileHorizontal.Name = "mnuFileTileHorizontal";
            mnuFileTileHorizontal.Size = new Size(187, 22);
            mnuFileTileHorizontal.Text = "Tile Horizontal";
            mnuFileTileHorizontal.Click += mnuFileTileHorizontal_Click;
            // 
            // mnuFileCloseAll
            // 
            mnuFileCloseAll.Name = "mnuFileCloseAll";
            mnuFileCloseAll.Size = new Size(187, 22);
            mnuFileCloseAll.Text = "Close All Child Forms";
            mnuFileCloseAll.Click += closeAllCToolStripMenuItem_Click;
            // 
            // mnuFileAddMany
            // 
            mnuFileAddMany.Name = "mnuFileAddMany";
            mnuFileAddMany.Size = new Size(187, 22);
            mnuFileAddMany.Text = "Add Many";
            mnuFileAddMany.Click += mnuFileAddMany_Click;
            // 
            // mnuFileTileCascade
            // 
            mnuFileTileCascade.Name = "mnuFileTileCascade";
            mnuFileTileCascade.Size = new Size(187, 22);
            mnuFileTileCascade.Text = "Tile Cascade";
            mnuFileTileCascade.Click += mnuFileTileCascade_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 17);
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmParent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmParent";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileAddChild;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripMenuItem mnuFileTileHorizontal;
        private ToolStripMenuItem mnuFileCloseAll;
        private ToolStripMenuItem mnuFileAddMany;
        private ToolStripMenuItem mnuFileTileCascade;
    }
}