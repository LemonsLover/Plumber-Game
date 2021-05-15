
namespace Plumber_Game
{
    partial class WinScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinScreen));
            this.labelWin = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonLevelSelect = new System.Windows.Forms.Button();
            this.buttonNextLevel = new System.Windows.Forms.Button();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.labelRandomly = new System.Windows.Forms.Label();
            this.labelCompGame = new System.Windows.Forms.Label();
            this.labelAmountOfConections = new System.Windows.Forms.Label();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWin
            // 
            this.labelWin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.Location = new System.Drawing.Point(48, 34);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(235, 33);
            this.labelWin.TabIndex = 0;
            this.labelWin.Text = "ТЫ ВЫИГРАЛ !";
            this.labelWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWin.Visible = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(39, 213);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(260, 45);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "В Меню";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonLevelSelect
            // 
            this.buttonLevelSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonLevelSelect.Location = new System.Drawing.Point(39, 162);
            this.buttonLevelSelect.Name = "buttonLevelSelect";
            this.buttonLevelSelect.Size = new System.Drawing.Size(260, 45);
            this.buttonLevelSelect.TabIndex = 2;
            this.buttonLevelSelect.Text = "ВЫБОР УРОВНЯ";
            this.buttonLevelSelect.UseVisualStyleBackColor = true;
            this.buttonLevelSelect.Click += new System.EventHandler(this.buttonLevelSelect_Click);
            // 
            // buttonNextLevel
            // 
            this.buttonNextLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonNextLevel.Location = new System.Drawing.Point(39, 100);
            this.buttonNextLevel.Name = "buttonNextLevel";
            this.buttonNextLevel.Size = new System.Drawing.Size(260, 56);
            this.buttonNextLevel.TabIndex = 3;
            this.buttonNextLevel.Text = "СЛЕДУЮЩИЙ УРОВЕНЬ";
            this.buttonNextLevel.UseVisualStyleBackColor = true;
            this.buttonNextLevel.Visible = false;
            this.buttonNextLevel.Click += new System.EventHandler(this.buttonNextLevel_Click);
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.Location = new System.Drawing.Point(36, 84);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(123, 13);
            this.labelTimeLeft.TabIndex = 4;
            this.labelTimeLeft.Text = "Оставшаеся время: 0с";
            // 
            // labelRandomly
            // 
            this.labelRandomly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRandomly.AutoSize = true;
            this.labelRandomly.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandomly.Location = new System.Drawing.Point(48, 34);
            this.labelRandomly.Name = "labelRandomly";
            this.labelRandomly.Size = new System.Drawing.Size(235, 33);
            this.labelRandomly.TabIndex = 5;
            this.labelRandomly.Text = "ТЫ ВЫИГРАЛ !";
            this.labelRandomly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRandomly.Visible = false;
            // 
            // labelCompGame
            // 
            this.labelCompGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCompGame.AutoSize = true;
            this.labelCompGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompGame.Location = new System.Drawing.Point(37, 34);
            this.labelCompGame.Name = "labelCompGame";
            this.labelCompGame.Size = new System.Drawing.Size(264, 33);
            this.labelCompGame.TabIndex = 6;
            this.labelCompGame.Text = "Ты прошел игру !";
            this.labelCompGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCompGame.Visible = false;
            // 
            // labelAmountOfConections
            // 
            this.labelAmountOfConections.AutoSize = true;
            this.labelAmountOfConections.Location = new System.Drawing.Point(181, 84);
            this.labelAmountOfConections.Name = "labelAmountOfConections";
            this.labelAmountOfConections.Size = new System.Drawing.Size(114, 13);
            this.labelAmountOfConections.TabIndex = 7;
            this.labelAmountOfConections.Text = "Длина соединеия: 0т";
            // 
            // buttonAgain
            // 
            this.buttonAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonAgain.Location = new System.Drawing.Point(39, 100);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(260, 56);
            this.buttonAgain.TabIndex = 8;
            this.buttonAgain.Text = "Ещё разок";
            this.buttonAgain.UseVisualStyleBackColor = true;
            this.buttonAgain.Visible = false;
            this.buttonAgain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAgain_MouseClick);
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.buttonAgain);
            this.Controls.Add(this.labelAmountOfConections);
            this.Controls.Add(this.labelCompGame);
            this.Controls.Add(this.labelRandomly);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.buttonNextLevel);
            this.Controls.Add(this.buttonLevelSelect);
            this.Controls.Add(this.buttonMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "WinScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПОБЕДА !";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinScreen_FormClosed);
            this.Load += new System.EventHandler(this.WinScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonLevelSelect;
        private System.Windows.Forms.Button buttonNextLevel;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Label labelRandomly;
        private System.Windows.Forms.Label labelCompGame;
        private System.Windows.Forms.Label labelAmountOfConections;
        private System.Windows.Forms.Button buttonAgain;
    }
}