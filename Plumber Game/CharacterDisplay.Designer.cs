
namespace Plumber_Game
{
    partial class CharacterDisplay
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
            this.pictureBoxHat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHat
            // 
            this.pictureBoxHat.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHat.BackgroundImage = global::Plumber_Game.Properties.Resources.hat_1;
            this.pictureBoxHat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHat.Location = new System.Drawing.Point(0, -45);
            this.pictureBoxHat.Name = "pictureBoxHat";
            this.pictureBoxHat.Size = new System.Drawing.Size(150, 200);
            this.pictureBoxHat.TabIndex = 1;
            this.pictureBoxHat.TabStop = false;
            this.pictureBoxHat.Click += new System.EventHandler(this.Character_Click);
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Plumber_Game.Properties.Resources.char_pos3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(199, 459);
            this.Controls.Add(this.pictureBoxHat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Character";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Character";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Character_FormClosed);
            this.Load += new System.EventHandler(this.Character_Load);
            this.Click += new System.EventHandler(this.Character_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHat;
    }
}