
namespace TicTacToeWinFormsApp
{
    partial class Welcome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.theOPlayer = new System.Windows.Forms.RadioButton();
            this.theXPlayer = new System.Windows.Forms.RadioButton();
            this.playButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicTacToeWinFormsApp.Properties.Resources.tic_tac_toe;
            this.pictureBox1.Location = new System.Drawing.Point(4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 544);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // theOPlayer
            // 
            this.theOPlayer.AutoSize = true;
            this.theOPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.theOPlayer.Location = new System.Drawing.Point(22, 106);
            this.theOPlayer.Name = "theOPlayer";
            this.theOPlayer.Size = new System.Drawing.Size(43, 28);
            this.theOPlayer.TabIndex = 1;
            this.theOPlayer.TabStop = true;
            this.theOPlayer.Text = "O";
            this.theOPlayer.UseVisualStyleBackColor = false;
            // 
            // theXPlayer
            // 
            this.theXPlayer.AutoSize = true;
            this.theXPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.theXPlayer.Location = new System.Drawing.Point(22, 30);
            this.theXPlayer.Name = "theXPlayer";
            this.theXPlayer.Size = new System.Drawing.Size(42, 28);
            this.theXPlayer.TabIndex = 2;
            this.theXPlayer.TabStop = true;
            this.theXPlayer.Text = "X";
            this.theXPlayer.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(572, 333);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(196, 108);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "PLAY!!!";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.theXPlayer);
            this.groupBox1.Controls.Add(this.theOPlayer);
            this.groupBox1.Location = new System.Drawing.Point(627, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton theOPlayer;
        private System.Windows.Forms.RadioButton theXPlayer;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}