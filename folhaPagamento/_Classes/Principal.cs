using folhaPagamento._DAO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento._Classes
{
    internal class Principal
    {
        public Funcionario Usuarios { get; set; }
        public string Saudacao(string nome)
        {
            DateTimeOffset now = DateTimeOffset.Now;
            if (now.Hour >= 5 && now.Hour < 12)
            {
                return $"Bom dia, {nome}.";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                return $"Boa tarde, {nome}.";
            }
            else
            {
                return $"Boa noite, {nome}.";
            }
            return nome;
        }

        public void FazerMarcacao()
        {
            Registro novoRegistro = new Registro()
            {
                cpf_ponto = Usuarios.cpf,
                data = DateTime.Now.Date,
                hora = TimeSpan.FromSeconds(Math.Floor(DateTime.Now.TimeOfDay.TotalSeconds))
            };

            string mensagemConfirmacao = $"Efetuar marcação para:\nNome: {Usuarios.nome}\nCPF: {novoRegistro.cpf_ponto}\nData: {novoRegistro.data.ToString("dd/MM/yyyy")}\nHora: {novoRegistro.hora.ToString(@"hh\:mm\:ss")}";
            DialogResult resultado = MessageBox.Show(mensagemConfirmacao, "Revise as informações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                PontoDAO pontoDAO = new PontoDAO();
                pontoDAO.RegistrarPonto(novoRegistro.cpf_ponto, novoRegistro.data, novoRegistro.hora);
            }
        }
        public void carregaDiasSemana()
        {
            var dataAtual = DateTime.Today;
            var horaPonto = "";
            var cultura = CultureInfo.CurrentCulture;
            const int corPainelDataAtual = 218;
            var registroPontoDAO = new PontoDAO();

            int diasPassados = (int)dataAtual.DayOfWeek;
            for (int i = 0; i < 7; i++)
            {
                DateTime data = dataAtual.AddDays(i - diasPassados);
                string nomeDiaSemana = cultura.DateTimeFormat.GetDayName(data.DayOfWeek);
                string diaMes = data.ToString("dd/MM");
                string resultado = $"{nomeDiaSemana} ({diaMes})";

                // Exibir o resultado em cada label correspondente
                DefinirDiaSemana(data.DayOfWeek, resultado, data, dataAtual, corPainelDataAtual, registroPontoDAO);

                // Definir o estilo de borda para o painel da data de hoje
                if (data.Date == dataAtual)
                {
                  //  Panel panel = GetPanelForDayOfWeek(data.DayOfWeek);
                  //  panel.BackColor = Color.FromArgb(corPainelDataAtual, corPainelDataAtual, corPainelDataAtual);
                }
            }
        }

        private void DefinirDiaSemana(DayOfWeek dayOfWeek, string text, DateTime data, DateTime dataAtual, int corPainelDataAtual, PontoDAO registroPontoDAO)
        {
           // MostrarDiaSemana(dayOfWeek, text);
            MostrarMarcacaoDia(dayOfWeek, data, dataAtual, corPainelDataAtual, registroPontoDAO);
        }

        //private void MostrarDiaSemana(DayOfWeek dayOfWeek, string text)
        //{
        //    switch (dayOfWeek)
        //    {
        //        case DayOfWeek.Monday:
        //            lblSegunda.Text = text;
        //            break;
        //        case DayOfWeek.Tuesday:
        //            lblTerca.Text = text;
        //            break;
        //        case DayOfWeek.Wednesday:
        //            lblQuarta.Text = text;
        //            break;
        //        case DayOfWeek.Thursday:
        //            lblQuinta.Text = text;
        //            break;
        //        case DayOfWeek.Friday:
        //            lblSexta.Text = text;
        //            break;
        //        case DayOfWeek.Saturday:
        //            lblSabado.Text = text;
        //            break;
        //        case DayOfWeek.Sunday:
        //            lblDomingo.Text = text;
        //            break;
        //        // E assim por diante para os outros dias da semana
        //        default:
        //            throw new ArgumentOutOfRangeException(nameof(dayOfWeek));
        //    }
        //
        //}
        //private Panel GetPanelForDayOfWeek(DayOfWeek dayOfWeek)
        //{
        //    switch (dayOfWeek)
        //    {
        //        case DayOfWeek.Monday:
        //            return panelSegunda;
        //        case DayOfWeek.Tuesday:
        //            return panelTerca;
        //        case DayOfWeek.Wednesday:
        //            return panelQuarta;
        //        case DayOfWeek.Thursday:
        //            return panelQuinta;
        //        case DayOfWeek.Friday:
        //            return panelSexta;
        //        case DayOfWeek.Saturday:
        //            return panelSabado;
        //        case DayOfWeek.Sunday:
        //            return panelDomingo;
        //        default:
        //            throw new ArgumentOutOfRangeException(nameof(dayOfWeek));
        //    }
        //}


        private void MostrarMarcacaoDia(DayOfWeek dayOfWeek, DateTime data, DateTime dataAtual, int corPainelDataAtual, PontoDAO registroPontoDAO)
        {
            var marcacoesDia = registroPontoDAO.GetRegistros();

            // Definir o estilo de borda para o painel da data de hoje
            if (data.Date == dataAtual.Date)
            {
               // Panel panel = GetPanelForDayOfWeek(dayOfWeek);
                //panel.BackColor = Color.FromArgb(corPainelDataAtual, corPainelDataAtual, corPainelDataAtual);
            }
        }










    }
}
