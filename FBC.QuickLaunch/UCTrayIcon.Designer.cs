namespace FBC.QuickLaunch
{
    partial class UCTrayIcon
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            bsModel = new BindingSource(components);
            cbIsSeparator = new CheckBox();
            pOtherFields = new Panel();
            pbIcon = new PictureBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            btnBrowseForIcon = new Button();
            textBox3 = new TextBox();
            btnSelectPath = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)bsModel).BeginInit();
            pOtherFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.DataBindings.Add(new Binding("Text", bsModel, "Title", true, DataSourceUpdateMode.OnPropertyChanged));
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(83, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // bsModel
            // 
            bsModel.DataSource = typeof(TrayIcon);
            // 
            // cbIsSeparator
            // 
            cbIsSeparator.AutoSize = true;
            cbIsSeparator.DataBindings.Add(new Binding("Checked", bsModel, "IsSeparator", true, DataSourceUpdateMode.OnPropertyChanged));
            cbIsSeparator.Location = new Point(16, 59);
            cbIsSeparator.Name = "cbIsSeparator";
            cbIsSeparator.Size = new Size(84, 19);
            cbIsSeparator.TabIndex = 1;
            cbIsSeparator.Text = "IsSeparator";
            cbIsSeparator.UseVisualStyleBackColor = true;
            // 
            // pOtherFields
            // 
            pOtherFields.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pOtherFields.Controls.Add(pbIcon);
            pOtherFields.Controls.Add(label3);
            pOtherFields.Controls.Add(checkBox1);
            pOtherFields.Controls.Add(textBox2);
            pOtherFields.Controls.Add(btnBrowseForIcon);
            pOtherFields.Controls.Add(textBox3);
            pOtherFields.Controls.Add(btnSelectPath);
            pOtherFields.Controls.Add(textBox5);
            pOtherFields.Controls.Add(textBox4);
            pOtherFields.Controls.Add(textBox1);
            pOtherFields.Controls.Add(label2);
            pOtherFields.Controls.Add(label5);
            pOtherFields.Controls.Add(label4);
            pOtherFields.Controls.Add(label1);
            pOtherFields.Location = new Point(16, 97);
            pOtherFields.Name = "pOtherFields";
            pOtherFields.Size = new Size(566, 325);
            pOtherFields.TabIndex = 2;
            // 
            // pbIcon
            // 
            pbIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbIcon.Location = new Point(485, 243);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(64, 64);
            pbIcon.TabIndex = 5;
            pbIcon.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 211);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "AppIcon";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new Binding("Checked", bsModel, "RunAsAdmin", true, DataSourceUpdateMode.OnPropertyChanged));
            checkBox1.Location = new Point(24, 259);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Run As Admin";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bsModel, "AppTitle", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.Location = new Point(124, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 3;
            // 
            // btnBrowseForIcon
            // 
            btnBrowseForIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseForIcon.Location = new Point(486, 207);
            btnBrowseForIcon.Name = "btnBrowseForIcon";
            btnBrowseForIcon.Size = new Size(63, 23);
            btnBrowseForIcon.TabIndex = 2;
            btnBrowseForIcon.Text = "...";
            btnBrowseForIcon.UseVisualStyleBackColor = true;
            btnBrowseForIcon.Click += btnBrowseForIcon_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.DataBindings.Add(new Binding("Text", bsModel, "AppIcon", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox3.Location = new Point(124, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(357, 23);
            textBox3.TabIndex = 1;
            // 
            // btnSelectPath
            // 
            btnSelectPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectPath.Location = new Point(486, 15);
            btnSelectPath.Name = "btnSelectPath";
            btnSelectPath.Size = new Size(63, 23);
            btnSelectPath.TabIndex = 2;
            btnSelectPath.Text = "...";
            btnSelectPath.UseVisualStyleBackColor = true;
            btnSelectPath.Click += btnSelectPath_Click;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.DataBindings.Add(new Binding("Text", bsModel, "WorkingDirectory", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox5.Location = new Point(124, 63);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(426, 23);
            textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.DataBindings.Add(new Binding("Text", bsModel, "AppArguments", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox4.Location = new Point(124, 111);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(426, 23);
            textBox4.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", bsModel, "AppPath", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.Location = new Point(124, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 163);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "AppTitle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 67);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 0;
            label5.Text = "WorkingDirectory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 115);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "AppArguments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "AppPath";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(422, 439);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Update";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(507, 439);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UCTrayIcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pOtherFields);
            Controls.Add(cbIsSeparator);
            Controls.Add(lblTitle);
            Name = "UCTrayIcon";
            Size = new Size(594, 477);
            ((System.ComponentModel.ISupportInitialize)bsModel).EndInit();
            pOtherFields.ResumeLayout(false);
            pOtherFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private BindingSource bsModel;
        private CheckBox cbIsSeparator;
        private Panel pOtherFields;
        private Label label1;
        private Button btnSelectPath;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button btnBrowseForIcon;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private CheckBox checkBox1;
        private PictureBox pbIcon;
        private Button btnSave;
        private Button btnCancel;
        private TextBox textBox5;
        private Label label5;
    }
}
