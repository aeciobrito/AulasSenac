using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroEnderecosForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapturaEndereco(txtLinkSite.Text);
        }

        string nomeLugar = string.Empty;
        decimal posicaoX = 0m;
        decimal posicaoY = 0m;
        const string caminhoLugar = "place/";

        

        void CapturaEndereco(string texto)
        {
            var link = txtLinkSite.Text.Trim();
            ValidadorDeEndereco(link);
        }

        void ValidadorDeEndereco(string endereco)
        {
            if (string.IsNullOrEmpty(endereco))
                ExibeMensagemDeErro("Endereço não pode ser vazio!");
            // else if (!endereco.StartsWith("https://www.google.com/maps/") || !endereco.StartsWith("https://www.google.com.br/maps/"))
            else if (!endereco.Contains("www.google.com") && !endereco.Contains("maps"))
                ExibeMensagemDeErro("Não é um link do google maps válido.\nEndereço deve iniciar com https://www.google.com/maps/");

            SeparaDadosEndereco(endereco);
            SeparaDadosPosicao(endereco);
                       
        }

        static void ExibeMensagemDeErro(string mensagemDeErro)
        {
            MessageBox.Show(mensagemDeErro);
        }

        void SeparaDadosEndereco(string endereco)
        {
            nomeLugar = endereco.Substring(endereco.IndexOf(caminhoLugar) + caminhoLugar.Length, endereco.IndexOf("/@") - (endereco.IndexOf(caminhoLugar) + caminhoLugar.Length));
            nomeLugar = nomeLugar.Replace('+', ' ');
            //Console.WriteLine($"Nome do lugar: {nomeLugar}");
            txtNomeLugar.Text = nomeLugar;
        }

        void SeparaDadosPosicao(string endereco)
        {
            var coordenadas = endereco.Substring(endereco.IndexOf("@") + 1, (endereco.LastIndexOf(",")) - (endereco.IndexOf("@") + 1));
            posicaoX = decimal.Parse(coordenadas.Split(',')[0]);
            posicaoY = decimal.Parse(coordenadas.Split(',')[1]);

            //Console.WriteLine($"Posição X: {posicaoX}\nPosiçãoY: {posicaoY}");
            txtPosicaoX.Text = posicaoX.ToString();
            txtPosicaoY.Text = posicaoY.ToString();
        }
    }
}
