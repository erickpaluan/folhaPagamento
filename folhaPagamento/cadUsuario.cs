using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folhaPagamento
{
    public partial class cadUsuario : Form
    {
        private connDAO connDAO { get; set; }
        public cadUsuario()
        {
            InitializeComponent();


            try
            {
                connDAO = new connDAO();
                MessageBox.Show("Conectado ao DB!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void cadUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
