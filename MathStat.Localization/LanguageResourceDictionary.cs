using System.Windows;

namespace MathStat.Localization
{
    public class LanguageResourceDictionary: ResourceDictionary
    {
        public LanguageResourceDictionary()
        {
            MergedDictionaries.Add(Translation.ResourceDictionary);
        }
    }
}
