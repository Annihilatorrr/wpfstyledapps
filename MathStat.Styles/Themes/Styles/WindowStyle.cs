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
            var window = (CustomTitleBarWindow)((FrameworkElement)sender).TemplatedParent;
            window.RaiseLanguageChanged();
        }

        //private void OnThemeClick(object sender, DependencyPropertyChangedEventArgs e)
        //{
        //    throw new System.NotImplementedException();
        //}
        private void ImageToggleButton_OnThemeClicked(object? sender, string e)
        {
            //this.
            var window = (CustomTitleBarWindow)((FrameworkElement)sender).TemplatedParent;
            window.RaiseThemeClicked(window, e);
        }
    }
}
