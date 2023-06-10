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

namespace TRPO_Project_Azimuth_.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Azimuth> listAzimths = new List<Azimuth>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton1_Click(object sender, RoutedEventArgs e)
        {
            string ugol = DirectionalAngleTextBox.Text;
            string pn = DirectionCorrectionTextBox.Text;
            listAzimths.Add(new(double.Parse(ugol), double.Parse(pn)));
            SampleDataGrid.ItemsSource = listAzimths;


        }

        private void ApplyButton2_Click(object sender, RoutedEventArgs e)
        {
            string ugol = DirectionalAngleTextBox2.Text;
            string pn = MagneticDeclinationTextBox.Text;
            string pn1 = AverageMeridianConvergenceTextBox.Text;

            listAzimths.Add(new(double.Parse(ugol), double.Parse(pn), double.Parse(pn1)));
            SampleDataGrid.ItemsSource = listAzimths;
        }

        private void ApplyButton3_Click(object sender, RoutedEventArgs e)
        {
            string x = XCoordinateTextBox.Text;
            string y = YCoordinateTextBox.Text;
            string dist = DistanceTextBox.Text;
            

            Azimuth azimuth = (Azimuth)SampleDataGrid.SelectedItem;
            var p =  azimuth.PGZ(new Point(int.Parse(x), int.Parse(y)), double.Parse(dist) );
            MessageBox.Show($"X = {p.X} Y = {p.Y}") ;
        }
    }
}
