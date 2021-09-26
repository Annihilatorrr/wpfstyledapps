using System;
using System.Windows;

namespace MathStat.Styles.Controls
{
    public class CustomTitleBarWindow : Window
    {
        public event EventHandler<string> LanguageChanged;

        public Visibility IsMinimizeButtonVisible
        {
            get => (Visibility)GetValue(IsMinimizeButtonVisibleProperty);
            set => SetValue(IsMinimizeButtonVisibleProperty, value);
        }

        public static readonly DependencyProperty IsMinimizeButtonVisibleProperty =
            DependencyProperty.Register("IsMinimizeButtonVisible", typeof(Visibility), typeof(CustomTitleBarWindow), new PropertyMetadata(null));

        public static readonly DependencyProperty IsMaximizeRestoreButtonVisibleProperty =
            DependencyProperty.Register("IsMaximizeRestoreButtonVisible", typeof(Visibility), typeof(CustomTitleBarWindow), new PropertyMetadata(null));
        public Visibility IsMaximizeRestoreButtonVisible
        {
            get => (Visibility)GetValue(IsMaximizeRestoreButtonVisibleProperty);
            set => SetValue(IsMaximizeRestoreButtonVisibleProperty, value);
        }

        public void ThemeClick(object sender, RoutedEventArgs e)
        {
            var theme = Theme.ThemeType == ThemeType.Light ? ThemeType.Dark : ThemeType.Light;
            Theme.LoadThemeType(theme);
        }

        public void OnLanguageChanged(string language)
        {
            LanguageChanged(this, language);
        }
    }
}
