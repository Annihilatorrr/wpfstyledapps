using System.Windows;

namespace MathStat.Styles
{
    public class ThemeResourceDictionary: ResourceDictionary
    {
        public ThemeResourceDictionary()
        {
            MergedDictionaries.Add(Theme.ResourceDictionary);
        }
    }
}
