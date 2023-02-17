namespace GESTION__MIFA.DF
{
    partial class Formconnexion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxmtp = new System.Windows.Forms.TextBox();
            this.textBoxutilisateur = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBoxmtp);
            this.panel1.Controls.Add(this.textBoxutilisateur);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 398);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Image = global::GESTION__MIFA.Properties.Resources.fermer_30;
            this.button2.Location = new System.Drawing.Point(340, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 31);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxmtp
            // 
            this.textBoxmtp.BackColor = System.Drawing.Color.Maroon;
            this.textBoxmtp.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmtp.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxmtp.Location = new System.Drawing.Point(56, 221);
            this.textBoxmtp.Multiline = true;
            this.textBoxmtp.Name = "textBoxmtp";
            this.textBoxmtp.Size = new System.Drawing.Size(288, 49);
            this.textBoxmtp.TabIndex = 3;
            this.textBoxmtp.Text = "Mot de Passe\r\n";
            this.textBoxmtp.TextChanged += new System.EventHandler(this.textBoxmtp_TextChanged);
            this.textBoxmtp.Enter += new System.EventHandler(this.textBoxmtp_Enter);
            // 
            // textBoxutilisateur
            // 
            this.textBoxutilisateur.BackColor = System.Drawing.Color.Maroon;
            this.textBoxutilisateur.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxutilisateur.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxutilisateur.Location = new System.Drawing.Point(56, 134);
            this.textBoxutilisateur.Multiline = true;
            this.textBoxutilisateur.Name = "textBoxutilisateur";
            this.textBoxutilisateur.Size = new System.Drawing.Size(288, 49);
            this.textBoxutilisateur.TabIndex = 2;
            this.textBoxutilisateur.Text = "Nom D\'Utilisateur";
            this.textBoxutilisateur.TextChanged += new System.EventHandler(this.textBoxutilisateur_TextChanged);
            this.textBoxutilisateur.Enter += new System.EventHandler(this.textBoxutilisateur_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(111, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(85, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connexion";
            // 
            // Formconnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 398);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formconnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formconnexion";
            this.Load += new System.EventHandler(this.Formconnexion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxmtp;
        private System.Windows.Forms.TextBox textBoxutilisateur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}