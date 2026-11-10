using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Filmek
{
    
    public partial class MainWindow : Window
    {

        public class Film

        {
            public string Cim { get; set; }
            public string Mufaj { get; set; }
            public int Hossz { get; set; }
            public double Ertekeles { get; set; }

            public Film(string cim, string mufaj, int hossz, double ertekeles)
            {
                this.Cim = cim;
                this.Mufaj = mufaj;
                this.Hossz = hossz;
                this.Ertekeles = ertekeles;
            }
        }
        public List<Film> filmek = new List<Film>()
     {
         new Film("Csillagok háborúja", "sci-fi", 121, 8.6),
         new Film("Titanic", "dráma", 195, 7.8),
         new Film("A Gyűrűk Ura", "fantasy", 201, 8.8),
         new Film("Mátrix", "sci-fi", 136, 8.7),
         new Film("Shrek", "animáció", 90, 7.9)
     };
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void Betolt(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = filmek;
            datagrid.Items.Refresh();
        }

        private void osszfilm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Összesen {filmek.Count()}film van");
        }

        private void Leghosszabb(object sender, RoutedEventArgs e)
        {
            var leghoszabb = filmek.OrderByDescending(f => f.Hossz).Take(1);
            datagrid.ItemsSource = leghoszabb;

        }




    }
}