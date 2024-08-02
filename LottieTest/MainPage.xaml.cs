using Microsoft.UI;

namespace LottieTest;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        _stackPanel.Children.Add(new ProgressRing
        {
            IsActive = true,
            Foreground = new SolidColorBrush(Colors.Pink)
        });
    }
}
