using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        private string percorsoFile = "ricette.csv";
        private List<Crostata> listaRicette = new List<Crostata>(); 

        public Form1()
        {
            InitializeComponent();
            cmbTipoFrolla.DataSource = Enum.GetValues(typeof(TipoFrolla));
            cmbTipoMarmellata.DataSource = Enum.GetValues(typeof(TipoMarmellata));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreaFile();
            CaricaDaFile();
            MostraRicette(listaRicette);
        }

        private void CreaFile()
        {
            if (!File.Exists(percorsoFile))
            {
                File.AppendAllText(percorsoFile, "Crostata Classica,Classica,Albicocca,40,24,True\n");
                File.AppendAllText(percorsoFile, "Delizia di Fragole,Integrale,Fragola,35,26,True\n");
                File.AppendAllText(percorsoFile, "Dolce Ciliegia,Classica,Ciliegia,45,22,False\n");
                File.AppendAllText(percorsoFile, "Tradizionale,Classica,Pesca,40,24,True\n");
                File.AppendAllText(percorsoFile, "Integrale Speciale,Integrale,Albicocca,38,28,False\n");
            }
        }

        private void CaricaDaFile()  
        {
            listaRicette.Clear();

            if (File.Exists(percorsoFile))
            {
                string[] righeDelFile = File.ReadAllLines(percorsoFile);

                for (int i = 0; i < righeDelFile.Length; i++)
                {
                    string rigaCorrente = righeDelFile[i];

                    if (rigaCorrente != "")
                    {
                        Crostata nuovaCrostata = CrostataDalFile(rigaCorrente);
                        listaRicette.Add(nuovaCrostata);
                    }
                }
            }
        }

        private Crostata CrostataDalFile(string riga)  
        {
            string[] campi = riga.Split(',');   

            string nome = campi[0];
            TipoFrolla frolla = (TipoFrolla)Enum.Parse(typeof(TipoFrolla), campi[1]);       //converte la stringa in un valore dell'enum ad esempio "Classica" in TipoFrolla.Classica
            TipoMarmellata marmellata = (TipoMarmellata)Enum.Parse(typeof(TipoMarmellata), campi[2]);
            int tempoCottura = int.Parse(campi[3]);     
            int diametro = int.Parse(campi[4]);
            bool decorazione = bool.Parse(campi[5]);

            return new Crostata(frolla, marmellata, tempoCottura, diametro, decorazione, nome);
        }

        private string RigaCSV(Crostata crostata)
        {
            return crostata.Nome + "," + crostata.frolla + "," + crostata.marmellata + "," +
                   crostata.TempoCottura + "," + crostata.Diametro + "," + crostata.Decorazione;
        }

        private void MostraRicette(List<Crostata> ListaRicette) 
        {
            lstRicette.Items.Clear();

            for (int i = 0; i < ListaRicette.Count; i++)  
            {
                Crostata crostata = ListaRicette[i];

                string Decorazione;
                if (crostata.Decorazione)
                {
                    Decorazione = "Sì";
                }
                else
                {
                    Decorazione = "No";
                }

                string rigaCrostata = crostata.Nome + " - Frolla: " + crostata.frolla +
                                        ", Marmellata: " + crostata.marmellata +
                                        ", Cottura: " + crostata.TempoCottura + "min" +
                                        ", Diametro: " + crostata.Diametro + "cm" +
                                        ", Decorata: " + Decorazione;

                lstRicette.Items.Add(rigaCrostata);
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Il nome della crostata è obbligatorio.");
                return;
            }

            int tempoCottura = 0;
            if (!int.TryParse(txtTempoCottura.Text, out tempoCottura) || tempoCottura <= 0)
            {
                MessageBox.Show("Il tempo di cottura deve essere un numero positivo.");
                return;
            }

            int diametro = 0;
            if (!int.TryParse(txtDiametro.Text, out diametro) || diametro <= 0)
            {
                MessageBox.Show("Il diametro deve essere un numero positivo.");
                return;
            }

            if (!rdbDecorazioneSi.Checked && !rdbDecorazioneNo.Checked)
            {
                MessageBox.Show("Seleziona se la crostata ha decorazione o no.");
                return;
            }

            TipoFrolla frolla = (TipoFrolla)cmbTipoFrolla.SelectedItem;
            TipoMarmellata marmellata = (TipoMarmellata)cmbTipoMarmellata.SelectedItem;
            string nome = txtNome.Text;
            bool decorazione = rdbDecorazioneSi.Checked;

            Crostata nuovaCrostata = new Crostata(frolla, marmellata, tempoCottura, diametro, decorazione, nome);

            string riga = RigaCSV(nuovaCrostata) + "\n";
            File.AppendAllText(percorsoFile, riga);

            MessageBox.Show("Ricetta salvata");

            CaricaDaFile();
            MostraRicette(listaRicette);
            PulisciCampi();
        }

        private void PulisciCampi()
        {
            txtNome.Clear();
            txtTempoCottura.Clear();
            txtDiametro.Clear();
            rdbDecorazioneSi.Checked = false;
            rdbDecorazioneNo.Checked = false;
            cmbTipoFrolla.SelectedIndex = 0;
            cmbTipoMarmellata.SelectedIndex = 0;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string marmellataCerca = txtCerca.Text;

            if (marmellataCerca == "")
            {
                MessageBox.Show("Inserisci un tipo di marmellata da cercare.");
                return;
            }

            List<Crostata> crostateMarmellata = new List<Crostata>();

            for (int i = 0; i < listaRicette.Count; i++)
            {
                string marmellataCorrente = listaRicette[i].marmellata.ToString();

                if (marmellataCorrente.ToLower() == marmellataCerca.ToLower())
                {
                    crostateMarmellata.Add(listaRicette[i]);
                }
            }

            if (crostateMarmellata.Count > 0)
            {
                MostraRicette(crostateMarmellata);
                MessageBox.Show("Trovate " + crostateMarmellata.Count + " crostate con marmellata di " + marmellataCerca);
            }
            else
            {
                MessageBox.Show("Nessuna crostata trovata con marmellata di " + marmellataCerca);
            }
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            List<Crostata> listaOrdinata = new List<Crostata>();     
            for (int i = 0; i < listaRicette.Count; i++) 
            {
                listaOrdinata.Add(listaRicette[i]);
            }

            for (int i = 0; i < listaOrdinata.Count - 1; i++)   
            {
                for (int j = 0; j < listaOrdinata.Count - 1; j++) 
                {
                    if (string.Compare(listaOrdinata[j].Nome, listaOrdinata[j + 1].Nome) > 0)   // string.Compare restituisce un valore positivo se il primo stringa viene dopo il secondo in tal caso scambio
                    {
                        Crostata scambio = listaOrdinata[j];   
                        listaOrdinata[j] = listaOrdinata[j + 1];    
                        listaOrdinata[j + 1] = scambio; 
                    }
                }
            }

            MostraRicette(listaOrdinata);
            MessageBox.Show("Ricette ordinate per nome");
        }


        private void txtCerca_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtDiametro_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTempoCottura_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbTipoMarmellata_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbTipoFrolla_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void lstRicette_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void rdbDecorazioneSi_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void rdbDecorazioneNo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}