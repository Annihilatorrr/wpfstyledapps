using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
                new() {Id="en", LanguageName = "EN", LanguagePicture = "../../Images/en.ico" },
                new() {Id="ru", LanguageName = "RU", LanguagePicture = "../../Images/ru.ico" }
            };
            SelectedLanguage = Languages.First();
        }

        public event EventHandler<string> LanguageChanged;
        public event EventHandler ThemeClicked;

        public LanguageModel SelectedLanguage { get; set; }

        #region Dependency properties

        public static readonly DependencyProperty LanguagesProperty =
            DependencyProperty.Register("Languages", typeof(List<LanguageModel>), typeof(CustomTitleBarWindow), new PropertyMetadata(null));

        public List<LanguageModel> Languages
        {
            get => (List<LanguageModel>)GetValue(LanguagesProperty);
            set => SetValue(LanguagesProperty, value);
        }

        public static readonly DependencyProperty IsMinimizeButtonVisibleProperty =
            DependencyProperty.Register("IsMinimizeButtonVisible", typeof(Visibility), typeof(CustomTitleBarWindow), new PropertyMetadata(null));
        public Visibility IsMinimizeButtonVisible
        {
            get => (Visibility)GetValue(IsMinimizeButtonVisibleProperty);
            set => SetValue(IsMinimizeButtonVisibleProperty, value);
        }

        public static readonly DependencyProperty IsMaximizeRestoreButtonVisibleProperty =
            DependencyProperty.Register("IsMaximizeRestoreButtonVisible", typeof(Visibility), typeof(CustomTitleBarWindow), new PropertyMetadata(null));
        public Visibility IsMaximizeRestoreButtonVisible
        {
            get => (Visibility)GetValue(IsMaximizeRestoreButtonVisibleProperty);
            set => SetValue(IsMaximizeRestoreButtonVisibleProperty, value);
        }

        public static readonly DependencyProperty IsLanguageSwitchComboBoxVisibleProperty =
            DependencyProperty.Register("IsLanguageSwitchComboBoxVisible", typeof(Visibility), typeof(CustomTitleBarWindow), new PropertyMetadata(null));
        public Visibility IsLanguageSwitchComboBoxVisible
        {
            get => (Visibility)GetValue(IsLanguageSwitchComboBoxVisibleProperty);
            set => SetValue(IsLanguageSwitchComboBoxVisibleProperty, value);
        }

        #endregion

        #region Methods

        public void RaiseThemeClicked(object sender, RoutedEventArgs e)
        {
            ThemeClicked?.Invoke(this, EventArgs.Empty);
        }

        public void RaiseLanguageChanged()
        {
            LanguageChanged?.Invoke(this, SelectedLanguage.Id);
        }

        #endregion
    }
}
