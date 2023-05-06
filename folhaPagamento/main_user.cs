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
    public partial class main_user : Form
    {
        public UserSession Session { get; set; }

        public main_user(UserSession session)
        {

            InitializeComponent();
            Session = session;

        }

        private void main_user_Load(object sender, EventArgs e)
        {
            string nome = Session.Username;
            bool isAdm = Session.IsAdmin;

            DateTime now = DateTime.Now;


            if (now.Hour >= 5 && now.Hour < 12)
            {
                lblSaudacao.Text = "Bom dia, " + nome;
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                lblSaudacao.Text = "Boa tarde, " + nome;
            }
            else
            {
                lblSaudacao.Text = "Boa noite, " + nome;
            }
        }

        private void btnHolerite_Click(object sender, EventArgs e)
        {
            fHolerite fHolerite = new fHolerite(Session);
            fHolerite.ShowDialog();
        }

        private void btnSairdoSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
