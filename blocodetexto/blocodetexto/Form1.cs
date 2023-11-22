using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blocodetexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string LerArquivo(string endereco)
        {
            string conteudo = "";
            if (File.Exists(endereco))
            {
                using (StreamReader sr = new StreamReader(endereco))
                {
                    conteudo = sr.ReadToEnd();
                } 
            }
            return conteudo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txbInput.Text;
            string telefone = txbTelefone.Text;
            string email = txbEmail.Text;
            string pular = "|";
            if (rbEmail.Checked)
            {
                email = "-";
            }
            else if (rbTelefone.Checked)
            {
                telefone = "-";
            }
            string contato = nome + telefone + email+ pular;

            string caminho = "C:/Users/rafaela.ngodoi/source/repos/Nova pasta/blocodetexto/ dados.txt";

            string textoAntigo = LerArquivo(caminho);
           
            using(StreamWriter sw = new StreamWriter(caminho)) 
            {
                sw.Write(textoAntigo + contato);
              
            }
            MessageBox.Show("Arquivo criado com sucesso!");
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string caminho = "C:/Users/rafaela.ngodoi/source/repos/Nova pasta/blocodetexto/ dados.txt";
            string texto = LerArquivo(caminho);
            lbResNome.Text = texto;
            Array lista = texto.Split('\n');
            foreach (string pessoa in lista)
            {
                string[] dados = pessoa.Split('|');
                MessageBox.Show(dados[0]);
                cbxNome.Items.Add(pessoa);
            }
        }
    }
}
