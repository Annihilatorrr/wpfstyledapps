using System;
using System.Windows;
using System.Windows.Media;

namespace MathStat.Styles
{
    public sealed class Theme
    {
        [ThreadStatic]
        private static ResourceDictionary _resourceDictionary;

        internal static ResourceDictionary ResourceDictionary
        {
            get
            {
                if (_resourceDictionary != null)
                {
                    return _resourceDictionary;
                }
                _resourceDictionary = new ResourceDictionary();
                LoadThemeType(ThemeType.Light);
                return _resourceDictionary;
            }
        }

        public static ThemeType ThemeType { get; set; } = ThemeType.Light;

        private static void LoadDarkTheme()
        {
            SetResource(ThemeResourceKey.WindowBorder.ToString(), new SolidColorBrush(ColorFromHex("#FFFF0000")));
            SetResource(ThemeResourceKey.WindowBorderThickness.ToString(), new System.Windows.Thickness(1));

            SetResource(ThemeResourceKey.ButtonControlDefaultBorder.ToString(),
                new SolidColorBrush(ColorFromHex("#FF007bff")));

            SetResource(ThemeResourceKey.ButtonControlFocusBorder.ToString(),
                new SolidColorBrush(ColorFromHex("#FF107bff")));
            SetResource(ThemeResourceKey.ButtonControlFocusBorderThickness.ToString(),
                new SolidColorBrush(ColorFromHex("#FF207bff")));
            SetResource(ThemeResourceKey.ButtonControlMouseOverBackground.ToString(),
                new SolidColorBrush(ColorFromHex("#FF307bff")));
            SetResource(ThemeResourceKey.ButtonControlMouseOverBorder.ToString(),
                new SolidColorBrush(ColorFromHex("#FF407bff")));
            SetResource(ThemeResourceKey.ButtonControlPressedBackground.ToString(),
                new SolidColorBrush(ColorFromHex("#FF507bff")));
            SetResource(ThemeResourceKey.ButtonControlPressedBorder.ToString(),
                new SolidColorBrush(ColorFromHex("#FF607bff")));
            SetResource(ThemeResourceKey.ButtonCornerRadius.ToString(),
                new SolidColorBrush(ColorFromHex("#FF707bff")));
        }

