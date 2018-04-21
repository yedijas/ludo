namespace Ludo.Forms
{
    partial class StartMenu
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
            this.btnStartGameOpts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.cmbPlayer1 = new System.Windows.Forms.ComboBox();
            this.cmbPlayer2 = new System.Windows.Forms.ComboBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.cmbPlayer3 = new System.Windows.Forms.ComboBox();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.cmbPlayer4 = new System.Windows.Forms.ComboBox();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartGameOpts
            // 
            this.btnStartGameOpts.Location = new System.Drawing.Point(12, 12);
            this.btnStartGameOpts.Name = "btnStartGameOpts";
            this.btnStartGameOpts.Size = new System.Drawing.Size(260, 23);
            this.btnStartGameOpts.TabIndex = 0;
            this.btnStartGameOpts.Text = "Start New Game";
            this.btnStartGameOpts.UseVisualStyleBackColor = true;
            this.btnStartGameOpts.Click += new System.EventHandler(this.btnStartGameOpts_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 156);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(260, 23);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(12, 42);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(44, 13);
            this.lblPlayer1.TabIndex = 3;
            this.lblPlayer1.Text = "player 1";
            // 
            // cmbPlayer1
            // 
            this.cmbPlayer1.FormattingEnabled = true;
            this.cmbPlayer1.Location = new System.Drawing.Point(12, 58);
            this.cmbPlayer1.Name = "cmbPlayer1";
            this.cmbPlayer1.Size = new System.Drawing.Size(121, 21);
            this.cmbPlayer1.TabIndex = 4;
            // 
            // cmbPlayer2
            // 
            this.cmbPlayer2.FormattingEnabled = true;
            this.cmbPlayer2.Location = new System.Drawing.Point(151, 58);
            this.cmbPlayer2.Name = "cmbPlayer2";
            this.cmbPlayer2.Size = new System.Drawing.Size(121, 21);
            this.cmbPlayer2.TabIndex = 6;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(151, 42);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(44, 13);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "player 2";
            // 
            // cmbPlayer3
            // 
            this.cmbPlayer3.FormattingEnabled = true;
            this.cmbPlayer3.Location = new System.Drawing.Point(12, 100);
            this.cmbPlayer3.Name = "cmbPlayer3";
            this.cmbPlayer3.Size = new System.Drawing.Size(121, 21);
            this.cmbPlayer3.TabIndex = 8;
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Location = new System.Drawing.Point(12, 84);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(44, 13);
            this.lblPlayer3.TabIndex = 7;
            this.lblPlayer3.Text = "player 3";
            // 
            // cmbPlayer4
            // 
            this.cmbPlayer4.FormattingEnabled = true;
            this.cmbPlayer4.Location = new System.Drawing.Point(151, 100);
            this.cmbPlayer4.Name = "cmbPlayer4";
            this.cmbPlayer4.Size = new System.Drawing.Size(121, 21);
            this.cmbPlayer4.TabIndex = 10;
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Location = new System.Drawing.Point(151, 84);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(44, 13);
            this.lblPlayer4.TabIndex = 9;
            this.lblPlayer4.Text = "player 4";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 127);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(121, 23);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(151, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cmbPlayer4);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.cmbPlayer3);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.cmbPlayer2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.cmbPlayer1);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartGameOpts);
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ludo Game";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGameOpts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.ComboBox cmbPlayer1;
        private System.Windows.Forms.ComboBox cmbPlayer2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.ComboBox cmbPlayer3;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.ComboBox cmbPlayer4;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnCancel;
    }
}