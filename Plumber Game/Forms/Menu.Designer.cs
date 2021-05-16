
namespace Plumber_Game
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonLevelSelect = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLevelCreation = new System.Windows.Forms.Button();
            this.buttonClearProgress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "ИГРАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(98, 29);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(105, 31);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "МЕНЮ";
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            // 
            // buttonLevelSelect
            // 
            this.buttonLevelSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevelSelect.Location = new System.Drawing.Point(12, 119);
            this.buttonLevelSelect.Name = "buttonLevelSelect";
            this.buttonLevelSelect.Size = new System.Drawing.Size(276, 40);
            this.buttonLevelSelect.TabIndex = 2;
            this.buttonLevelSelect.Text = "ВЫБОР УРОВНЯ";
            this.buttonLevelSelect.UseVisualStyleBackColor = true;
            this.buttonLevelSelect.Click += new System.EventHandler(this.buttonLevelSelect_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(12, 211);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(276, 40);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "ВЫХОД";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "by Yehor Ovseukov";
            // 
            // buttonLevelCreation
            // 
            this.buttonLevelCreation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevelCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevelCreation.Location = new System.Drawing.Point(12, 165);
            this.buttonLevelCreation.Name = "buttonLevelCreation";
            this.buttonLevelCreation.Size = new System.Drawing.Size(276, 40);
            this.buttonLevelCreation.TabIndex = 5;
            this.buttonLevelCreation.Text = "СОЗДАНИЕ УРОВНЯ";
            this.buttonLevelCreation.UseVisualStyleBackColor = true;
            this.buttonLevelCreation.Click += new System.EventHandler(this.buttonLevelCreation_Click);
            // 
            // buttonClearProgress
            // 
            this.buttonClearProgress.Location = new System.Drawing.Point(209, 2);
            this.buttonClearProgress.Name = "buttonClearProgress";
            this.buttonClearProgress.Size = new System.Drawing.Size(89, 35);
            this.buttonClearProgress.TabIndex = 6;
            this.buttonClearProgress.Text = "Очистить прогресс";
            this.buttonClearProgress.UseVisualStyleBackColor = true;
            this.buttonClearProgress.Visible = false;
            this.buttonClearProgress.Click += new System.EventHandler(this.buttonClearProgress_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.buttonClearProgress);
            this.Controls.Add(this.buttonLevelCreation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLevelSelect);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLUMBER GAME";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonLevelSelect;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLevelCreation;
        private System.Windows.Forms.Button buttonClearProgress;
    }
}