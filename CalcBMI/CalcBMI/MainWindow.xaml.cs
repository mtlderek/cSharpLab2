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

namespace CalcBMI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            metButton.IsChecked = true;
            FRENCH.Click += new RoutedEventHandler(frClick);
            English.Click += new RoutedEventHandler(enClick);
            impButton.Checked += new RoutedEventHandler(impButton_Checked);
            metButton.Checked += new RoutedEventHandler(metButton_Checked);
            calcButton.Click += new RoutedEventHandler(calcButton_Click);


        }
        
        private void impButton_Checked(object sender, RoutedEventArgs e)
        {
            if((String)wLabel.Content == "Poids")
            {
                wTextBox.Text = "Composer votre poids (lb)";
                hTextBox.Text = "Composer votre taille (po)";
            } else
            {
                wTextBox.Text = "Enter Weight (lbs)";
                hTextBox.Text = "Enter Height (in)";
            }
        }

        private void metButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((String)wLabel.Content == "Poids")
            {
                wTextBox.Text = "Composer votre poids (kg)";
                hTextBox.Text = "Composer votre taille (m)";
            }
            else
            {
                wTextBox.Text = "Enter Weight (kg)";
                hTextBox.Text = "Enter Height (m)";
            }
        }

        private void frClick(object sender, RoutedEventArgs e)
        {
                 
            wLabel.Content = "Poids";
            hLabel.Content = "Taille";
            impButton.Content = "Impérial";
            metButton.Content = "Métrique";
            calcButton.Content = "Calculer";
            resetButton.Content = "Réinitialiser";
            if(impButton.IsChecked == true)
            {
                wTextBox.Text = "Composer votre poids (lb)";
                hTextBox.Text = "Composer votre taille (po)";
            } else
            {
                wTextBox.Text = "Composer votre poids (kg)";
                hTextBox.Text = "Composer votre taille (m)";
            }
                        
        }
        private void enClick(object sender, RoutedEventArgs e)
        {

            wLabel.Content = "Weight";
            hLabel.Content = "Height";
            impButton.Content = "Imperial";
            metButton.Content = "Metric";
            calcButton.Content = "Calculate";
            resetButton.Content = "Reset";

            if (impButton.IsChecked == true)
            {
                wTextBox.Text = "Enter Weight (lbs)";
                hTextBox.Text = "Enter Height (in)";
            }
            else
            {
                wTextBox.Text = "Enter Weight (kg)";
                hTextBox.Text = "Enter Height (m)";
            }

        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            double metWeight = (double)Convert.ToDouble(wTextBox.Text);
            double metHeight = (double)Convert.ToDouble(hTextBox.Text);

            if (impButton.IsChecked == true)
            {
                metHeight = metHeight / 0.0254;
                metWeight = metWeight / 2.20462;
            }

            bool valid = validation(metHeight, metWeight);
            if (valid == false)
            {
            	MessageBox.Show("The Entered height must be between 0.2 and 2.2. The weight must be between 10 and 300. Please Try Again!");
                //MessageBox.Show("your bmi is WRONG , your height is " + metHeight + " your weight " + metWeight
                //  + "bmi =" + (metWeight / (metHeight * metHeight)));

                Window bmiWindow = new Window();

                Window1.Show();

            } else
            {
                double bmi = metWeight / (metHeight * metHeight);
                MessageBox.Show("your bmi is " + bmi);



            }
            


            //NIC MAZZONE - display phrase indication bmi healthiness in new window
            //NIC MAZZONE - display pic



        }

        public bool validation(double height, double weight)
        {
            
            if ((height < 0.2 || height > 2.2) || (weight < 10 || weight > 300))
            {
                return false;
            }
            return true;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FRENCH_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
