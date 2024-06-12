using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace pr10
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private static string theme;
        public static string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                var dict = new ResourceDictionary { Source = new Uri($"pack://application:,,,/ThemeLib;component/Themes/{value}.xaml") };

                Current.Resources.MergedDictionaries.RemoveAt(0);
                Current.Resources.MergedDictionaries.Insert(0, dict);

                File.WriteAllText($"theme.txt", value);
            }
        }

        public App()
        {
            InitializeComponent();
            if (File.Exists($"theme.txt"))
            {
                Theme = File.ReadAllText($"theme.txt");
            }
        }
    }

}
