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
        private double result;
        private double b = Double.NaN;
        private double a = Double.NaN;
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

        private void Cleaned(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtConta.Text ="";
            a = Double.NaN;
            b = Double.NaN;
            result = Double.NaN;
        }

        private void Result(object sender, EventArgs e)
        {
            switch(ope)
            {
                 case"SOMA":
                    if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                         {
                             b = Double.Parse(txtResultado.Text);
                             a = Calc.Soma(a, b);
                             b = Double.NaN;
                             txtConta.Text = a.ToString() ;
                             txtResultado.Text = a.ToString();
                             a = Double.NaN;
                         }
                 break;
                case "SUBTRACAO":
                 if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                         {
                             b = Double.Parse(txtResultado.Text);
                             a = Calc.Subtracao(a, b);
                             b = Double.NaN;
                             txtConta.Text = a.ToString() ;
                             txtResultado.Text = a.ToString();
                             a = Double.NaN;
                         }
                break;
                case "RESTO":
                if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                {
                    b = Double.Parse(txtResultado.Text);
                    a = Calc.Resto(a, b);
                    b = Double.NaN;
                    txtConta.Text = a.ToString();
                    txtResultado.Text = a.ToString();
                    a = Double.NaN;
                }
                break;
                case "MULTIPLICACAO":
                if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                {
                    b = Double.Parse(txtResultado.Text);
                    a = Calc.Multiplicacao(a, b);
                    b = Double.NaN;
                    txtConta.Text = a.ToString();
                    txtResultado.Text = a.ToString();
                    a = Double.NaN;
                }
                break;
                case "DIVISAO":
                if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                {
                    b = Double.Parse(txtResultado.Text);
                    a = Calc.Divisao(a, b);
                    b = Double.NaN;
                    txtConta.Text = a.ToString();
                    txtResultado.Text = a.ToString();
                    a = Double.NaN;
                }
                break;
                case "PORCENTAGEM":
                if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                {
                    b = Double.Parse(txtResultado.Text);
                    a = Calc.Porcentagem(a, b);
                    b = Double.NaN;
                    txtConta.Text = a.ToString();
                    txtResultado.Text = a.ToString();
                    a = Double.NaN;
                }
                break;
                case "RAIZ":
                if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                {
                    b = Double.Parse(txtResultado.Text);
                    a = Calc.Raiz(b, a);
                    b = Double.NaN;
                    txtConta.Text = a.ToString();
                    txtResultado.Text = a.ToString();
                    a = Double.NaN;
                }
                break;
                case "POTENCIA":
                if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                {
                    b = Double.Parse(txtResultado.Text);
                    a = Calc.Potencia(b, a);
                    b = Double.NaN;
                    txtConta.Text = a.ToString();
                    txtResultado.Text = a.ToString();
                    a = Double.NaN;
                }
                break;
                case "SEN":
                a = Double.Parse(txtResultado.Text);
                a = Calc.Sen(a);
                txtConta.Text = a.ToString();
                txtResultado.Text = a.ToString();
                a = Double.NaN;
                break;
                case "COS":
                a = Double.Parse(txtResultado.Text);
                a = Calc.Cos(a);
                txtConta.Text = a.ToString();
                txtResultado.Text = a.ToString();
                a = Double.NaN;
                break;
                case "TG":
                a = Double.Parse(txtResultado.Text);
                a = Calc.Tg(a);
                txtConta.Text = a.ToString();
                txtResultado.Text = a.ToString();
                a = Double.NaN;
                break;
                case "FIBREC":
                a = Double.Parse(txtResultado.Text);
                a = Calc.FibonacciRecursiva(a);
                txtConta.Text = a.ToString();
                txtResultado.Text = a.ToString();
                a = Double.NaN;
                break;
                case "FIBITE":
                a = Double.Parse(txtResultado.Text);
                a = Calc.FibonacciIterativa(a);
                txtConta.Text = a.ToString();
                txtResultado.Text = a.ToString();
                a = Double.NaN;
                break;
                case "FATITE":
                a = Double.Parse(txtResultado.Text);
                a = Calc.FatorialIterativa(a);
                txtConta.Text = a.ToString();
                txtResultado.Text = a.ToString();
                a = Double.NaN;
                break;
                case "FATREC":
                a = Double.Parse(txtResultado.Text);
                a = Calc.FatorialRecursiva(a);
                txtConta.Text = a.ToString();
                txtResultado.Text = a.ToString();
                a = Double.NaN;
                break;
             }
        }

        private void Operacao(object sender, EventArgs e)
        {
            ope = (sender as Button).Name;
            if (!(string.IsNullOrEmpty(txtResultado.Text)) || ope.Equals("COS") || ope.Equals("SEN") || ope.Equals("TG") ||
                ope.Equals("FIBITE") || ope.Equals("FIBREC") || ope.Equals("FATITE") || ope.Equals("FATREC"))
            {
                switch (ope)
                {
                    case "SOMA":
                        if (a.Equals(Double.NaN))
                        {
                            a = Double.Parse(txtResultado.Text);
                            txtConta.Text += "+";
                            MessageBox.Show("case1");
                        }
                        else if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                        {
                            b = Double.Parse(txtResultado.Text);
                            a = Calc.Soma(a, b);
                            b = Double.NaN;
                            txtConta.Text = a.ToString() + "+";
                            txtResultado.Text = a.ToString();
                        }
                        break;
                    case "SUBTRACAO":
                        if (a.Equals(Double.NaN))
                        {
                            a = Double.Parse(txtResultado.Text);
                            txtConta.Text += "-";
                            MessageBox.Show("case1");
                        }
                        else if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                        {
                            b = Double.Parse(txtResultado.Text);
                            a = Calc.Subtracao(a, b);
                            b = Double.NaN;
                            txtConta.Text = a.ToString() + "-";
                        }
                        break;
                    case "RESTO":
                        if (a.Equals(Double.NaN))
                        {
                            a = Double.Parse(txtResultado.Text);
                            txtConta.Text += " restoDe ";
                        }
                        else if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                        {
                            b = Double.Parse(txtResultado.Text);
                            a = Calc.Resto(a, b);
                            b = Double.NaN;
                            txtConta.Text = a.ToString() + " restoDe ";
                            txtResultado.Text = a.ToString();
                        }
                        break;
                    case "MULTIPLICACAO":
                        if (a.Equals(Double.NaN))
                        {
                            a = Double.Parse(txtResultado.Text);
                            txtConta.Text += " * ";
                        }
                        else if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                        {
                            b = Double.Parse(txtResultado.Text);
                            a = Calc.Multiplicacao(a, b);
                            b = Double.NaN;
                            txtConta.Text = a.ToString() + " * ";
                            txtResultado.Text = a.ToString();
                        }
                        break;
                    case "DIVISAO":
                        if (a.Equals(Double.NaN))
                        {
                            a = Double.Parse(txtResultado.Text);
                            txtConta.Text += " / ";
                        }
                        else if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                        {
                            b = Double.Parse(txtResultado.Text);
                            a = Calc.Divisao(a, b);
                            b = Double.NaN;
                            txtConta.Text = a.ToString() + " / ";
                            txtResultado.Text = a.ToString();
                        }
                        break;
                    case "POTENCIA":
                        if (a.Equals(Double.NaN))
                        {
                            a = Double.Parse(txtResultado.Text);
                            txtConta.Text += " elevado A ";
                        }
                        else if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                        {
                            b = Double.Parse(txtResultado.Text);
                            a = Calc.Potencia(b, a);
                            b = Double.NaN;
                            txtConta.Text = a.ToString() + " elevado A ";
                            txtResultado.Text = a.ToString();
                        }
                        break;
                    case "RAIZ":
                        if (a.Equals(Double.NaN))
                        {
                            a = Double.Parse(txtResultado.Text);
                            txtConta.Text += " √ ";
                        }
                        else if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                        {
                            b = Double.Parse(txtResultado.Text);
                            a = Calc.Raiz(b, a);
                            b = Double.NaN;
                            txtConta.Text = a.ToString() + " √ ";
                            txtResultado.Text = a.ToString();
                        }
                        break;
                    case "PORCENTAGEM":
                        if (a.Equals(Double.NaN))
                        {
                            a = Double.Parse(txtResultado.Text);
                            txtConta.Text += "% porcentoDE ";
                        }
                        else if (!(b.Equals(Double.NaN) && a.Equals(Double.NaN)))
                        {
                            b = Double.Parse(txtResultado.Text);
                            a = Calc.Porcentagem(b, a);
                            b = Double.NaN;
                            txtConta.Text = a.ToString() + "% porcentoDE ";
                            txtResultado.Text = a.ToString();
                        }
                        break;
                    case "SEN":
                        txtConta.Text += "Sen ";
                    break;
                    case "COS":
                    txtConta.Text += "Cos ";
                    break;
                    case "TG":
                    txtConta.Text += "Tang ";
                    break;
                    case "FIBREC":
                    txtConta.Text += "Fib ";
                    break;
                    case "FIBITE":
                    txtConta.Text += "Fib ";
                    break;
                    case "FATITE":
                    txtConta.Text += "! ";
                    break;
                    case "FATREC":
                    txtConta.Text += "! ";
                    break;
                }
            }
            txtResultado.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
