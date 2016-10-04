using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProgressBar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            var diameter = ProgressBar.TemplateSettings.EllipseDiameter;
        }
    }
}
