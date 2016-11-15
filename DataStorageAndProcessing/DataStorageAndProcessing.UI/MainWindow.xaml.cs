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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataStorageAndProcessing.Data;

namespace DataStorageAndProcessing.UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<University> Raiting2012 = SiteParser.GetJobLinks("http://cwur.org/2012.php");
            List<University> Raiting2013 = SiteParser.GetJobLinks("http://cwur.org/2013.php");
            List<University> Raiting2014 = SiteParser.GetJobLinks("http://cwur.org/2014.php");
            List<University> Raiting2015 = SiteParser.GetJobLinks("http://cwur.org/2015.php");
            List<University> Raiting2016 = SiteParser.GetJobLinks("http://cwur.org/2016.php");
        }
    }
}
