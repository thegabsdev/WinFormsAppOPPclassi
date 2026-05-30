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
            persona1 = new Persona("matteo ", "alvau", 180);
            mioStudente = new Studente("A", "Pippo", "Rossi", 180);
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
    }
}
