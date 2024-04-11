namespace AS2324._3G.Prof.AutomobileWF
{
    public partial class Form1 : Form
    {
        const int stepAccellerazione = 10;
        const int stepFrenata = -5;
        int vento = 0;

        double velocita = 0;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            cmbStrada.SelectedIndex = 2;

            // parameters setting on progress bar
            prbVelocita.Minimum = 0;
            prbVelocita.Maximum = 160;

            grbComandi.Enabled = false;
        }

        private void btnAccellera_Click(object sender, EventArgs e)
        {
            if (velocita < prbVelocita.Maximum)
                velocita += stepAccellerazione;

            vento = rnd.Next(-1, 3);

            velocita = velocita + vento;

            monitor();
        }

        private void btnFrena_Click(object sender, EventArgs e)
        {
            if (velocita > prbVelocita.Minimum)
                velocita += stepFrenata;

            vento = rnd.Next(-1, 3);

            velocita = velocita + vento;

            monitor();
        }


        private void monitor()
        {
            prbVelocita.Value = (int)velocita;

            label1.Text = vento.ToString() + "km/h";

            lblVelocita.Text = velocita.ToString() + "km/h";

            switch (cmbStrada.SelectedIndex)
            {
                case 0:
                    if (velocita > 130)
                    {
                        lstMonitor.Items.Add("RALLENTA! hai superto il limite di velocita");
                    }
                    else
                        lstMonitor.Items.Clear();

                    break;

                case 1:
                    if (velocita > 90)
                    {
                        lstMonitor.Items.Add("RALLENTA! hai superto il limite di velocita");
                    }
                    else
                        lstMonitor.Items.Clear();

                    break;

                case 2:
                    if (velocita > 50)
                    {
                        lstMonitor.Items.Add("RALLENTA! hai superto il limite di velocita");
                    }
                    else
                        lstMonitor.Items.Clear();

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
            else
                lstMonitor.Items.Clear();
        }

        private void cmbStrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            monitor();
        }

        private void btnClacson_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
        }
    }
}
