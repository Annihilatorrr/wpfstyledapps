using System;
using System.Linq;
using System.Windows;
using MathStat.Styles;
using MathStat.Styles.Controls;
using MathStat.Localization;
using MathStat.Styles.Models;

namespace MathStat.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : CustomTitleBarWindow
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

        private void OnThemeChanged(object sender, EventArgs e)
        {
            var theme = Theme.ThemeType == ThemeType.Light ? ThemeType.Dark : ThemeType.Light;
            Theme.LoadThemeType(theme);
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            var translation = LanguageId.Ru;
            SelectedLanguage = Languages.First(l => l.Id == translation.ToString().ToLower());
            Translation.Load(translation);
        }
    }
}
