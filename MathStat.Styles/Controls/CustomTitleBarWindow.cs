using System;
using System.Windows;

namespace MathStat.Styles.Controls
{
    public class CustomTitleBarWindow : Window
    {
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
    }
}
