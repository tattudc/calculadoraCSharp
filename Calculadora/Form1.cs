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
        double total;
        double ultimoNumero;
        String operador;

        private void Limpar()
        {
            total = 0;
            ultimoNumero = 0;
            operador = "+";
            textResult.Text = "";
        }


        private void calcular()
        {
            switch (operador)
            {
                case "+": total = total + ultimoNumero;
                    break;
                case "-": total = total - ultimoNumero;
                    break;
                case "/": total = total / ultimoNumero;
                    break;
                case "X": total = total * ultimoNumero;
                    break;
            }
            ultimoNumero = 0;
            textResult.Text = total.ToString();
        }


        public Form1()
        {
            InitializeComponent();
            Limpar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void gerarNumero(object sender, EventArgs e)
        {
            if (ultimoNumero == 0)
            {
                textResult.Text = (sender as Button).Text;
            }
            else
            {
                textResult.Text = textResult.Text + (sender as Button).Text;
            }
            ultimoNumero = Convert.ToDouble(textResult.Text);
            
        }

        private void operadores(object sender, EventArgs e)
        {
            ultimoNumero = Convert.ToDouble(textResult.Text);
            calcular();
            operador = (sender as Button).Text;
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            ultimoNumero = Convert.ToDouble(textResult.Text);
            calcular();
            operador = "+";
            total = 0;
        }
    }
}
