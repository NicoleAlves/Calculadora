using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private Calculador Calc;
        private string ope = "";
        private int uses;
        private double a ;
        private double b ;
        private double r ;
        public Form1()
        {
            InitializeComponent();
            Calc = new Calculador();
        }

        private void Digitou(object sender, EventArgs e)
        {
            
            txtResultado.Text += (sender as Button).Text;
            txtConta.Text += (sender as Button).Text;
           
        }

        public void Clean()
        {
            txtResultado.Text = "";
        }

        private void Cleaned(object sender, EventArgs e)
        {
            Clean();
            uses = 0;
            r = 0;
            a = 0;
            b = 0;
            txtConta.Text = "";
        }

        private void Result(object sender, EventArgs e)
        {
            b = double.Parse(txtResultado.Text);
            switch (ope)
            {
                case "SOMA":
                    //Button btn = (Button)sender;
                    r = (Calc.Soma(r, b));
                    txtResultado.Text =  r.ToString();
                    
                break;
                case "SUBTRACAO":
                r = (Calc.Subtracao(r, b));
                txtResultado.Text =  r.ToString();
                break;
                case "MULTIPLICACAO":
                r = (Calc.Multiplicacao(r, b));
                txtResultado.Text =  r.ToString();
                break;
                case "DIVISAO":
                if (b == 0)
                {
                    txtResultado.Text = "Inexistente";
                }else
                    txtResultado.Text = (Calc.Divisao(a, b)).ToString();

                break;
                case "POTENCIA":
                txtResultado.Text =  (Calc.Potencia(a, b)).ToString();
                break;
                case "RAIZ":
                
                if (b < 0 && a % 2 == 0)
                {
                    txtResultado.Text = "Inexistente";
                }else
                    txtResultado.Text =  (Calc.Raiz(b, a)).ToString();
                
                break;
                case "PORCENTAGEM":
                txtResultado.Text =(Calc.Porcentagem(a, b)).ToString();
                break;
                case "RESTO":
                if (b == 0)
                {
                    txtResultado.Text = "Inexistente";
                }else
                txtResultado.Text = (Calc.Resto(a, b)).ToString();
                break;
                case "SEN":
                txtResultado.Text = (Calc.Sen(b * (Math.PI / 180))).ToString();
                break;
                case "COS":
                txtResultado.Text = (Calc.Cos(b * (Math.PI / 180))).ToString();
                break;
                case "TG":
                txtResultado.Text =  (Calc.Tg(b * (Math.PI / 180))).ToString();
                break;
                default: txtResultado.Text = ope; break;
            }
            a = 0;
            b = 0;
            r = 0;
        }

        private void Operacao(object sender, EventArgs e)
        {
            
           //Adiciona a operação do butão apertado
            if (ope != (sender as Button).Name)
            {
                
                ope = (sender as Button).Name;
            }
            if (txtResultado.Text.Length != 0)
            {
                a = double.Parse(txtResultado.Text);
                txtResultado.Text = "";
            }
            //Mexe na segunda caixa de texto
            switch (ope)
            {
                case "SOMA":
                    txtConta.Text += "+";
                        r = (Calc.Soma(r, a));
                    break;
                case "SUBTRACAO":
                    txtConta.Text += "-";
                     if(uses.Equals(0)) r = a;
                     else r = Calc.Subtracao(r,a);
                    break;
                case "MULTIPLICACAO":
                    txtConta.Text += "*";
                    if (uses.Equals(0)) r = a;
                    else r = Calc.Multiplicacao(r, a);
                    break;
                case "DIVISAO":
                    txtConta.Text += "/";
                    break;
                case "POTENCIA":
                    txtConta.Text += "x²";
                    break;
                case "RAIZ":
                    txtConta.Text += "√";
                    break;
                case "PORCENTAGEM":
                    txtConta.Text += "%";
                    break;
                case "RESTO":
                    txtConta.Text += "$";
                    break;
                case "SEN":
                    txtConta.Text += "sen";
                    break;
                case "COS":
                    txtConta.Text += "cos";
                    break;
                case "TG":
                    txtConta.Text += "tg";
                    break;
                default: txtResultado.Text = ope; break;
            }
            uses++;
        //-----------------------------
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
