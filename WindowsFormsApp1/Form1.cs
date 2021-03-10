using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int Integer;
        public float Float;
        public string String;
        public char Char;
        public bool Boolean;

        public Form1()
        {
            InitializeComponent();
            listBoolean.SelectedItem = "True";
        }

        private void btnInteger_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
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

        private void btnFloat_Click(object sender, EventArgs e)
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

        private void btnString_Click(object sender, EventArgs e)
        {
            try
            {
                String = (txtString.Text);
                lblString.Text = String;
                txtString.Text = @"";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtString.Text = @"";
            }
        }

        private void btnChar_Click(object sender, EventArgs e)
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

        private void btnBoolean_Click(object sender, EventArgs e)
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

        private void txtInteger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInteger_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void txtFloat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFloat_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void txtString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnString_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void txtChar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChar_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }

        private void listBoolean_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBoolean_Click(this, new EventArgs());
                this.ActiveControl = null;
            }
        }
    }
}
