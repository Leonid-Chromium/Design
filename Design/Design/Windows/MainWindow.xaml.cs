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

namespace Design.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            actualUC = mainUC;
        }

        private void mainUC_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (mainUC.Visibility == Visibility.Visible)
                Header.Visibility = Visibility.Collapsed;
            else
                Header.Visibility = Visibility.Visible;
        }

        public static UserControl actualUC;

        public static void ChangeUC(UserControl newUC)
        {
            if (newUC == actualUC)
                newUC.Visibility = Visibility.Collapsed;
            else
            {
                actualUC.Visibility = Visibility.Collapsed;
                newUC.Visibility = Visibility.Visible;
            } 
        }
    }
}
