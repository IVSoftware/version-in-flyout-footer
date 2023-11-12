namespace version_in_flyout_footer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            BindingContext = this;  
            InitializeComponent(); 
        }
        public string AppVersion { get; } = $"Version {AppInfo.Current.VersionString}";
    }
}