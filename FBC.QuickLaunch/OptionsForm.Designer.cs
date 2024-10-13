namespace FBC.QuickLaunch
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            ucTrayIcons = new UCTrayIcons();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSaveConfig = new Button();
            btnReloadConfig = new Button();
            lblModified = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ucTrayIcons
            // 
            ucTrayIcons.Dock = DockStyle.Fill;
            ucTrayIcons.Location = new Point(0, 0);
            ucTrayIcons.Name = "ucTrayIcons";
            ucTrayIcons.Size = new Size(884, 498);
            ucTrayIcons.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSaveConfig);
            flowLayoutPanel1.Controls.Add(lblModified);
            flowLayoutPanel1.Controls.Add(btnReloadConfig);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 498);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(884, 49);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.AutoSize = true;
            btnSaveConfig.Location = new Point(3, 3);
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.Size = new Size(80, 25);
            btnSaveConfig.TabIndex = 0;
            btnSaveConfig.Text = "Save Config";
            btnSaveConfig.UseVisualStyleBackColor = true;
            btnSaveConfig.Click += btnSaveConfig_Click;
            // 
            // btnReloadConfig
            // 
            btnReloadConfig.AutoSize = true;
            btnReloadConfig.Location = new Point(152, 3);
            btnReloadConfig.Name = "btnReloadConfig";
            btnReloadConfig.Size = new Size(125, 25);
            btnReloadConfig.TabIndex = 0;
            btnReloadConfig.Text = "Reload/Reset Config";
            btnReloadConfig.UseVisualStyleBackColor = true;
            btnReloadConfig.Click += btnReloadConfig_Click;
            // 
            // lblModified
            // 
            lblModified.Anchor = AnchorStyles.Left;
            lblModified.AutoSize = true;
            lblModified.BackColor = Color.Red;
            lblModified.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModified.ForeColor = Color.White;
            lblModified.Location = new Point(89, 8);
            lblModified.Name = "lblModified";
            lblModified.Size = new Size(57, 15);
            lblModified.TabIndex = 1;
            lblModified.Text = "Modified";
            lblModified.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 547);
            Controls.Add(ucTrayIcons);
            Controls.Add(flowLayoutPanel1);
            Name = "OptionsForm";
            Text = "Options";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UCTrayIcons ucTrayIcons;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSaveConfig;
        private Button btnReloadConfig;
        private Label lblModified;
    }
}
