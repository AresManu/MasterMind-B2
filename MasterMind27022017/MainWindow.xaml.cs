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

namespace MasterMind27022017
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        Random rnd = new Random();
        public int GenerateRandom()
        {           
            int RndColor = rnd.Next(0, 8);
            return RndColor;           
        }
        public int Count = 0;
        public string Réponse1;
        public string Réponse2;
        public string Réponse3;
        public string Réponse4;

        public MainWindow()
        {

            InitializeComponent();

            button_validate.IsEnabled = false;

            Combo1.Items.Clear();
            Combo1.Items.Add("Rouge");
            Combo1.Items.Add("Jaune");
            Combo1.Items.Add("Vert");
            Combo1.Items.Add("Bleu");
            Combo1.Items.Add("Orange");
            Combo1.Items.Add("Blanc");
            Combo1.Items.Add("Violet");
            Combo1.Items.Add("Rose");

            Combo2.Items.Clear();
            Combo2.Items.Add("Rouge");
            Combo2.Items.Add("Jaune");
            Combo2.Items.Add("Vert");
            Combo2.Items.Add("Bleu");
            Combo2.Items.Add("Orange");
            Combo2.Items.Add("Blanc");
            Combo2.Items.Add("Violet");
            Combo2.Items.Add("Rose");

            Combo3.Items.Clear();
            Combo3.Items.Add("Rouge");
            Combo3.Items.Add("Jaune");
            Combo3.Items.Add("Vert");
            Combo3.Items.Add("Bleu");
            Combo3.Items.Add("Orange");
            Combo3.Items.Add("Blanc");
            Combo3.Items.Add("Violet");
            Combo3.Items.Add("Rose");

            Combo4.Items.Clear();
            Combo4.Items.Add("Rouge");
            Combo4.Items.Add("Jaune");
            Combo4.Items.Add("Vert");
            Combo4.Items.Add("Bleu");
            Combo4.Items.Add("Orange");
            Combo4.Items.Add("Blanc");
            Combo4.Items.Add("Violet");
            Combo4.Items.Add("Rose");

            

        }

        public void button_start_Click(object sender, RoutedEventArgs e)
        {
            Count = 0;
            label_count.Content = Count;
            textBlock_History.Text = "";
            button_validate.IsEnabled = true;
            string[] Colors = new string[] { "Rouge", "Jaune", "Vert", "Bleu", "Orange", "Blanc", "Violet", "Rose" };

            int Color1int = GenerateRandom();
            Réponse1 = Colors[Color1int];            
            

            int Color2int = GenerateRandom();
            Réponse2 = Colors[Color2int];            
            

            int Color3int = GenerateRandom();
            Réponse3 = Colors[Color3int];
            

            int Color4int = GenerateRandom();
            Réponse4 = Colors[Color4int];

            labeltest.Content = Réponse1 + Réponse2 + Réponse3 + Réponse4;


        }

        public void button_validate_Click(object sender, RoutedEventArgs e)
        {
            
            if (Count >= 10)
            {
                textBlock_History.Text = "Nombre d'essais dépassé.";
            }
            else
            {
                Count += 1;
                
                int blanc = 0;
                int rouge = 0;

                if (Combo1.Text == Réponse1) { blanc += 1; }
                    else if (Combo1.Text == Réponse2 | Combo1.Text == Réponse3 | Combo1.Text == Réponse4) { rouge += 1; }
                if (Combo2.Text == Réponse2) { blanc += 1; }
                    else if (Combo2.Text == Réponse1 | Combo2.Text == Réponse3 | Combo2.Text == Réponse4) { rouge += 1; }
                if (Combo3.Text == Réponse3) { blanc += 1; }
                    else if (Combo3.Text == Réponse1 | Combo3.Text == Réponse2 | Combo3.Text == Réponse4) { rouge += 1; }
                if (Combo4.Text == Réponse4) { blanc += 1; }
                else if (Combo4.Text == Réponse1 | Combo4.Text == Réponse2 | Combo4.Text == Réponse3) { rouge += 1; }

                textBlock_History.Text += " | " + Combo1.Text + " | " + Combo2.Text + " | " + Combo3.Text + " | " + Combo4.Text + " | " + blanc + " | " + rouge + " | " + "\n";
                label_count.Content = Count;
                if(Réponse1==Combo1.Text && Réponse2==Combo2.Text && Réponse3==Combo3.Text && Réponse4==Combo4.Text)
                {
                    textBlock_History.Text = "Victoire";
                    button_validate.IsEnabled = false;
                }
            }
            
        }
        

        
    }
}
