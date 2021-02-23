using System;
using System.IO;
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
    public partial class CriaUsuario : Form
    {
        public CriaUsuario()
        {
            InitializeComponent();
        }

        private void BtnCriarUsuario_Click(object sender, EventArgs e)
        {
            string CriaIdade = TXTIdade.Text;
            string CriaNome = TXTnome.Text;
            
            string[] CriaDadosUsuario = {CriaNome, CriaIdade};

            Program.RecebeDados(CriaDadosUsuario);
            MessageBox.Show("Usuario criado");


            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
