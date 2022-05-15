using LibrarieMedicamente;
using FisierStocareDate;
using System;
using System.Collections;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static LibrarieMedicamente.Enumerari;


namespace UIWindowsForms_Farmacie
{
    public partial class Formular : Form
    {
        AdministrareMedicamente_FisierText adminMedicamente;

        private Label lblHeaderNume;
        private Label lblHeaderPrenume;
        private Label lblHeaderNote;

        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsNote;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 600;

        ArrayList disciplineSelectate = new ArrayList();

        public Formular()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMedicamente = new AdministrareMedicamente_FisierText(caleCompletaFisier);

            InitializeComponent();

            //setare proprietati
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Crimson;
            this.BackColor = Color.SkyBlue;
            this.Text = "Informatii medicamente";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaMedicamente();
        }

        private void AfiseazaMedicamente()
        {
            //adaugare control de tip Label pentru 'Nume';
            lblHeaderNume = new Label();
            lblHeaderNume.Width = LATIME_CONTROL;
            lblHeaderNume.Text = "Nume";
            lblHeaderNume.Left = OFFSET_X + 0;
            lblHeaderNume.ForeColor = Color.IndianRed;
            this.Controls.Add(lblHeaderNume);

            //adaugare control de tip Label pentru 'Prenume';
            lblHeaderPrenume = new Label();
            lblHeaderPrenume.Width = LATIME_CONTROL;
            lblHeaderPrenume.Text = "Afectiune";
            lblHeaderPrenume.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderPrenume.ForeColor = Color.IndianRed;
            this.Controls.Add(lblHeaderPrenume);

            //adaugare control de tip Label pentru 'Note';
            lblHeaderNote = new Label();
            lblHeaderNote.Width = LATIME_CONTROL;
            lblHeaderNote.Text = "Pret";
            lblHeaderNote.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderNote.ForeColor = Color.IndianRed;
            this.Controls.Add(lblHeaderNote);

            ArrayList medicamente = adminMedicamente.GetMedicamente();
            int nrMedicamente = medicamente.Count;
            lblsNume = new Label[nrMedicamente];
            lblsPrenume = new Label[nrMedicamente];
            lblsNote = new Label[nrMedicamente];

            int i = 0;
            foreach (Medicament medicament in medicamente)
            {
                //adaugare control de tip Label pentru numele studentilor;
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = medicament.Nume;
                lblsNume[i].Left = OFFSET_X + 0;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                //adaugare control de tip Label pentru prenumele studentilor
                lblsPrenume[i] = new Label();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = medicament.Afectiune1;
                lblsPrenume[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsPrenume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenume[i]);

                //adaugare control de tip Label pentru notele studentilor
                lblsNote[i] = new Label();
                lblsNote[i].Width = LATIME_CONTROL;
                lblsNote[i].Text = string.Join(" ", medicament.GetNote());
                lblsNote[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsNote[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNote[i]);
                i++;
            }
        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            if (!DateIntrareValide())
            {
                lblDiscipline.ForeColor = Color.Red;
                lblNote.ForeColor = Color.Red;

                return;
            }

            Medicament s = new Medicament(0, txtNume.Text, txtPrenume.Text);
            s.SetNote(txtNote.Text);

            //set program studiu
            //verificare radioButton selectat
            Afectiune specializareSelectata = GetProgramStudiuSelectat();
            s.Specializare = specializareSelectata;

            //set Boli
            s.Boli = new ArrayList();
            s.Boli.AddRange(disciplineSelectate);

            adminMedicamente.AddMedicament(s);
            lblMesaj.Text = "Studentul a fost adaugat";

            //resetarea controalelor pentru a introduce datele unui medicament nou
            ResetareControale();
        }

        private bool DateIntrareValide()
        {
            string[] note = txtNote.Text.Split(' ');
            if (disciplineSelectate.Count != note.Length)
            {
                return false;
            }

            return true;
        }

        private void CkbDiscipline_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string disciplinaSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                disciplineSelectate.Add(disciplinaSelectata);
            else
                disciplineSelectate.Remove(disciplinaSelectata);
        }

        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtNote.Text = string.Empty;

            rdbCalculatoare.Checked = false;
            rdbAutomatica.Checked = false;
            rdbElectronica.Checked = false;

            ckbPCLP.Checked = false;
            ckbPOO.Checked = false;
            ckbPIU.Checked = false;

            disciplineSelectate.Clear();
            lblMesaj.Text = string.Empty;
        }

        private Afectiune GetProgramStudiuSelectat()
        {
            if (rdbCalculatoare.Checked)
                return Afectiune.Raceala;
            if (rdbAutomatica.Checked)
                return Afectiune.Dureri;
            if (rdbElectronica.Checked)
                return Afectiune.Boli_Grave;

            return Afectiune.Raceala;
        }

        private void BtnAfiseaza_Click(object sender, EventArgs e)
        {
            AfiseazaMedicamente();
        }

        private void rdbCalculatoare_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblNume_Click(object sender, EventArgs e)
        {

        }
    }





}
