using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA2
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirCriarUsuario();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AbrirListaUsuario();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AbrirBuscaUsuario();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AbrirExcluirUsuario();
        }

        private void CaixaOpcao_TextChanged(object sender, EventArgs e)
            // excuta a funcao de acordo com a opcao digitada.
        {

           
            
                string Opcao = CaixaOpcao.Text;
            if (Opcao == "")
            {
                
            }
            else if (Opcao == "1")
                {
                AbrirCriarUsuario();
                }
           else if (Opcao == "2")
                {

                AbrirListaUsuario();

                }
            else if (Opcao == "3")
                {

                AbrirBuscaUsuario();

                }
            else if (Opcao == "4")
                {

                AbrirExcluirUsuario();

                }
            else if (Opcao == "5")
                {

                FecharApp();

                }

            else
                    
                {
                AbrirErroDeOpcao();

                }
                        
        }
        private void AbrirCriarUsuario()
        {
            
            CaixaOpcao.Text = "";
            CriaUsuario criaUsuario = new CriaUsuario();
            criaUsuario.Show();

        }
        private void AbrirListaUsuario()
        {

            CaixaOpcao.Text = "";
            ListaUsuario listaUsuario = new ListaUsuario();
            listaUsuario.Show();

        }
        private void AbrirBuscaUsuario()
        {

            CaixaOpcao.Text = "";
            BuscarUsuario buscarUsuario = new BuscarUsuario();
            buscarUsuario.Show();

        }
        private void AbrirExcluirUsuario()
        {

            CaixaOpcao.Text = "";
            ExcluirUsuario excluirUsuario = new ExcluirUsuario();
            excluirUsuario.Show();

        }
        private void FecharApp()
        {

            Application.Exit();

        }
        private void AbrirErroDeOpcao()
        {

            MessageBox.Show("Opcao invalida");
            CaixaOpcao.Text = "";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
