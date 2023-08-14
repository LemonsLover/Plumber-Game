
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
            this.buttonLevelSelect = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLevelCreation = new System.Windows.Forms.Button();
            this.buttonClearProgress = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "ИГРАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLevelSelect
            // 
            this.buttonLevelSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevelSelect.Location = new System.Drawing.Point(12, 179);
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
            this.buttonExit.Location = new System.Drawing.Point(12, 271);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(276, 40);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "ВЫХОД";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button3_Click);
            this.buttonExit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonExit_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "by Yehor Ovseukov (2021)";
            this.label1.Click += new System.EventHandler(this.labelMenu_Click);
            // 
            // buttonLevelCreation
            // 
            this.buttonLevelCreation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevelCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevelCreation.Location = new System.Drawing.Point(12, 225);
            this.buttonLevelCreation.Name = "buttonLevelCreation";
            this.buttonLevelCreation.Size = new System.Drawing.Size(276, 40);
            this.buttonLevelCreation.TabIndex = 5;
            this.buttonLevelCreation.Text = "СОЗДАНИЕ УРОВНЯ";
            this.buttonLevelCreation.UseVisualStyleBackColor = true;
            this.buttonLevelCreation.Click += new System.EventHandler(this.buttonLevelCreation_Click);
            // 
            // buttonClearProgress
            // 
            this.buttonClearProgress.Location = new System.Drawing.Point(12, 317);
            this.buttonClearProgress.Name = "buttonClearProgress";
            this.buttonClearProgress.Size = new System.Drawing.Size(276, 27);
            this.buttonClearProgress.TabIndex = 6;
            this.buttonClearProgress.Text = "Очистить прогресс";
            this.buttonClearProgress.UseVisualStyleBackColor = true;
            this.buttonClearProgress.Visible = false;
            this.buttonClearProgress.Click += new System.EventHandler(this.buttonClearProgress_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 88);
            this.label2.TabIndex = 7;
            this.label2.Text = "PLAMBER\r\nGAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClearProgress);
            this.Controls.Add(this.buttonLevelCreation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLevelSelect);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 350);
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
        private System.Windows.Forms.Button buttonLevelSelect;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLevelCreation;
        private System.Windows.Forms.Button buttonClearProgress;
        private System.Windows.Forms.Label label2;
    }
}