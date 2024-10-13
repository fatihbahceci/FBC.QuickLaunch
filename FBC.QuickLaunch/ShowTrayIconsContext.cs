using System.Diagnostics;
using System.Text.Json;

namespace FBC.QuickLaunch
{
    public class ShowTrayIconsContext : ApplicationContext
    {
        private NotifyIcon trayIcon = new NotifyIcon()
        {
            Icon = SystemIcons.Application,
            ContextMenuStrip = new ContextMenuStrip(),
            Visible = true
        };
        private string configFilePath = "./applications.json";

        void Exit(object? sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }
        void ShowOptions(object? sender, EventArgs e)
        {
            new OptionsForm(configFilePath).ShowDialog();
            Exit(sender, e);
        }
        private void LoadApps()
        {
            if (!File.Exists(configFilePath))
            {
                return;
            }
            var apps = JsonSerializer.Deserialize<List<TrayIcon>>(File.ReadAllText(configFilePath));
            foreach (var app in apps!)
            {
                AddAppToMenu(app);
            }
        }

        void AddAppToMenu(TrayIcon item)
        {

            if (item.IsSeparator)
            {
                trayIcon.ContextMenuStrip!.Items.Add(new ToolStripSeparator());
                return;
            }

            var menuItem = new ToolStripMenuItem(item.Title);
            var img = item.GetIcon();
            if (img != null)
            {
                menuItem.Image = img;
            }
            menuItem.Click += (sender, e) =>
            {
                try
                {
                    var psi = new ProcessStartInfo(item.AppPath!)
                    {
                        UseShellExecute = true,
                        Verb = item.RunAsAdmin ? "runas" : null,
                        Arguments = item.AppArguments
                    };
                    if (!string.IsNullOrEmpty(item.WorkingDirectory))
                    {
                        psi.WorkingDirectory = item.WorkingDirectory;
                    }
                    Process.Start(psi);

                }
                finally
                {
                    Exit(sender, e);
                }
            };
            trayIcon.ContextMenuStrip!.Items.Add(menuItem);
        }
        public ShowTrayIconsContext()
        {
            LoadApps();
            if (trayIcon.ContextMenuStrip!.Items.Count == 0)
            {
                trayIcon.ContextMenuStrip.Items.Add("No apps found... Click to open Options", null, ShowOptions);
            }
            trayIcon.ContextMenuStrip!.Items.Add(new ToolStripSeparator());
            // Add the options.
            trayIcon.ContextMenuStrip.Items.Add("Options", null, ShowOptions);
            trayIcon.ContextMenuStrip.Items.Add("Exit", null, Exit);
            //Open the context menu.
            Point cursorPosition = Cursor.Position;
            trayIcon.ContextMenuStrip.Show(cursorPosition);
        }
    }
}