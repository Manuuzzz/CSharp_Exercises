namespace Snake
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
            this.PanelGame = new System.Windows.Forms.Panel();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelGame
            // 
            this.PanelGame.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelGame.Location = new System.Drawing.Point(64, 32);
            this.PanelGame.Name = "PanelGame";
            this.PanelGame.Size = new System.Drawing.Size(535, 378);
            this.PanelGame.TabIndex = 0;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(636, 57);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(118, 37);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.PanelGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelGame;
        private System.Windows.Forms.Button ButtonStart;
    }
}

