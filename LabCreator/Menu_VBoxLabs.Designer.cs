namespace LabCreator
{
    partial class menuVBoxLabs
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
            this.vitualLabsButton = new System.Windows.Forms.Button();
            this.mvButton = new System.Windows.Forms.Button();
            this.networkAdminButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vitualLabsButton
            // 
            this.vitualLabsButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.vitualLabsButton.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vitualLabsButton.Location = new System.Drawing.Point(251, 300);
            this.vitualLabsButton.Name = "vitualLabsButton";
            this.vitualLabsButton.Size = new System.Drawing.Size(200, 70);
            this.vitualLabsButton.TabIndex = 0;
            this.vitualLabsButton.Text = "Laboratorio Virtual";
            this.vitualLabsButton.UseVisualStyleBackColor = false;
            // 
            // mvButton
            // 
            this.mvButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mvButton.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvButton.Location = new System.Drawing.Point(251, 175);
            this.mvButton.Name = "mvButton";
            this.mvButton.Size = new System.Drawing.Size(200, 70);
            this.mvButton.TabIndex = 1;
            this.mvButton.Text = "Máquina Virtual";
            this.mvButton.UseVisualStyleBackColor = false;
            // 
            // networkAdminButton
            // 
            this.networkAdminButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.networkAdminButton.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkAdminButton.Location = new System.Drawing.Point(251, 425);
            this.networkAdminButton.Name = "networkAdminButton";
            this.networkAdminButton.Size = new System.Drawing.Size(200, 70);
            this.networkAdminButton.TabIndex = 2;
            this.networkAdminButton.Text = "Administración de Redes";
            this.networkAdminButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(590, 626);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            // 
            // menuVBoxLabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(702, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.networkAdminButton);
            this.Controls.Add(this.mvButton);
            this.Controls.Add(this.vitualLabsButton);
            this.Name = "menuVBoxLabs";
            this.Text = "Menu (Nombre_Programa)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vitualLabsButton;
        private System.Windows.Forms.Button mvButton;
        private System.Windows.Forms.Button networkAdminButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}