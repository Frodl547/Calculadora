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

namespace calculadora
{
    public partial class MainWindow : Window
    {
        double resultado_da_conta = 0;
        double conversão = Math.PI / 180;
        bool controle = false;

        public MainWindow()
        {
            InitializeComponent();
        }


        /* implementação de teclas do teclado, para que
         * seja possivel pressionar os numeros do numpad
         * e os normais assim como a virgula */

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                if (resultado.Text == "0" || controle == true)
                {
                    resultado.Clear();
                }
                    controle = false;
                    resultado.Text = resultado.Text + "0";              
            }
            if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                if (resultado.Text == "0" || controle == true)
                {
                    resultado.Clear();
                }
                    controle = false;
                    resultado.Text = resultado.Text + "1";              
            }
            if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                if (resultado.Text == "0" || controle == true)
                {
                    resultado.Clear();
                }
                    controle = false;
                    resultado.Text = resultado.Text + "2";
            }
            if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                if (resultado.Text == "0" || controle == true)
                {
                    resultado.Clear();
                }
                    controle = false;
                    resultado.Text = resultado.Text + "3";               
            }
            if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                if (resultado.Text == "0" || controle == true)
                {
                    resultado.Clear();
                }
                    controle = false;
                    resultado.Text = resultado.Text + "4";
            }
            if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                if (resultado.Text == "0" || controle == true)
                {
                    resultado.Clear();
                }
                    controle = false;
                    resultado.Text = resultado.Text + "5";
            }
            if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                if (resultado.Text == "0" || controle == true)
                {
                    resultado.Clear();
                }
                    controle = false;
                    resultado.Text = resultado.Text + "6";
            }
            if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                if (resultado.Text == "0" || controle == true)
                {
                    resultado.Clear();
                }
                    controle = false;
                    resultado.Text = resultado.Text + "7";
            }
            if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                if (resultado.Text == "0" || controle == true)
                {
                    resultado.Clear();
                }
                    controle = false;
                    resultado.Text = resultado.Text + "8";
            }
            if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                if (resultado.Text == "0" || controle == true)
                {
                    resultado.Clear();
                }
                    controle = false;
                    resultado.Text = resultado.Text + "9";
            }
            if (e.Key == Key.OemComma)
            {
                if (controle == true)
                {
                    resultado.Text = "0,";
                    controle = false;
                }
                else
                {
                    int i = resultado.Text.IndexOf(',');
                    if (i < 0) resultado.Text = resultado.Text + ",";
                }
            }    
        }

        /* implementação dos botões virtuais */

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (resultado.Text == "0" || controle == true)resultado.Clear();
            controle = false;
            resultado.Text = resultado.Text + "0";
        }

        private void virgula_Click(object sender, RoutedEventArgs e)
        {
            if (controle == true) 
            {  
                resultado.Text = "0,";
                controle = false;
            }
            else
            {   
                int i = resultado.Text.IndexOf(',');
                if (i < 0) resultado.Text = resultado.Text + ",";
            }
        }

        private void um_Click(object sender, RoutedEventArgs e)
        {
            if (resultado.Text == "0" || controle == true) resultado.Clear();
            controle = false;
            resultado.Text = resultado.Text + "1";
        }

        private void dois_Click(object sender, RoutedEventArgs e)
        {
            if (resultado.Text == "0" || controle == true) resultado.Clear();
            controle = false;
            resultado.Text = resultado.Text + "2";
        }

        private void três_Click(object sender, RoutedEventArgs e)
        {
            if (resultado.Text == "0" || controle == true) resultado.Clear();
            controle = false;
            resultado.Text = resultado.Text + "3";
        }

        private void quatro_Click(object sender, RoutedEventArgs e)
        {
            if (resultado.Text == "0" || controle == true) resultado.Clear();
            controle = false;
            resultado.Text = resultado.Text + "4";
        }

        private void cinco_Click(object sender, RoutedEventArgs e)
        {
            if (resultado.Text == "0" || controle == true) resultado.Clear();
            controle = false;
            resultado.Text = resultado.Text + "5";
        }

        private void seis_Click(object sender, RoutedEventArgs e)
        {
            if (resultado.Text == "0" || controle == true) resultado.Clear();
            controle = false;
            resultado.Text = resultado.Text + "6";
        }

        private void sete_Click(object sender, RoutedEventArgs e)
        {
            if (resultado.Text == "0" || controle == true) resultado.Clear();
            controle = false;
            resultado.Text = resultado.Text + "7";
        }

        private void oito_Click(object sender, RoutedEventArgs e)
        {
            if (resultado.Text == "0" || controle == true) resultado.Clear();
            controle = false;
            resultado.Text = resultado.Text + "8";
        }

        private void nove_Click(object sender, RoutedEventArgs e)
        {
            if (resultado.Text == "0" || controle == true) resultado.Clear();
            controle = false;
            resultado.Text = resultado.Text + "9";

        }

        private void seno_Click(object sender, RoutedEventArgs e)
        {
            resultado_da_conta = conversão * double.Parse(resultado.Text);
            resultado.Text = (Math.Sin(resultado_da_conta)).ToString();
            controle = true;
        }

        private void cosseno_Click(object sender, RoutedEventArgs e)
        {
            resultado_da_conta = conversão * double.Parse(resultado.Text);
            resultado.Text = (Math.Cos(resultado_da_conta)).ToString();
            controle = true;
        }

        private void tangente_Click(object sender, RoutedEventArgs e)
        {
            resultado_da_conta = conversão * double.Parse(resultado.Text);
            resultado.Text = (Math.Tan(resultado_da_conta)).ToString();
            controle = true;
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = "0";
            controle = false;
        }
        
    }
}
