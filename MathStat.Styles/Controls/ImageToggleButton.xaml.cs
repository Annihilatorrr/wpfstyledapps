using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MathStat.Styles.Controls
{
    /// <summary>
    /// Interaction logic for ImageToggleButton.xaml
    /// </summary>
    public partial class ImageToggleButton : UserControl
    {
        public event EventHandler<string> ThemeClicked;

        public ImageToggleButton()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty EnabledUncheckedIconProperty =
            DependencyProperty.Register(
            "EnabledUncheckedIcon",
            typeof(ImageSource),
            typeof(ImageToggleButton),
            new PropertyMetadata(OnEnabledUncheckedChangedCallback));

        public ImageSource EnabledUncheckedIcon
        {
            get => (ImageSource)GetValue(EnabledUncheckedIconProperty);
            set => SetValue(EnabledUncheckedIconProperty, value);
        }

        static void OnEnabledUncheckedChangedCallback(
            DependencyObject dobj,
            DependencyPropertyChangedEventArgs args)
        {
            //do something if needed
        }

        public static readonly DependencyProperty DisabledUncheckedIconProperty =
            DependencyProperty.Register(
            "DisabledUncheckedIcon",
            typeof(ImageSource),
            typeof(ImageToggleButton),
            new PropertyMetadata(OnDisabledUncheckedChangedCallback));

        public ImageSource DisabledUncheckedIcon
        {
            get => (ImageSource)GetValue(DisabledUncheckedIconProperty);
            set => SetValue(DisabledUncheckedIconProperty, value);
        }

        static void OnDisabledUncheckedChangedCallback(
            DependencyObject dobj,
            DependencyPropertyChangedEventArgs args)
        {
            //do something if needed
        }


        public static readonly DependencyProperty EnabledCheckedIconProperty =
            DependencyProperty.Register(
            "EnabledCheckedIcon",
            typeof(ImageSource),
            typeof(ImageToggleButton),
            new PropertyMetadata(OnEnabledCheckedChangedCallback));

        public ImageSource EnabledCheckedIcon
        {
            get => (ImageSource)GetValue(EnabledCheckedIconProperty);
            set => SetValue(EnabledCheckedIconProperty, value);
        }

        static void OnEnabledCheckedChangedCallback(
            DependencyObject dobj,
            DependencyPropertyChangedEventArgs args)
        {
            //EnabledCheckedChanged(dobj)
        }


        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register(
            "IsChecked",
            typeof(bool),
            typeof(ImageToggleButton),
            new PropertyMetadata(OnCheckedChangedCallback));

        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);
            set { if (value != IsChecked) SetValue(IsCheckedProperty, value); }
        }

        static void OnCheckedChangedCallback(
            DependencyObject dobj,
            DependencyPropertyChangedEventArgs args)
        {
        }

        private void ToggleButton_CheckedChanged(object sender, RoutedEventArgs e)
        {
            IsChecked = ((ToggleButton)sender).IsChecked ?? false;
            ThemeClicked?.Invoke(this, IsChecked ? "light" : "dark");

        }
    }
}
