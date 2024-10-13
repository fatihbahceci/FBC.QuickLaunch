namespace FBC.QuickLaunch
{
    public partial class UCTrayIcon : UserControl
    {
        private TrayIcon model;
        public event EventHandler? SaveCliked;
        public event EventHandler? CancelClicked;
        private void initModel()
        {
            bsModel.DataSource = model;
            pOtherFields.Enabled = !model.IsSeparator;
            LoadIconToPictureBox();
            model.PropertyChanged += (s, e) =>
            {
                switch (e.PropertyName)
                {
                    case nameof(model.IsSeparator):
                        pOtherFields.Enabled = !model.IsSeparator;
                        break;
                    case nameof(model.AppPath):
                    case nameof(model.AppIcon):
                        LoadIconToPictureBox();
                        break;
                }
            };
        }
        public TrayIcon Model
        {
            get => model; set
            {
                model = value ?? new TrayIcon();
                initModel();
            }
        }
        public UCTrayIcon()
        {
            InitializeComponent();
            model = new TrayIcon();
            if (!DesignMode)
            {
                initModel();
            }
        }

        private void LoadIconToPictureBox()
        {
            pbIcon.Image = model.GetIcon();
            //Make image fit the picture box if it has an image
            if (pbIcon.Image != null)
            {
                pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbIcon.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            //Choose the executable app path
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Executable files (*.exe)|*.exe";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    model.AppPath = ofd.FileName;
                }
            }
        }

        private void btnBrowseForIcon_Click(object sender, EventArgs e)
        {
            //Choose the icon file or image file
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Icon files (*.ico)|*.ico|Image files (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    model.AppIcon = ofd.FileName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCliked?.Invoke(this, EventArgs.Empty);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);

        }
    }
}
