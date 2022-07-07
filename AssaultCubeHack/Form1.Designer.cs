namespace AssaultCubeHack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHealth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBaseAddresss = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAmmo = new System.Windows.Forms.TextBox();
            this.btnHealthActive = new System.Windows.Forms.Button();
            this.btnAmmoActive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health:";
            // 
            // textBoxHealth
            // 
            this.textBoxHealth.Location = new System.Drawing.Point(63, 6);
            this.textBoxHealth.Name = "textBoxHealth";
            this.textBoxHealth.Size = new System.Drawing.Size(100, 23);
            this.textBoxHealth.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Config:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Base Address: ";
            // 
            // labelBaseAddresss
            // 
            this.labelBaseAddresss.AutoSize = true;
            this.labelBaseAddresss.Location = new System.Drawing.Point(107, 250);
            this.labelBaseAddresss.Name = "labelBaseAddresss";
            this.labelBaseAddresss.Size = new System.Drawing.Size(13, 15);
            this.labelBaseAddresss.TabIndex = 5;
            this.labelBaseAddresss.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ammo:";
            // 
            // textBoxAmmo
            // 
            this.textBoxAmmo.Location = new System.Drawing.Point(63, 30);
            this.textBoxAmmo.Name = "textBoxAmmo";
            this.textBoxAmmo.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmmo.TabIndex = 1;
            // 
            // btnHealthActive
            // 
            this.btnHealthActive.Location = new System.Drawing.Point(169, 6);
            this.btnHealthActive.Name = "btnHealthActive";
            this.btnHealthActive.Size = new System.Drawing.Size(75, 23);
            this.btnHealthActive.TabIndex = 6;
            this.btnHealthActive.Text = "Active";
            this.btnHealthActive.UseVisualStyleBackColor = true;
            this.btnHealthActive.Click += new System.EventHandler(this.healthActive_Click);
            // 
            // btnAmmoActive
            // 
            this.btnAmmoActive.Location = new System.Drawing.Point(169, 30);
            this.btnAmmoActive.Name = "btnAmmoActive";
            this.btnAmmoActive.Size = new System.Drawing.Size(75, 23);
            this.btnAmmoActive.TabIndex = 6;
            this.btnAmmoActive.Text = "Active";
            this.btnAmmoActive.UseVisualStyleBackColor = true;
            this.btnAmmoActive.Click += new System.EventHandler(this.btnAmmoActive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAmmoActive);
            this.Controls.Add(this.btnHealthActive);
            this.Controls.Add(this.labelBaseAddresss);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAmmo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHealth);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxHealth;
        private Label label2;
        private Label label3;
        private Label labelBaseAddresss;
        private Label label4;
        private TextBox textBoxAmmo;
        private Button btnHealthActive;
        private Button btnAmmoActive;
    }
}