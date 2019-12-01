using _01.StringFormat.ViewModel;
using System.Windows;

namespace _01.StringFormat
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();

            this.DataContext = new MainViewModel();
        }
    }
}
