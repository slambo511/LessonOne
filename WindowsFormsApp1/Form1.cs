using System;
using System.Windows.Forms;
using System.Media;

namespace DataTypes
{
    public partial class Form1 : Form
    {
        public Timer aTimer = new Timer();
        public int Integer;
        public float Float;
        public string String;
        public char Char;
        public bool Boolean;
        readonly SoundPlayer player = new SoundPlayer();
        private int noOfClues = 4;
        private int clueNo = 1;
        private string clueOne = "Use the other mouse button :-)";
        private string clueTwo = "Your clue is \"The opposite of the adverb which tells someone " +
                "you are sitting in a bad chair and the adjective which describes " +
                "what the dentist does before drilling a tooth.";
        private string clueThree = "A song by a band whose name is the colour of Barbie's dress " +
                "and the surname of the man killed in America by police which caused an outcry " +
                "across the world.";
        private string clueFour = "Your final clue is that, if you have the answer and it is not " +
                "working, remember how song titles are written and remember, computers are " +
                "stupid and need everything to be exact, or they will fail.";

        // This is a single line comment

        /* This is a
         * multiline
         * comment */

        /// <summary>
        /// This is an XML comment
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            listBoolean.SelectedItem = @"True";
            txtInteger.Select();
        }

        private void BtnInteger_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInteger.Text == @"")
                {
                    MessageBox.Show(@"You must enter a value first");
                    txtInteger.Focus();
                    return;
                }
                else if (txtInteger.Text == @"42")
                {
                    Width = Screen.PrimaryScreen.WorkingArea.Width;
                    Height = Screen.PrimaryScreen.WorkingArea.Height;
                    CenterToParent();
                    txtInteger.Text = @"";
                    lblInteger.Text = @"Life, the universe and everything";
                    return;
                }

                Integer = int.Parse(txtInteger.Text);
                lblInteger.Text = Integer.ToString();
                txtInteger.Text = @"";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtInteger.Text = @"";
            }
        }

        private void BtnFloat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFloat.Text == @"")
                {
                    MessageBox.Show(@"You must enter a value first");
                    txtFloat.Focus();
                    return;
                }

                Float = float.Parse(txtFloat.Text);

                if (!txtFloat.Text.Contains(@"."))
                {
                    MessageBox.Show(@"You must enter fractional number");
                    txtFloat.Text = "";
                    txtFloat.Focus();
                    return;
                }

                lblFloat.Text = Float.ToString() + "f";
                txtFloat.Text = @"";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "f");
                txtFloat.Text = @"";
            }
        }

        private void BtnString_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtString.Text == @"")
                {
                    MessageBox.Show(@"You cannot use a null String");
                    txtString.Focus();
                    return;
                }

                String = ("\"" + txtString.Text + "\"");
                lblString.Text = String;
                txtString.Text = "";

                if (lblString.Text == "\"Comfortably Numb\"" || lblString.Text == @"Pink Floyd")
                {
                    MessageBox.Show(@"You found the Easter egg :-)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\"" + ex.Message + "\"");
                txtString.Text = @"";
            }
        }

        private void BtnChar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtChar.Text == @"")
                {
                    MessageBox.Show(@"You must enter a value first");
                    txtChar.Focus();
                    return;
                }

                Char = char.Parse(txtChar.Text);
                lblChar.Text = "\'" + Char.ToString() + "\'";
                txtChar.Text = @"";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtChar.Text = @"";
            }
        }

        private void BtnBoolean_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean = bool.Parse(listBoolean.SelectedItem.ToString());
                lblBoolean.Text = listBoolean.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            if (lblString.Text != @"Empty" && lblInteger.Text != @"Empty" && lblFloat.Text != @"Empty" && lblChar.Text != @"Empty" && lblBoolean.Text != @"Empty")
            {
                MessageBox.Show(@"Well done, you filled them all :-)");
            }

            lblInteger.Text = @"Empty";
            lblFloat.Text = @"Empty";
            lblString.Text = @"Empty";
            lblChar.Text = @"Empty";
            lblBoolean.Text = @"Empty";
        }

        private void TxtInteger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Stops the program from make "ding" noise when pressing Enter.
                e.SuppressKeyPress = true;
                BtnInteger_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void TxtFloat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Stops the program from make "ding" noise when pressing Enter.
                e.SuppressKeyPress = true;
                BtnFloat_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void TxtString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Stops the program from make "ding" noise when pressing Enter.
                e.SuppressKeyPress = true;
                BtnString_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void TxtChar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Stops the program from make "ding" noise when pressing Enter.
                e.SuppressKeyPress = true;
                BtnChar_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void ListBoolean_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Stops the program from make "ding" noise when pressing Enter.
                e.SuppressKeyPress = true;
                BtnBoolean_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void PlayMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"Resources\CN.wav";
            player.Play();
        }

        private void StopMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            player.Stop();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Data Types program.");
        }

        private void ShowClue()
        {
            if (clueNo == 1)
            {
                MessageBox.Show(clueOne, "First Clue");
                clueNo += 1;
            }
            else if (clueNo == 2)
            {
                MessageBox.Show(clueTwo, "Second Clue");
                clueNo += 1;
            }
            else if (clueNo == 3)
            {
                MessageBox.Show(clueThree, "Third Clue");
                clueNo += 1;
            }
            else if (clueNo == 4)
            {
                MessageBox.Show(clueFour, "Fourth Clue");
                revealSomethingHiddenToolStripMenuItem.Visible = true;
                clueNo = noOfClues + 1;
            }
            else
            {
                ShowClue("There are only " + noOfClues.ToString() + " clues at the moment. ");
            }
        }

        private void ShowClue(string additionalMessage)
        {
             MessageBox.Show(additionalMessage + clueFour, "Final Clue");
        }

        private void btnClue_Click(object sender, EventArgs e)
        {
            clueNo = 1;
            btnClue.Visible = false;
        }

        private void showClueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowClue();
        }

        private void revealSomethingHiddenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClue.Visible = true;
            revealSomethingHiddenToolStripMenuItem.Visible = false;
        }

        private void txbFirstClue_MouseHover(object sender, EventArgs e)
        {
            txbFirstClue.Text = "";
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
            aTimer.Start();
            aTimer.Tick += ATimer_Tick;
            //aTimer.Dispose();
        }

        private void ATimer_Tick(object sender, EventArgs e)
        {
            txbFirstClue.Text = "First clue: Use the other mouse button :-)";
            aTimer.Stop();
            aTimer.Start();
            aTimer.Tick += BTimer_Tick;
        }

        private void BTimer_Tick(object sender, EventArgs e)
        {
            txbFirstClue.Text = "Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** " +
                "Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** " +
                "Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** " +
                "Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** Error *** ";
            txbFirstClue.Enabled = false;
            aTimer.Stop();
            aTimer.Start();
            aTimer.Tick += CTimer_Tick;
        }

        private void CTimer_Tick(object sender, EventArgs e)
        {
            txbFirstClue.Visible = false;
        }
    }
}