        private static void LoadLightTheme()
        {
            SetResource(ThemeResourceKey.WindowTitle.ToString(), "Jopa");
            SetResource(ThemeResourceKey.ControlDisabledOpacity.ToString(), 1.0d); 
            
            SetResource(ThemeResourceKey.WindowHeaderBackground.ToString(), new SolidColorBrush(ColorFromHex("#2b5329")));
            SetResource(ThemeResourceKey.WindowBorderThickness.ToString(), new Thickness(1));
            SetResource(ThemeResourceKey.WindowBorder.ToString(), new SolidColorBrush(ColorFromHex("#FF149414")));
            SetResource(ThemeResourceKey.HeaderButtonControlBorderThickness.ToString(), new Thickness(1));
            SetResource(ThemeResourceKey.HeaderButtonControlBorderColor.ToString(), new SolidColorBrush(ColorFromHex("#FFD0EAD0")));
            SetResource(ThemeResourceKey.HeaderButtonControlBackgroundColor.ToString(), new SolidColorBrush(ColorFromHex("#FF5BB45B")));
            SetResource(ThemeResourceKey.HeaderButtonControlDefaultColor.ToString(), new SolidColorBrush(ColorFromHex("#FF128512")));
            SetResource(ThemeResourceKey.HeaderButtonControlOpacity.ToString(), 1d);
            SetResource(ThemeResourceKey.WindowHeaderForeground.ToString(),
                new SolidColorBrush(ColorFromHex("#FF8ba58f")));
            SetResource(ThemeResourceKey.WindowMouseOverBackground.ToString(),
                new SolidColorBrush(ColorFromHex("#FF107b11")));
            SetResource(ThemeResourceKey.ButtonControlDefaultBorder.ToString(),
                new SolidColorBrush(ColorFromHex("#FF88ffee")));

            SetResource(ThemeResourceKey.ButtonControlFocusBorder.ToString(),
                new SolidColorBrush(ColorFromHex("#FF107b11")));
            SetResource(ThemeResourceKey.ButtonControlFocusBorderThickness.ToString(),
                new Thickness(10));

            SetResource(ThemeResourceKey.ButtonControlMouseOverBackground.ToString(),
                new SolidColorBrush(ColorFromHex("#FF307b11")));
            SetResource(ThemeResourceKey.ButtonControlMouseOverBorder.ToString(),
                new SolidColorBrush(ColorFromHex("#FF407b11")));
            SetResource(ThemeResourceKey.ButtonControlPressedBackground.ToString(),
                new SolidColorBrush(ColorFromHex("#FF507b11")));
            SetResource(ThemeResourceKey.ButtonControlPressedBorder.ToString(),
                new SolidColorBrush(ColorFromHex("#FF607b11")));
            SetResource(ThemeResourceKey.ButtonCornerRadius.ToString(),
                new CornerRadius(0));
            //SetResource(ThemeResourceKey.ContentBackground.ToString(),
            //                new SolidColorBrush(ColorFromHex("#FFFFFFFF")));

            //SetResource(ThemeResourceKey.ControlForeground.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF3F3F3F")));

            //SetResource(ThemeResourceKey.ControlFocusBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF833AB4")));

            //SetResource(ThemeResourceKey.ControlBorderThickness.ToString(),
            //    new Thickness(1));

            //SetResource(ThemeResourceKey.ControlFocusBorderThickness.ToString(),
            //    new Thickness(1));

            //SetResource(ThemeResourceKey.ControlDefaultBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FFC12B68")));
            //SetResource(ThemeResourceKey.ControlBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF8192A1")));
            //SetResource(ThemeResourceKey.ControlBackground.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FFDBE0E4")));
            //SetResource(ThemeResourceKey.ControlMouseOverBackground.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FFEDEFF2")));
            //SetResource(ThemeResourceKey.ControlMouseOverBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FFA53289")));
            //SetResource(ThemeResourceKey.ControlPressedBackground.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FFBFC2C4")));
            //SetResource(ThemeResourceKey.ControlPressedBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF3CC0FF")));

            //SetResource(ThemeResourceKey.ControlDisabledOpacity.ToString(),
            //    0.4d);

            //SetResource(ThemeResourceKey.ButtonCornerRadius.ToString(),
            //    new CornerRadius(1));

            //SetResource(ThemeResourceKey.WindowBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF616D7B")));

            //SetResource(ThemeResourceKey.WindowHeaderBackground.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF833AB4")));

            //SetResource(ThemeResourceKey.WindowHeaderForeground.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FFFFFFFF")));

            //SetResource(ThemeResourceKey.WindowActiveBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF833AB4")));

            //SetResource(ThemeResourceKey.WindowMouseOverBackground.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF000000")));

            //SetResource(ThemeResourceKey.StackPanelBackground1.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FFF6F6F6")));
            //SetResource(ThemeResourceKey.LabelBackground1.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FFF6F6F6")));
            //SetResource(ThemeResourceKey.LabelForeground1.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF000000")));
            //SetResource(ThemeResourceKey.TextBoxBackground1.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FFF6F6F6")));
            //SetResource(ThemeResourceKey.TextBoxForeground1.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF000000")));
            //SetResource(ThemeResourceKey.TextBoxBorder1.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FFdbd7d7")));

            //SetResource(ThemeResourceKey.ButtonContentBackground.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF27a2fc")));
            //SetResource(ThemeResourceKey.ButtonControlBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF27a2fc")));
            //SetResource(ThemeResourceKey.ButtonControlForeground.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FFFFFFFF")));
            //SetResource(ThemeResourceKey.ButtonControlBorderThickness.ToString(),
            //    new Thickness(1));

            //SetResource(ThemeResourceKey.ButtonControlLargeFontSize.ToString(),
            //    30d);

            //SetResource(ThemeResourceKey.ButtonControlDefaultBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF007bff")));
            //SetResource(ThemeResourceKey.ButtonControlMouseOverBackground.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF007bff")));
            //SetResource(ThemeResourceKey.ButtonControlMouseOverBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF007bff")));
            //SetResource(ThemeResourceKey.ButtonControlPressedBackground.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF0062CC")));
            //SetResource(ThemeResourceKey.ButtonControlPressedBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF0062CC")));
            //SetResource(ThemeResourceKey.ButtonControlFocusBorder.ToString(),
            //    new SolidColorBrush(ColorFromHex("#FF0062CC")));
            //SetResource(ThemeResourceKey.ButtonControlFocusBorderThickness.ToString(),
            //    new Thickness(1));
        }
        public static void LoadThemeType(ThemeType type)
        {
            ThemeType = type;
            switch (type)
            {
                case ThemeType.Light:
                {
                        LoadLightTheme();

                        break;
                    }
                case ThemeType.Dark:
                    {
                        LoadDarkTheme();
                        //SetResource(ThemeResourceKey.ContentBackground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF222529")));

                        //SetResource(ThemeResourceKey.ControlForeground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FFF4F6F9")));

                        //SetResource(ThemeResourceKey.ControlFocusBorder.ToString(),
                        //new SolidColorBrush(ColorFromHex("#FF833AB4")));

                        //SetResource(ThemeResourceKey.ControlBorderThickness.ToString(),
                        //    new Thickness(1));

                        //SetResource(ThemeResourceKey.ControlFocusBorderThickness.ToString(),
                        //    new Thickness(1));

                        //SetResource(ThemeResourceKey.ControlDefaultBorder.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FFC12B68")));
                        //SetResource(ThemeResourceKey.ControlBorder.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF616D7B")));
                        //SetResource(ThemeResourceKey.ControlBackground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF2D3136")));
                        //SetResource(ThemeResourceKey.ControlMouseOverBackground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF4C525E")));
                        //SetResource(ThemeResourceKey.ControlMouseOverBorder.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FFA53289")));
                        //SetResource(ThemeResourceKey.ControlPressedBackground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF222529")));
                        //SetResource(ThemeResourceKey.ControlPressedBorder.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF00ACE0")));

                        //SetResource(ThemeResourceKey.ControlDisabledOpacity.ToString(),
                        //    0.4d);

                        //SetResource(ThemeResourceKey.ButtonCornerRadius.ToString(),
                        //    new CornerRadius(1));

                        //SetResource(ThemeResourceKey.WindowBorder.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF616D7B")));

                        //SetResource(ThemeResourceKey.WindowHeaderBackground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF833AB4")));

                        //SetResource(ThemeResourceKey.WindowHeaderForeground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FFFFFFFF")));

                        //SetResource(ThemeResourceKey.WindowActiveBorder.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF833AB4")));

                        //SetResource(ThemeResourceKey.WindowMouseOverBackground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF000000")));

                        //SetResource(ThemeResourceKey.StackPanelBackground1.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FFF6F6F6"))); 
                        //SetResource(ThemeResourceKey.LabelBackground1.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF2D3136")));
                        //SetResource(ThemeResourceKey.LabelForeground1.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FFF6F6F6")));
                        //SetResource(ThemeResourceKey.TextBoxBackground1.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF2D3136")));
                        //SetResource(ThemeResourceKey.TextBoxForeground1.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FFF6F6F6")));
                        //SetResource(ThemeResourceKey.TextBoxBorder1.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FFFFFFFF")));

                        //SetResource(ThemeResourceKey.ButtonContentBackground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF3C4055")));
                        //SetResource(ThemeResourceKey.ButtonControlBorder.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF3C4055")));
                        //SetResource(ThemeResourceKey.ButtonControlForeground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FFFFFFFF")));
                        //SetResource(ThemeResourceKey.ButtonControlBorderThickness.ToString(),
                        //    new Thickness(1));

                        //SetResource(ThemeResourceKey.ButtonControlLargeFontSize.ToString(),
                        //    30d);

                        //SetResource(ThemeResourceKey.ButtonControlDefaultBorder.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF343A40")));
                        //SetResource(ThemeResourceKey.ButtonControlMouseOverBackground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF343A40")));
                        //SetResource(ThemeResourceKey.ButtonControlMouseOverBorder.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF343A40")));
                        //SetResource(ThemeResourceKey.ButtonControlPressedBackground.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF343A40")));
                        //SetResource(ThemeResourceKey.ButtonControlPressedBorder.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF343A40")));
                        //SetResource(ThemeResourceKey.ButtonControlFocusBorder.ToString(),
                        //    new SolidColorBrush(ColorFromHex("#FF6C757D")));
                        //SetResource(ThemeResourceKey.ButtonControlFocusBorderThickness.ToString(),
                        //    new Thickness(1));
                        break;
                    }
            }
        }

        public static object GetResource(ThemeResourceKey resourceKey)
        {
            return ResourceDictionary.Contains(resourceKey.ToString())
                ? ResourceDictionary[resourceKey.ToString()]
                : null;
        }

        internal static void SetResource(object key, object resource)
        {
            ResourceDictionary[key] = resource;
        }

        internal static System.Windows.Media.Color ColorFromHex(string hex)
        {
            //remove the # at the front
            hex = hex.Replace("#", "");

            byte a = 255;
            byte r = 255;
            byte g = 255;
            byte b = 255;

            int start = 0;

            //handle ARGB strings (8 characters long)
            if (hex.Length == 8)
            {
                a = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                start = 2;
            }

            //convert RGB characters to bytes
            r = byte.Parse(hex.Substring(start, 2), System.Globalization.NumberStyles.HexNumber);
            g = byte.Parse(hex.Substring(start + 2, 2), System.Globalization.NumberStyles.HexNumber);
            b = byte.Parse(hex.Substring(start + 4, 2), System.Globalization.NumberStyles.HexNumber);

            return System.Windows.Media.Color.FromArgb(a, r, g, b);
        }
    }
}
