namespace Button
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.helloButton = new System.Windows.Forms.Button();
            this.goodbyeButton = new System.Windows.Forms.Button();
            this.theTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloButton.Location = new System.Drawing.Point(12, 12);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(104, 30);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "Bonjour !";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // goodbyeButton
            // 
            this.goodbyeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodbyeButton.Location = new System.Drawing.Point(12, 48);
            this.goodbyeButton.Name = "goodbyeButton";
            this.goodbyeButton.Size = new System.Drawing.Size(104, 30);
            this.goodbyeButton.TabIndex = 1;
            this.goodbyeButton.Text = "Au revoir !";
            this.goodbyeButton.UseVisualStyleBackColor = true;
            this.goodbyeButton.Visible = false;
            // 
            // theTimer
            // 
            this.theTimer.Interval = 20;
            this.theTimer.Tick += new System.EventHandler(this.theTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(967, 561);
            this.Controls.Add(this.goodbyeButton);
            this.Controls.Add(this.helloButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Button goodbyeButton;
        private System.Windows.Forms.Timer theTimer;
    }
}

