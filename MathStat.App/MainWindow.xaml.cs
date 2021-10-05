#nullable enable
using System;
using System.Linq;
using System.Windows;
using MathStat.Styles;
using MathStat.Localization;

namespace MathStat.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLanguageChanged(object? sender, string e)
        {
            var translation = e == "en"? LanguageId.En : LanguageId.Ru;
            Translation.Load(translation);
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            var translation = LanguageId.Ru;
            SelectedLanguage = Languages.First(l => l.Id == translation.ToString().ToLower());
            Translation.Load(translation);
            SelectedTheme = "light";
            Theme.LoadThemeType(ThemeType.Light);
        }

        private void OnThemeChanged(object? sender, string e)
        {
            var theme = e == "dark" ? ThemeType.Dark : ThemeType.Light;
            Theme.LoadThemeType(theme);
        }
    }
}
