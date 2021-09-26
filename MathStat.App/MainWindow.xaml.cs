using MathStat.Styles;
using MathStat.Styles.Controls;
using MathStat.Localization;
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
            var theme = e == "En"? LanguageId.En : LanguageId.Ru;
            MathStat.Localization.Language.LoadLanguage(theme);
        }
    }
}
