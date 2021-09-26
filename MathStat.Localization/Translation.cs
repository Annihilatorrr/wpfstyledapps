using System;
using System.Windows;

namespace MathStat.Localization
{
    public sealed class Translation
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
                Load(LanguageId.En);
                return _resourceDictionary;
            }
        }

        public static LanguageId Id { get; set; } = LanguageId.En;

        private static void LoadRuTranslations()
        {
            SetResource(LanguageResourceKey.WindowTitle.ToString(), "Привет, мир");
            SetResource(LanguageResourceKey.ProductsShipped.ToString(), "Поставка");
        }

        private static void LoadEnTranslations()
        {
            SetResource(LanguageResourceKey.WindowTitle.ToString(), "Hello world");
            SetResource(LanguageResourceKey.ProductsShipped.ToString(), "Products have been shipped");
        }
        public static void Load(LanguageId language)
        {
            switch (language)
            {
                case LanguageId.En:
                    {
                        LoadEnTranslations();
                        break;
                    }
                case LanguageId.Ru:
                    {
                        LoadRuTranslations();
                        break;
                    }
            }
        }

        public static object GetResource(LanguageResourceKey resourceKey)
        {
            return ResourceDictionary.Contains(resourceKey.ToString())
                ? ResourceDictionary[resourceKey.ToString()]
                : null;
        }

        internal static void SetResource(object key, object resource)
        {
            ResourceDictionary[key] = resource;
        }

    }
}
