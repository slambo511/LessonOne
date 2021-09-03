
namespace DataTypes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInteger = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.btnBoolean = new System.Windows.Forms.Button();
            this.txtInteger = new System.Windows.Forms.TextBox();
            this.txtFloat = new System.Windows.Forms.TextBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.listBoolean = new System.Windows.Forms.ListBox();
            this.lblInteger = new System.Windows.Forms.Label();
            this.lblFloat = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.lblBoolean = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revealSomethingHiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClue = new System.Windows.Forms.Button();
            this.txbFirstClue = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInteger
            // 
            this.btnInteger.Location = new System.Drawing.Point(12, 12);
            this.btnInteger.Name = "btnInteger";
            this.btnInteger.Size = new System.Drawing.Size(103, 23);
            this.btnInteger.TabIndex = 0;
            this.btnInteger.Text = "Add Integer";
            this.btnInteger.UseVisualStyleBackColor = true;
            this.btnInteger.Click += new System.EventHandler(this.BtnInteger_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.Location = new System.Drawing.Point(12, 87);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(103, 23);
            this.btnFloat.TabIndex = 3;
            this.btnFloat.Text = "Add Float";
            this.btnFloat.UseVisualStyleBackColor = true;
            this.btnFloat.Click += new System.EventHandler(this.BtnFloat_Click);
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(12, 162);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(103, 23);
            this.btnString.TabIndex = 6;
            this.btnString.Text = "Add String";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.BtnString_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(12, 237);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(103, 23);
            this.btnChar.TabIndex = 9;
            this.btnChar.Text = "Add Char";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.BtnChar_Click);
            // 
            // btnBoolean
            // 
            this.btnBoolean.Location = new System.Drawing.Point(12, 312);
            this.btnBoolean.Name = "btnBoolean";
            this.btnBoolean.Size = new System.Drawing.Size(103, 23);
            this.btnBoolean.TabIndex = 12;
            this.btnBoolean.Text = "Add Boolean";
            this.btnBoolean.UseVisualStyleBackColor = true;
            this.btnBoolean.Click += new System.EventHandler(this.BtnBoolean_Click);
            // 
            // txtInteger
            // 
            this.txtInteger.Location = new System.Drawing.Point(207, 12);
            this.txtInteger.Name = "txtInteger";
            this.txtInteger.Size = new System.Drawing.Size(100, 20);
            this.txtInteger.TabIndex = 1;
            this.txtInteger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtInteger_KeyDown);
            // 
            // txtFloat
            // 
            this.txtFloat.Location = new System.Drawing.Point(207, 87);
            this.txtFloat.Name = "txtFloat";
            this.txtFloat.Size = new System.Drawing.Size(100, 20);
            this.txtFloat.TabIndex = 4;
            this.txtFloat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFloat_KeyDown);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(207, 162);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(100, 20);
            this.txtString.TabIndex = 7;
            this.txtString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtString_KeyDown);
            // 
            // txtChar
            // 
            this.txtChar.Location = new System.Drawing.Point(207, 237);
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(100, 20);
            this.txtChar.TabIndex = 10;
            this.txtChar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtChar_KeyDown);
            // 
            // listBoolean
            // 
            this.listBoolean.FormattingEnabled = true;
            this.listBoolean.Items.AddRange(new object[] {
            "True",
            "False"});
            this.listBoolean.Location = new System.Drawing.Point(207, 312);
            this.listBoolean.Name = "listBoolean";
            this.listBoolean.Size = new System.Drawing.Size(100, 30);
            this.listBoolean.TabIndex = 13;
            this.listBoolean.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoolean_KeyDown);
            // 
            // lblInteger
            // 
            this.lblInteger.AutoSize = true;
            this.lblInteger.Location = new System.Drawing.Point(433, 12);
            this.lblInteger.Name = "lblInteger";
            this.lblInteger.Size = new System.Drawing.Size(36, 13);
            this.lblInteger.TabIndex = 2;
            this.lblInteger.Text = "Empty";
            // 
            // lblFloat
            // 
            this.lblFloat.AutoSize = true;
            this.lblFloat.Location = new System.Drawing.Point(433, 87);
            this.lblFloat.Name = "lblFloat";
            this.lblFloat.Size = new System.Drawing.Size(36, 13);
            this.lblFloat.TabIndex = 5;
            this.lblFloat.Text = "Empty";
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(433, 162);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(36, 13);
            this.lblString.TabIndex = 8;
            this.lblString.Text = "Empty";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(433, 237);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(36, 13);
            this.lblChar.TabIndex = 11;
            this.lblChar.Text = "Empty";
            // 
            // lblBoolean
            // 
            this.lblBoolean.AutoSize = true;
            this.lblBoolean.Location = new System.Drawing.Point(433, 312);
            this.lblBoolean.Name = "lblBoolean";
            this.lblBoolean.Size = new System.Drawing.Size(36, 13);
            this.lblBoolean.TabIndex = 14;
            this.lblBoolean.Text = "Empty";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearAll.Location = new System.Drawing.Point(12, 480);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(186, 50);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 5;
            this.btnExit.Location = new System.Drawing.Point(664, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 50);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playMusicToolStripMenuItem,
            this.stopMusicToolStripMenuItem,
            this.showClueToolStripMenuItem,
            this.revealSomethingHiddenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 92);
            // 
            // playMusicToolStripMenuItem
            // 
            this.playMusicToolStripMenuItem.Name = "playMusicToolStripMenuItem";
            this.playMusicToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.playMusicToolStripMenuItem.Text = "&Play Music";
            this.playMusicToolStripMenuItem.Click += new System.EventHandler(this.PlayMusicToolStripMenuItem_Click);
            // 
            // stopMusicToolStripMenuItem
            // 
            this.stopMusicToolStripMenuItem.Name = "stopMusicToolStripMenuItem";
            this.stopMusicToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.stopMusicToolStripMenuItem.Text = "&Stop Music";
            this.stopMusicToolStripMenuItem.Click += new System.EventHandler(this.StopMusicToolStripMenuItem_Click);
            // 
            // showClueToolStripMenuItem
            // 
            this.showClueToolStripMenuItem.Enabled = false;
            this.showClueToolStripMenuItem.Name = "showClueToolStripMenuItem";
            this.showClueToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.showClueToolStripMenuItem.Text = "Show &Clue";
            this.showClueToolStripMenuItem.Click += new System.EventHandler(this.showClueToolStripMenuItem_Click);
            // 
            // revealSomethingHiddenToolStripMenuItem
            // 
            this.revealSomethingHiddenToolStripMenuItem.Name = "revealSomethingHiddenToolStripMenuItem";
            this.revealSomethingHiddenToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.revealSomethingHiddenToolStripMenuItem.Text = "&Reveal Something &Hidden";
            this.revealSomethingHiddenToolStripMenuItem.Visible = false;
            this.revealSomethingHiddenToolStripMenuItem.Click += new System.EventHandler(this.revealSomethingHiddenToolStripMenuItem_Click);
            // 
            // btnClue
            // 
            this.btnClue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClue.Location = new System.Drawing.Point(338, 480);
            this.btnClue.Name = "btnClue";
            this.btnClue.Size = new System.Drawing.Size(186, 50);
            this.btnClue.TabIndex = 17;
            this.btnClue.Text = "Reset Clues";
            this.btnClue.UseVisualStyleBackColor = true;
            this.btnClue.Visible = false;
            this.btnClue.Click += new System.EventHandler(this.btnClue_Click);
            // 
            // txbFirstClue
            // 
            this.txbFirstClue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFirstClue.Location = new System.Drawing.Point(665, 9);
            this.txbFirstClue.Multiline = true;
            this.txbFirstClue.Name = "txbFirstClue";
            this.txbFirstClue.Size = new System.Drawing.Size(186, 333);
            this.txbFirstClue.TabIndex = 18;
            this.txbFirstClue.Text = "I might do something?";
            this.txbFirstClue.MouseHover += new System.EventHandler(this.txbFirstClue_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(863, 532);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblInteger);
            this.Controls.Add(this.lblFloat);
            this.Controls.Add(this.txtInteger);
            this.Controls.Add(this.btnInteger);
            this.Controls.Add(this.txtFloat);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.listBoolean);
            this.Controls.Add(this.txbFirstClue);
            this.Controls.Add(this.btnBoolean);
            this.Controls.Add(this.btnClue);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblBoolean);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.lblString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Basic Data Types";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInteger;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.Button btnBoolean;
        private System.Windows.Forms.TextBox txtInteger;
        private System.Windows.Forms.TextBox txtFloat;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.ListBox listBoolean;
        private System.Windows.Forms.Label lblInteger;
        private System.Windows.Forms.Label lblFloat;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label lblBoolean;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopMusicToolStripMenuItem;
        private System.Windows.Forms.Button btnClue;
        private System.Windows.Forms.ToolStripMenuItem showClueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revealSomethingHiddenToolStripMenuItem;
        private System.Windows.Forms.TextBox txbFirstClue;
    }
}

