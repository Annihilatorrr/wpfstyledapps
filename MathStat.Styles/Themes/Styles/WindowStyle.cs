using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MathStat.Styles.Controls;

namespace MathStat.Styles.Themes.Styles
{
    public partial class WindowStyle: ResourceDictionary
    {
        public WindowStyle()
        {
            //InitializeComponent();
        }

        public void OnThemeClick(object sender, RoutedEventArgs e)
        {
            var window = (CustomTitleBarWindow)((FrameworkElement)sender).TemplatedParent;
            window.ThemeClick(window, e);
        }

        public void OnCloseClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            window.Close();
        }

        public void OnMaximizeRestoreClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            if (window.WindowState == WindowState.Normal)
            {
                window.WindowState = WindowState.Maximized;
            }
            else
            {
                window.WindowState = WindowState.Normal;
            }
        }

        public void OnMinimizeClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            window.WindowState = WindowState.Minimized;
        }

        public void LanguagesListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lbi = ((sender as ComboBox).SelectedItem as TextBlock);
            var window = (CustomTitleBarWindow)((FrameworkElement)sender).TemplatedParent;
            window.OnLanguageChanged(lbi.Text);
        }
    }
}
