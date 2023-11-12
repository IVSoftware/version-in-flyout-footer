# Version in Flyout Footer

What you're doing seems pretty close. Just set up your binding for the `Label.Text`:

```
<Label
    x:Name="lblVersion"
    Text="{Binding AppVersion}"
    TextColor="Red"             
    FontAutoScalingEnabled="True"
    FontSize="Body"
    VerticalOptions="EndAndExpand" 
    HorizontalOptions="Center"
    Margin="10"/>
```

Then make sure the both the value and the binding context are set prior to the call to `InitializeComponent();`

```
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
```
Should work:

[![screenshot][1]][1]

___

**Alternative**

You may want to experiment with instantiating a `FlyoutFooter` on the spot, instead of a template.

```
<?xml version="1.0" encoding="UTF-8" ?>
<Shell
    x:Class="version_in_flyout_footer.AppShell"
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:local="clr-namespace:version_in_flyout_footer"
    Shell.FlyoutBackgroundColor="Azure"
    Shell.FlyoutWidth="200"
    FlyoutIsPresented="True"
    Shell.FlyoutBehavior="Flyout">
    <ShellContent
        Title="Home"
        ContentTemplate="{DataTemplate local:MainPage}"
        Route="MainPage" >
    </ShellContent>
    <FlyoutItem Title="News">
        <ShellContent  />
    </FlyoutItem>

    <FlyoutItem Title="About">
        <ShellContent  />
    </FlyoutItem>
    <Shell.FlyoutFooter>
        <Grid 
            ColumnDefinitions="0.8*,0.2*"
            Padding="10">
            <Label
                x:Name="lblVersion"
                TextColor="Red"             
                FontAutoScalingEnabled="True"
                FontSize="Body"
                VerticalOptions="EndAndExpand" 
                HorizontalOptions="Center"
                Margin="10"/>
        </Grid>
    </Shell.FlyoutFooter>
</Shell>
``` 

... and just set the value.

```
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        lblVersion.Text = $"Version {AppInfo.Current.VersionString}";
    }
    public string AppVersion { get; }
}
```

  [1]: https://i.stack.imgur.com/X8G5A.png