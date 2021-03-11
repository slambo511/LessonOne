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
        SoundPlayer player = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            listBoolean.SelectedItem = "True";
        }

        private void BtnInteger_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void BtnFloat_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void playMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"Resources\CN.wav";
            player.Play();
        }

        private void stopMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            player.Stop();
        }
    }
}
