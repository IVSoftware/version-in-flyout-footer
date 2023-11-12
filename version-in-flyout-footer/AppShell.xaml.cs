namespace version_in_flyout_footer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            lblVersion.Text = $"Version {AppInfo.Current.VersionString}";
        }
        public string AppVersion { get; }
    }
}