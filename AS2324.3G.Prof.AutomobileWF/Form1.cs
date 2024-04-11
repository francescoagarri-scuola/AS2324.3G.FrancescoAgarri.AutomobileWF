namespace AS2324._3G.Prof.AutomobileWF
{
    public partial class Form1 : Form
    {
        const int stepAccellerazione = 10;
        const int stepFrenata = -5;

        double velocita = 0;

        public Form1()
        {
            InitializeComponent();

            // parameters setting on progress bar
            prbVelocita.Minimum = 0;
            prbVelocita.Maximum = 160;

            grbComandi.Enabled = false;
        }

        private void btnAccellera_Click(object sender, EventArgs e)
        {
            velocita += stepAccellerazione;

            monitor();
        }

        private void btnFrena_Click(object sender, EventArgs e)
        {
            velocita += stepFrenata;

            monitor();
        }


        private void monitor()
        {
            prbVelocita.Value = (int)velocita;

            switch (cmbStrada.SelectedIndex)
            {
                case 1:
                    if (velocita > 130)
                    {
                        lstMonitor.Items.Add("RALLENTA! hai superto il limite di velocita");
                    }

                    break;

                case 2:
                    if (velocita > 90)
                    {
                        lstMonitor.Items.Add("RALLENTA! hai superto il limite di velocita");
                    }

                    break;

                case 3:
                    if (velocita > 50)
                    {
                        lstMonitor.Items.Add("RALLENTA! hai superto il limite di velocita");
                    }

                    break;
            }
            


        }

        private void chkAccensione_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccensione.Checked == true)
                grbComandi.Enabled = true;
            else
                grbComandi.Enabled = false;

            if (chkAccensione.Checked == true && chkCinture.Checked == false)
                lstMonitor.Items.Add("allaccia le cinture!");
        }

        private void lblVelocita_Click(object sender, EventArgs e)
        {

        }

        private void cmbStrada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
