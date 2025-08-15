using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Exemplo_arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botão de ligar
            // instanciando a porta COM4 para ser utilizada
            SerialPort port = new SerialPort("COM3", 9600);
            // Abrindo a porta para ser utilizada
            port.Open();
            // chamando a função de escrever "1"
            port.Write("1");
            // fechando a porta e encerrando o uso
            port.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Botão de desligar
            // instanciando a porta COM4 para ser utilizada
            SerialPort port = new SerialPort("COM3", 9600);
            // Abrindo a porta para ser utilizada
            port.Open();
            // chamando a função de escrever "1"
            port.Write("0");
            // fechando a porta e encerrando o uso
            port.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
