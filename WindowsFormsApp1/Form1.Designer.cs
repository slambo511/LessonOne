﻿
namespace WindowsFormsApp1
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
            this.SuspendLayout();
            // 
            // btnInteger
            // 
            this.btnInteger.Location = new System.Drawing.Point(23, 24);
            this.btnInteger.Name = "btnInteger";
            this.btnInteger.Size = new System.Drawing.Size(103, 23);
            this.btnInteger.TabIndex = 0;
            this.btnInteger.Text = "Add Integer";
            this.btnInteger.UseVisualStyleBackColor = true;
            this.btnInteger.Click += new System.EventHandler(this.btnInteger_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.Location = new System.Drawing.Point(23, 68);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(103, 23);
            this.btnFloat.TabIndex = 3;
            this.btnFloat.Text = "Add Float";
            this.btnFloat.UseVisualStyleBackColor = true;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(23, 115);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(103, 23);
            this.btnString.TabIndex = 6;
            this.btnString.Text = "Add String";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(23, 165);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(103, 23);
            this.btnChar.TabIndex = 9;
            this.btnChar.Text = "Add Char";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnBoolean
            // 
            this.btnBoolean.Location = new System.Drawing.Point(23, 216);
            this.btnBoolean.Name = "btnBoolean";
            this.btnBoolean.Size = new System.Drawing.Size(103, 23);
            this.btnBoolean.TabIndex = 12;
            this.btnBoolean.Text = "Add Boolean";
            this.btnBoolean.UseVisualStyleBackColor = true;
            this.btnBoolean.Click += new System.EventHandler(this.btnBoolean_Click);
            // 
            // txtInteger
            // 
            this.txtInteger.Location = new System.Drawing.Point(167, 26);
            this.txtInteger.Name = "txtInteger";
            this.txtInteger.Size = new System.Drawing.Size(100, 20);
            this.txtInteger.TabIndex = 1;
            this.txtInteger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInteger_KeyDown);
            // 
            // txtFloat
            // 
            this.txtFloat.Location = new System.Drawing.Point(167, 70);
            this.txtFloat.Name = "txtFloat";
            this.txtFloat.Size = new System.Drawing.Size(100, 20);
            this.txtFloat.TabIndex = 4;
            this.txtFloat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFloat_KeyDown);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(167, 117);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(100, 20);
            this.txtString.TabIndex = 7;
            this.txtString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtString_KeyDown);
            // 
            // txtChar
            // 
            this.txtChar.Location = new System.Drawing.Point(167, 167);
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(100, 20);
            this.txtChar.TabIndex = 10;
            this.txtChar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChar_KeyDown);
            // 
            // listBoolean
            // 
            this.listBoolean.FormattingEnabled = true;
            this.listBoolean.Items.AddRange(new object[] {
            "True",
            "False"});
            this.listBoolean.Location = new System.Drawing.Point(167, 216);
            this.listBoolean.Name = "listBoolean";
            this.listBoolean.Size = new System.Drawing.Size(100, 30);
            this.listBoolean.TabIndex = 13;
            this.listBoolean.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoolean_KeyDown);
            // 
            // lblInteger
            // 
            this.lblInteger.AutoSize = true;
            this.lblInteger.Location = new System.Drawing.Point(304, 29);
            this.lblInteger.Name = "lblInteger";
            this.lblInteger.Size = new System.Drawing.Size(36, 13);
            this.lblInteger.TabIndex = 2;
            this.lblInteger.Text = "Empty";
            // 
            // lblFloat
            // 
            this.lblFloat.AutoSize = true;
            this.lblFloat.Location = new System.Drawing.Point(304, 73);
            this.lblFloat.Name = "lblFloat";
            this.lblFloat.Size = new System.Drawing.Size(36, 13);
            this.lblFloat.TabIndex = 5;
            this.lblFloat.Text = "Empty";
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(304, 120);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(36, 13);
            this.lblString.TabIndex = 8;
            this.lblString.Text = "Empty";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(304, 170);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(36, 13);
            this.lblChar.TabIndex = 11;
            this.lblChar.Text = "Empty";
            // 
            // lblBoolean
            // 
            this.lblBoolean.AutoSize = true;
            this.lblBoolean.Location = new System.Drawing.Point(304, 221);
            this.lblBoolean.Name = "lblBoolean";
            this.lblBoolean.Size = new System.Drawing.Size(36, 13);
            this.lblBoolean.TabIndex = 14;
            this.lblBoolean.Text = "Empty";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(23, 304);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(103, 23);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(505, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 350);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblBoolean);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.lblFloat);
            this.Controls.Add(this.lblInteger);
            this.Controls.Add(this.listBoolean);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.txtFloat);
            this.Controls.Add(this.txtInteger);
            this.Controls.Add(this.btnBoolean);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnInteger);
            this.Name = "Form1";
            this.Text = "Basic Data Types";
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
    }
}

