namespace version_in_flyout_footer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            BindingContext = this;
            AppVersion = $"Version {AppInfo.Current.VersionString}";
            InitializeComponent();
        }
        public string AppVersion { get; }
    }
}