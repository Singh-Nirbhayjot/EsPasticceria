using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsPasticceria
{
    public enum TipoFrolla
    {
        Classica,
        Integrale,
        SenzaGlutine
    }
    public enum TipoMarmellata
    {
        Albicocca,
        Fragola,
        Ciliegia,
        Pesca
    }
    public struct Crostata
    {
        public TipoFrolla frolla;
        public TipoMarmellata marmellata;
        public int TempoCottura;
        public int Diametro;
        public bool Decorazione;
        public string Nome;

        public Crostata(TipoFrolla frolla, TipoMarmellata marmellata, int tempoCottura, int diametro, bool decorazione, string nome)
        {
            this.frolla = frolla;
            this.marmellata = marmellata;
            this.TempoCottura = tempoCottura;
            this.Diametro = diametro;
            this.Decorazione = decorazione;
            this.Nome = nome;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTipoFrolla.DataSource = Enum.GetValues(typeof(TipoFrolla));
            cmbTipoMarmellata.DataSource = Enum.GetValues(typeof(TipoMarmellata));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {       
            if(string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Il nome della crostata è obbligatorio.");
                return;
            }
            if (!int.TryParse(txtTempoCottura.Text, out int tempoCottura) || tempoCottura <= 0)
            {
                MessageBox.Show("Il tempo di cottura deve essere un numero positivo.");
                return;
            }
            if (!int.TryParse(txtDiametro.Text, out int diametro) || diametro <= 0)
            {
                MessageBox.Show("Il diametro deve essere un numero positivo.");
                return;
            }
            if (!rdbDecorazioneSi.Checked && !rdbDecorazioneNo.Checked)
            {
                MessageBox.Show("Seleziona se la crostata ha decorazione o no.");
                return;
            }
            
        }
    }
}
