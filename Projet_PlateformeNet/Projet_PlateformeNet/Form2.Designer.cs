namespace Projet_PlateformeNet
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_password = new System.Windows.Forms.MaskedTextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Création d\'un profil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login : ";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(514, 131);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(129, 22);
            this.textBox_login.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password : ";
            // 
            // maskedTextBox_password
            // 
            this.maskedTextBox_password.Location = new System.Drawing.Point(514, 232);
            this.maskedTextBox_password.Name = "maskedTextBox_password";
            this.maskedTextBox_password.Size = new System.Drawing.Size(129, 22);
            this.maskedTextBox_password.TabIndex = 4;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(672, 378);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(97, 37);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Ajouter";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(49, 378);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(97, 37);
            this.button_quit.TabIndex = 6;
            this.button_quit.Text = "Quitter";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.maskedTextBox_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_password;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_quit;
    }
}