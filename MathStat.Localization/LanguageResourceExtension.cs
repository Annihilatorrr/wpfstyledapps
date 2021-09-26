using System;
using System.Windows;

namespace MathStat.Localization
{
    public class LanguageResourceExtension : DynamicResourceExtension
    {
        public new LanguageResourceKey ResourceKey
        {
            get
            {
                Enum.TryParse(base.ResourceKey.ToString(), out LanguageResourceKey resourceKey);
                return resourceKey;
            }
            set => base.ResourceKey = value.ToString();
        }
    }
}
