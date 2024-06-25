using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pr10.View
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
            PageFrame.Content = new UserProfile();
            pageName.Text = "Профиль";
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Reception();
            pageName.Text = "Приёмы";
        }

        private void TreeViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Analysis();
            pageName.Text = "Анализы";
        }

        private void TreeViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Research();
            pageName.Text = "Исследования";
        }


        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            PageFrame.Content = new UserProfile();
            pageName.Text = "Профиль";
        }
    }
}
