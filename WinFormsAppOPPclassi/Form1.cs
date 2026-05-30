namespace WinFormsAppOPPclassi
{
    public partial class Form1 : Form
    {

        Persona persona1;
        Studente mioStudente;



        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreaPersona_Click(object sender, EventArgs e)
        {
            persona1 = new Persona("matteo ", "alvau", 180, dateTimePicker1.Value);

            buttonLeggiProprieta.Enabled = true;


        }

        private void buttonLeggiProprieta_Click(object sender, EventArgs e)
        {

            labelNome.Text = persona1.Nome + persona1.Cognome;


        }

        private void buttonCresci_Click(object sender, EventArgs e)
        {
            persona1.Cresci(6);
            labelAltezza.Text = persona1.Altezza.ToString();
        }

        private void labeldescrzione_Click(object sender, EventArgs e)
        {

        }

        private void labelProprieta_Click(object sender, EventArgs e)
        {

        }

        private void buttonStudente_Click(object sender, EventArgs e)
        {

            buttonPrumuovi.Enabled = true;
            buttonPrumuovi.Visible = true;

            mioStudente = new Studente("A", "Pippo", "Rossi", 180, dateTimePicker1.Value);



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
