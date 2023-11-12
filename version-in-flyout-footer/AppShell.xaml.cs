namespace version_in_flyout_footer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
            AppVersion = $"Version {AppInfo.Current.VersionString}";
        }
        public string AppVersion
        {
            get => _appVersion;
            set
            {
                if (!Equals(_appVersion, value))
                {
                    _appVersion = value;
                    OnPropertyChanged();
                }
            }
        }
        string _appVersion = string.Empty;

    }
}