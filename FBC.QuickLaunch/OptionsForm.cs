using System.Text.Json;

namespace FBC.QuickLaunch
{
    public partial class OptionsForm : Form
    {
        List<TrayIcon> trayIcons = new List<TrayIcon>();
        string configPath = "./applications.json";
        public OptionsForm(string configPath)
        {
            InitializeComponent();
            this.configPath = configPath;
            this.Text += $" - {Path.GetFullPath(configPath)}";
            ucTrayIcons.IconsModified += (s, e) =>
            {
                lblModified.Visible = true;
            };
            loadConfig();

        }
        private void loadConfig()
        {
            if (File.Exists(this.configPath))
            {
                trayIcons = JsonSerializer.Deserialize<List<TrayIcon>>(File.ReadAllText(configPath))!;
                ucTrayIcons.TrayIcons = trayIcons;
            }
            else
            {
                trayIcons = new List<TrayIcon>();
                ucTrayIcons.TrayIcons = trayIcons;
            }
            lblModified.Visible = false;
        }
        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            trayIcons = ucTrayIcons.TrayIcons;
            //Write intended
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            File.WriteAllText(configPath, JsonSerializer.Serialize(trayIcons, options));
            lblModified.Visible = false;
        }

        private void btnReloadConfig_Click(object sender, EventArgs e)
        {
            loadConfig();
        }
    }
}
