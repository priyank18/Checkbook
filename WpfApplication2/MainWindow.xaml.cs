
using CheckBook;
using Model;
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
using System.Media;
using CheckBook;
namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var VM = new CheckBookVM();
            DataContext = VM;
            VM.Fill();
            
            // For changing the color of highest row
            
            /*var highest = amountColumn.SetCurrentValue;
            for(int row = 0; row < transactionsDataGrid.FrozenColumnCount-1; row++)
            {
                if(highest > amountColumn.GetValue)
                {
                    highest = amountColumn.SetCurrentValue;
                }
             highest.amountRow = Color.Red;
            }*/
        }
    }
}
