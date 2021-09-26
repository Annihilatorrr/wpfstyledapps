using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using MathStat.Styles.Models;

namespace MathStat.Styles.Controls
{
    public class CustomTitleBarWindow : Window
    {
        public CustomTitleBarWindow()
        {
            Languages = new List<LanguageModel>()
            {
                new LanguageModel() {Id="en", LanguageName = "EN", LanguagePicture = "../../Images/en.ico" },
                new LanguageModel() {Id="ru", LanguageName = "RU", LanguagePicture = "../../Images/ru.ico" }
            };
        }

        public event EventHandler<string> LanguageChanged;

        public LanguageModel SelectedLanguage { get; set; }

        public static readonly DependencyProperty LanguagesProperty =
            DependencyProperty.Register("Languages", typeof(List<LanguageModel>), typeof(CustomTitleBarWindow), new PropertyMetadata(null));

        public List<LanguageModel> Languages
        {
            get => (List<LanguageModel>)GetValue(LanguagesProperty);
            set => SetValue(LanguagesProperty, value);
        }

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

        public void RaiseLanguageChanged()
        {
            LanguageChanged?.Invoke(this, SelectedLanguage.Id);
        }
    }
}
