using Windows.UI.Xaml;

namespace ProgressBar
{
    public sealed class MyProgressBar : Windows.UI.Xaml.Controls.ProgressBar
    {
        public MyProgressBar()
        {
            this.DefaultStyleKey = typeof (Windows.UI.Xaml.Controls.ProgressBar);
            this.Loaded += (sender, args) => TemplateSettings = new MyProgressBarTemplateSettings(this);
        }

        public static readonly DependencyProperty TemplateSettingsProperty = DependencyProperty.Register(
            "TemplateSettings", typeof (MyProgressBarTemplateSettings), typeof (MyProgressBar),
            new PropertyMetadata(default(MyProgressBarTemplateSettings)));

        public new MyProgressBarTemplateSettings TemplateSettings
        {
            get { return (MyProgressBarTemplateSettings) GetValue(TemplateSettingsProperty); }
            set { SetValue(TemplateSettingsProperty, value); }
        }
    }

    public class MyProgressBarTemplateSettings : DependencyObject
    {
        public MyProgressBarTemplateSettings()
        {
        }

        public MyProgressBarTemplateSettings(MyProgressBar progressBar)
        {
            ContainerAnimationStartPosition = -1*progressBar.ActualWidth / 10;
            ContainerAnimationEndPosition = progressBar.ActualWidth * 3/8;
            EllipseAnimationEndPosition = progressBar.ActualWidth * 2/3;
            EllipseAnimationWellPosition = progressBar.ActualWidth / 3;
            EllipseOffset = 4;
            EllipseDiameter = 12;
        }

        public double ContainerAnimationEndPosition { get; set; }
        public double ContainerAnimationStartPosition { get; set; }
        public double EllipseAnimationEndPosition { get; set; }
        public double EllipseAnimationWellPosition { get; set; }
        public double EllipseDiameter { get; set; }
        public double EllipseOffset { get; set; }
        public double IndicatorLengthDelta { get; set; }
    }
}
