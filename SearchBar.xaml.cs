using System;
using System.Collections.Generic;
using System.IO;
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

namespace EVTracker
{
    /// <summary>
    /// Interaction logic for SearchBar.xaml
    /// </summary>
    public partial class SearchBar : Window
    {
        public MainWindow calledFrom;
        public SearchBar()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, RoutedEventArgs e)
        {
            if(search.Text != "") {
                string temp = search.Text;
                foreach (var item in Directory.EnumerateFiles(Directory.GetCurrentDirectory()))
                {
                    if(item.Contains(temp))
                    {
                        temp = item;
                        break;
                    }
                }
                StreamReader sr = new StreamReader(temp);
                temp = sr.ReadLine();
                var arry = temp.Split(':');
                calledFrom.LoadTextBoxes(arry);
                Close();
            }

        }
    }
}
