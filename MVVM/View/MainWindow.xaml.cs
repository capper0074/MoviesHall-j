using MoviesHalløj.MVVM.Model;
using MoviesHalløj.MVVM.ViewModel;
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

namespace MoviesHalløj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MovieViewModel mvm = new MovieViewModel();
            DataContext = mvm;
        }

      

        private void showButten_Click(object sender, RoutedEventArgs e)
        {
            MovieViewModel model = new MovieViewModel();
            listBox1.ItemsSource = model.GetAllMovies();
        }

        private void createMovie(object sender, RoutedEventArgs e)
        {
            MovieViewModel model = new MovieViewModel();
            model.CreateMovie(TB1.Text, TB2.Text);
            TB1.Text = "";
            TB2.Text = "";
        }
    }
}
