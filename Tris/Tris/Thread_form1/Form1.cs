using System.Drawing.Text;

namespace Thread_form1
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private string turno;
        private int cont;
        private int tempo_giocata = 3;
        public Form1()
        {
            InitializeComponent();
            tempo_rimanente.Text = "Tempo rimanente: " + tempo_giocata.ToString();
        }

        private bool controlloVittoria(Button button)
        {


            return (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "" ||
                btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "" ||
                btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "" ||
                btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "" ||
                btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "" ||
                btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "" ||
                btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "" ||
                btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "");
                
            
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            Button button = (Button)sender;
            if (button.Text == "")
            {
                //Per scriverlo sul bottone cliccato
                button.Text = turno;
                if (controlloVittoria((Button)sender))
                {
                    timer1.Stop();
                    MessageBox.Show("Letsgosky " + turno + " hai vinto!!!");
                    Form1_Load(this, EventArgs.Empty);
                }
                else if (cont == 9)
                {
                    timer1.Stop();
                    MessageBox.Show("Pareggio");
                    Form1_Load(this, EventArgs.Empty);
                }


                if (turno == "X")
                    turno = "O";
                else
                    turno = "X";

                label_turno.Text = turno;
                cont++;

                tempo_giocata = 4;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(620, 450);

            cont = 0;

            Random random = new Random();

            if (random.Next(2) == 0)
                turno = "X";
            else
                turno = "O";

            label_turno.Text = turno;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo_giocata--;
            tempo_rimanente.Text = "Tempo rimanente: " + tempo_giocata.ToString();


            if (tempo_giocata == 0)
            {
                tempo_giocata = 4;
                InserisciInBottoneCasuale();
            }
        }
        private void InserisciInBottoneCasuale()
        {
            Button[] bottoni = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            bool inserito = false;

            while (!inserito)
            {
                int indiceCasuale = random.Next(9);

                if (string.IsNullOrEmpty(bottoni[indiceCasuale].Text))
                {
                    bottoni[indiceCasuale].Text = turno;
                    inserito = true;
                    cont++;
                    if (controlloVittoria(bottoni[indiceCasuale]))
                    {
                        timer1.Stop();
                        MessageBox.Show("Letsgosky " + turno + " hai vinto!!!");
                        Form1_Load(this, EventArgs.Empty);
                    }
                    else if (cont == 9)
                    {
                        timer1.Stop();
                        MessageBox.Show("Pareggio");
                        Form1_Load(this, EventArgs.Empty);
                    }


                    if (turno == "X")
                        turno = "O";
                    else
                        turno = "X";

                    label_turno.Text = turno;
                    
                    if (turno == "X")
                        turno = "O";
                    else
                        turno = "X";

                    label_turno.Text = turno;
                    tempo_giocata = 4;

                }
            }
        }
    }
}
