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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EVTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] array;
        public MainWindow()
        {
            InitializeComponent();
            InitializeTextBoxes();
            MakeDir();
        }

        private void hp_Click(object sender, RoutedEventArgs e)
        {
            int HPval = Convert.ToInt32(HP.Text);
            int totVal = Convert.ToInt32(Total.Text);
            if(e.Source == hp1 && HPval <= 251 && totVal <= 509) {
                HPval += 1;
                totVal += 1;
            } else if(e.Source == HP4 && HPval <= 248 && totVal <= 506) {
                HPval += 4;
                totVal += 4;
            } else if(e.Source == HP8 && HPval <= 244 && totVal <= 502) {
                HPval += 8;
                totVal += 8;
            } else if(e.Source == HP12 && HPval <= 240 && totVal <= 498) {
                HPval += 12;
                totVal += 12;
            }
            HP.Text = Convert.ToString(HPval);
            Total.Text = Convert.ToString(totVal);
        }

        private void atk_Click(object sender, RoutedEventArgs e)
        {
            int Atkval = Convert.ToInt32(Atk.Text);
            int totVal = Convert.ToInt32(Total.Text);
            if (e.Source == Atk1 && Atkval <= 251 && totVal <= 509) {
                Atkval += 1;
                totVal += 1;
            } else if (e.Source == Atk4 && Atkval <= 248 && totVal <= 506) {
                Atkval += 4;
                totVal += 4;
            } else if (e.Source == Atk8 && Atkval <= 244 && totVal <= 502) {
                Atkval += 8;
                totVal += 8;
            } else if (e.Source == Atk12 && Atkval <= 240 && totVal <= 498) {
                Atkval += 12;
                totVal += 12;
            }
            Atk.Text = Convert.ToString(Atkval);
            Total.Text = Convert.ToString(totVal);
        }

        private void def_Click(object sender, RoutedEventArgs e)
        {
            int Defval = Convert.ToInt32(Def.Text);
            int totVal = Convert.ToInt32(Total.Text);
            if (e.Source == Def1 && Defval <= 251 && totVal <= 509) {
                Defval += 1;
                totVal += 1;
            } else if (e.Source == Def4 && Defval <= 248 && totVal <= 506) {
                Defval += 4;
                totVal += 4;
            } else if (e.Source == Def8 && Defval <= 244 && totVal <= 502) {
                Defval += 8;
                totVal += 8;
            } else if (e.Source == Def12 && Defval <= 240 && totVal <= 498) {
                Defval += 12;
                totVal += 12;
            }
            Def.Text = Convert.ToString(Defval);
            Total.Text = Convert.ToString(totVal);
        }

        private void spatk_Click(object sender, RoutedEventArgs e)
        {
            int Spatkval = Convert.ToInt32(SpAtk.Text);
            int totVal = Convert.ToInt32(Total.Text);
            if (e.Source == Spatk1 && Spatkval <= 251 && totVal <= 509) {
                Spatkval += 1;
                totVal += 1;
            } else if (e.Source == Spatk4 && Spatkval <= 248 && totVal <= 506) {
                Spatkval += 4;
                totVal += 4;
            } else if (e.Source == Spatk8 && Spatkval <= 244 && totVal <= 502) {
                Spatkval += 8;
                totVal += 8;
            } else if (e.Source == Spatk12 && Spatkval <= 240 && totVal <= 498) {
                Spatkval += 12;
                totVal += 12;
            }
            SpAtk.Text = Convert.ToString(Spatkval);
            Total.Text = Convert.ToString(totVal);
        }

        private void spdef_Click(object sender, RoutedEventArgs e)
        {
            int Spdefval = Convert.ToInt32(SpDef.Text);
            int totVal = Convert.ToInt32(Total.Text);
            if (e.Source == SpDef1 && Spdefval <= 251 && totVal <= 509) {
                Spdefval += 1;
                totVal += 1;
            } else if (e.Source == SpDef4 && Spdefval <= 248 && totVal <= 506) {
                Spdefval += 4;
                totVal += 4;
            } else if (e.Source == SpDef8 && Spdefval <= 244 && totVal <= 502) {
                Spdefval += 8;
                totVal += 8;
            } else if (e.Source == SpDef12 && Spdefval <= 240 && totVal <= 498) {
                Spdefval += 12;
                totVal += 12;
            }
            SpDef.Text = Convert.ToString(Spdefval);
            Total.Text = Convert.ToString(totVal);
        }

        private void speed_Click(object sender, RoutedEventArgs e)
        {
            int Speedval = Convert.ToInt32(Speed.Text);
            int totVal = Convert.ToInt32(Total.Text);
            if (e.Source == Speed1 && Speedval <= 251 && totVal <= 509) {
                Speedval += 1;
                totVal += 1;
            } else if (e.Source == Speed4 && Speedval <= 248 && totVal <= 506) {
                Speedval += 4;
                totVal += 4;
            } else if (e.Source == Speed8 && Speedval <= 244 && totVal <= 502) {
                Speedval += 8;
                totVal += 8;
            } else if (e.Source == Speed12 && Speedval <= 240 && totVal <= 498) {
                Speedval += 12;
                totVal += 12;
            }
            Speed.Text = Convert.ToString(Speedval);
            Total.Text = Convert.ToString(totVal);
        }

        private void InitializeTextBoxes()
        {
            HP.Text = "0";
            Atk.Text = "0";
            Def.Text = "0";
            SpAtk.Text = "0";
            SpDef.Text = "0";
            Speed.Text = "0";
            Total.Text = "0";
        }

        private void MakeDir()
        {
            if(!Directory.Exists("PokemonData")) {
                Directory.CreateDirectory("PokemonData");
            }
            Directory.SetCurrentDirectory("PokemonData");
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string fileName = Name.Text + Total.Text + DateTime.Today.Month + DateTime.Today.Day + DateTime.Today.Year + ".txt";
            string str = HP.Text + ":" + Atk.Text + ":" + Def.Text + ":" +
                SpAtk.Text + ":" + SpDef.Text + ":" + Speed.Text + ":" + Total.Text+ ":" + Name.Text;
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + fileName, str);
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            SearchBar bar = new SearchBar();
            bar.calledFrom = this;
            bar.Visibility = Visibility.Visible;
        }

        public void LoadTextBoxes(string[] stats)
        {
            HP.Text = stats[0];
            Atk.Text = stats[1];
            Def.Text = stats[2];
            SpAtk.Text = stats[3];
            SpDef.Text = stats[4];
            Speed.Text = stats[5];
            Total.Text = stats[6];
            Name.Text = stats[7];
        }
    }
}
