using System;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int Integer;
        public float Float;
        public string String;
        public char Char;
        public bool Boolean;
        readonly SoundPlayer player = new SoundPlayer();

        // This is a single line comment

        /* This is a
         * multiline
         * comment */

        /// <summary>
        /// This is and XML comment
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            listBoolean.SelectedItem = "True";
            txtInteger.Select();
        }

        private void BtnInteger_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInteger.Text == "")
                {
                    MessageBox.Show("You must enter a value first");
                    txtInteger.Focus();
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
                if (txtFloat.Text == "")
                {
                    MessageBox.Show("You must enter a value first");
                    txtFloat.Focus();
                    return;
                }
                Float = float.Parse(txtFloat.Text);
                lblFloat.Text = Float.ToString();
                txtFloat.Text = @"";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtFloat.Text = @"";
            }
        }

        private void BtnString_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtString.Text == "")
                {
                    MessageBox.Show("You cannot use a null String");
                    txtString.Focus();
                    return;
                }
                String = (txtString.Text);
                lblString.Text = String;
                txtString.Text = @"";
                if (lblString.Text == @"Comfortably Numb")
                {
                    MessageBox.Show(@"You found the Easter egg :-)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtString.Text = @"";
            }
        }

        private void BtnChar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtChar.Text == "")
                {
                    MessageBox.Show("You must enter a value first");
                    txtChar.Focus();
                    return;
                }
                Char = char.Parse(txtChar.Text);
                lblChar.Text = Char.ToString();
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
                // txtBoolean.Text = @"";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // txtBoolean.Text = @"";
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            if (lblString.Text != "Empty" && lblInteger.Text != "" && lblFloat.Text != "Empty" && lblChar.Text != "Empty" && lblBoolean.Text != "Empty")
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
                BtnInteger_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void TxtFloat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnFloat_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void TxtString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnString_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void TxtChar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnChar_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void ListBoolean_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
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
    }
}
