namespace FBC.QuickLaunch
{
    partial class UCTrayIcons
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TrayIcon trayIcon1 = new TrayIcon();
            splitContainer1 = new SplitContainer();
            lbTrayIcons = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnNew = new Button();
            btnNewFromFiles = new Button();
            btnDelete = new Button();
            btnUp = new Button();
            btnDown = new Button();
            ucSelectedTrayIcon = new UCTrayIcon();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lbTrayIcons);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ucSelectedTrayIcon);
            splitContainer1.Size = new Size(653, 609);
            splitContainer1.SplitterDistance = 275;
            splitContainer1.TabIndex = 0;
            // 
            // lbTrayIcons
            // 
            lbTrayIcons.Dock = DockStyle.Fill;
            lbTrayIcons.FormattingEnabled = true;
            lbTrayIcons.ItemHeight = 15;
            lbTrayIcons.Location = new Point(0, 0);
            lbTrayIcons.Name = "lbTrayIcons";
            lbTrayIcons.Size = new Size(275, 543);
            lbTrayIcons.TabIndex = 0;
            lbTrayIcons.SelectedIndexChanged += lbTrayIcons_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnNew);
            flowLayoutPanel1.Controls.Add(btnNewFromFiles);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnUp);
            flowLayoutPanel1.Controls.Add(btnDown);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 543);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(275, 66);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.AutoSize = true;
            btnNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNew.Location = new Point(3, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(41, 25);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnNewFromFiles
            // 
            btnNewFromFiles.AutoSize = true;
            btnNewFromFiles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNewFromFiles.Location = new Point(50, 3);
            btnNewFromFiles.Name = "btnNewFromFiles";
            btnNewFromFiles.Size = new Size(50, 25);
            btnNewFromFiles.TabIndex = 0;
            btnNewFromFiles.Tag = "";
            btnNewFromFiles.Text = "New...";
            btnNewFromFiles.UseVisualStyleBackColor = true;
            btnNewFromFiles.Click += btnNewFromFiles_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Location = new Point(106, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 25);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUp
            // 
            btnUp.AutoSize = true;
            btnUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUp.Location = new Point(162, 3);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(65, 25);
            btnUp.TabIndex = 0;
            btnUp.Text = "Move Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.AutoSize = true;
            btnDown.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDown.Location = new Point(3, 34);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(81, 25);
            btnDown.TabIndex = 0;
            btnDown.Text = "Move Down";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // ucSelectedTrayIcon
            // 
            ucSelectedTrayIcon.Dock = DockStyle.Fill;
            ucSelectedTrayIcon.Location = new Point(0, 0);
            trayIcon1.AppArguments = null;
            trayIcon1.AppIcon = null;
            trayIcon1.AppPath = null;
            trayIcon1.AppTitle = null;
            trayIcon1.IsSeparator = true;
            trayIcon1.RunAsAdmin = false;
            trayIcon1.WorkingDirectory = null;
            ucSelectedTrayIcon.Model = trayIcon1;
            ucSelectedTrayIcon.Name = "ucSelectedTrayIcon";
            ucSelectedTrayIcon.Size = new Size(374, 609);
            ucSelectedTrayIcon.TabIndex = 0;
            // 
            // UCTrayIcons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "UCTrayIcons";
            Size = new Size(653, 609);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox lbTrayIcons;
        private FlowLayoutPanel flowLayoutPanel1;
        private UCTrayIcon ucSelectedTrayIcon;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUp;
        private Button btnDown;
        private Button btnNewFromFiles;
    }
}
