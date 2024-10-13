using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace FBC.QuickLaunch
{
    public class TrayIcon : INotifyPropertyChanged
    {
        private string? _appPath;
        private string? _workingDirectory;
        private string? _previousAppPath;
        private string? _appTitle;
        private string? _appIcon;
        private string? _appArguments;
        private bool _isSeparator;
        private bool _runAsAdmin;
        public TrayIcon()
        {
            _isSeparator = true;
        }
        public TrayIcon(string appPath)
        {
            AppPath = appPath;
        }
        public string? AppPath
        {
            get => _appPath;
            set
            {
                if (_appPath != value)
                {
                    _previousAppPath = _appPath;
                    _appPath = value;
                    OnPropertyChanged();
                    if ((string.IsNullOrEmpty(AppTitle) || AppTitle == invalidPath || AppTitle == getFileName(_previousAppPath)) && !string.IsNullOrEmpty(value))
                    {
                        AppTitle = getFileName(value);
                    }

                    if (string.IsNullOrEmpty(WorkingDirectory) || WorkingDirectory == invalidPath)
                    {
                        WorkingDirectory = getWorkingDirectory(value);
                    }
                }
            }
        }
        public string? WorkingDirectory
        {
            get => _workingDirectory;
            set
            {
                if (_workingDirectory != value)
                {
                    _workingDirectory = value;
                    OnPropertyChanged();
                }
            }
        }

        public string? AppTitle
        {
            get => _appTitle;
            set
            {
                if (_appTitle != value)
                {
                    _appTitle = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        public string? AppIcon
        {
            get => _appIcon;
            set
            {
                if (_appIcon != value)
                {
                    _appIcon = value;
                    OnPropertyChanged();
                }
            }
        }

        public string? AppArguments
        {
            get => _appArguments;
            set
            {
                if (_appArguments != value)
                {
                    _appArguments = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsSeparator
        {
            get => _isSeparator;
            set
            {
                if (_isSeparator != value)
                {
                    _isSeparator = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        public bool RunAsAdmin
        {
            get => _runAsAdmin;
            set
            {
                if (_runAsAdmin != value)
                {
                    _runAsAdmin = value;
                    OnPropertyChanged();
                }
            }
        }
        const string invalidPath = "<Invalid Path>";

        string getWorkingDirectory(string? path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return invalidPath;
            }
            try
            {
                var r = Path.GetDirectoryName(path);
                return string.IsNullOrEmpty((r ?? "").Trim()) ? invalidPath : r!.Trim();
            }
            catch
            {
                return invalidPath;
            }
        }
        string getFileName(string? path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return invalidPath;
            }
            try
            {
                var r = Path.GetFileNameWithoutExtension(path);
                return string.IsNullOrEmpty((r ?? "").Trim()) ? invalidPath : r!.Trim();
            }
            catch
            {
                return invalidPath;
            }
        }
        public string Title
        {
            get
            {
                string r = IsSeparator
                ? "-------"
                : string.IsNullOrEmpty(AppTitle)
                    ? string.IsNullOrEmpty(AppPath) ? "<No Name>"
                    : getFileName(AppPath)
                : AppTitle;
                if (!IsSeparator && RunAsAdmin)
                {
                    r += " (Admin)";
                }
                return r;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public TrayIcon Clone()
        {
            return new TrayIcon
            {
                AppPath = AppPath,
                AppTitle = AppTitle,
                AppIcon = AppIcon,
                AppArguments = AppArguments,
                IsSeparator = IsSeparator,
                RunAsAdmin = RunAsAdmin
            };
        }

        public Image? GetIcon()
        {
                if (!string.IsNullOrEmpty(AppIcon))
                {
                    try
                    {
                        return Image.FromFile(AppIcon);
                    }
                    catch
                    {
                        return null;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(AppPath))
                    {
                        try
                        {
                            Icon icon = Icon.ExtractAssociatedIcon(AppPath);
                           return icon.ToBitmap();
                        }
                        catch
                        {
                            return null;
                        }
                    }
                    else
                    {
                       return null;

                    }
                }
        }
    }
}