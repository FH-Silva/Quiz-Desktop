namespace Quiz_atividade
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.btnVerifica = new System.Windows.Forms.Button();
            this.radioTres = new System.Windows.Forms.RadioButton();
            this.radioDois = new System.Windows.Forms.RadioButton();
            this.radioUm = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerifica
            // 
            this.btnVerifica.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVerifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerifica.Font = new System.Drawing.Font("Arial", 12F);
            this.btnVerifica.ForeColor = System.Drawing.Color.White;
            this.btnVerifica.Location = new System.Drawing.Point(247, 346);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(95, 36);
            this.btnVerifica.TabIndex = 65;
            this.btnVerifica.Text = "Confirmar";
            this.btnVerifica.UseVisualStyleBackColor = false;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // radioTres
            // 
            this.radioTres.AutoSize = true;
            this.radioTres.BackColor = System.Drawing.Color.Transparent;
            this.radioTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioTres.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTres.ForeColor = System.Drawing.Color.White;
            this.radioTres.Location = new System.Drawing.Point(118, 258);
            this.radioTres.Name = "radioTres";
            this.radioTres.Size = new System.Drawing.Size(101, 26);
            this.radioTres.TabIndex = 64;
            this.radioTres.Text = "Carbono";
            this.radioTres.UseVisualStyleBackColor = false;
            // 
            // radioDois
            // 
            this.radioDois.AutoSize = true;
            this.radioDois.BackColor = System.Drawing.Color.Transparent;
            this.radioDois.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioDois.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDois.ForeColor = System.Drawing.Color.White;
            this.radioDois.Location = new System.Drawing.Point(118, 226);
            this.radioDois.Name = "radioDois";
            this.radioDois.Size = new System.Drawing.Size(78, 26);
            this.radioDois.TabIndex = 63;
            this.radioDois.Text = "Césio";
            this.radioDois.UseVisualStyleBackColor = false;
            // 
            // radioUm
            // 
            this.radioUm.AutoSize = true;
            this.radioUm.BackColor = System.Drawing.Color.Transparent;
            this.radioUm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioUm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUm.ForeColor = System.Drawing.Color.White;
            this.radioUm.Location = new System.Drawing.Point(118, 194);
            this.radioUm.Name = "radioUm";
            this.radioUm.Size = new System.Drawing.Size(120, 26);
            this.radioUm.TabIndex = 62;
            this.radioUm.Text = "Hidrogênio";
            this.radioUm.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 54);
            this.label2.TabIndex = 61;
            this.label2.Text = "Qual é o elemento mais abundante \r\nno universo?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 60;
            this.label1.Text = "Química";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(581, 392);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.radioTres);
            this.Controls.Add(this.radioDois);
            this.Controls.Add(this.radioUm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.RadioButton radioTres;
        private System.Windows.Forms.RadioButton radioDois;
        private System.Windows.Forms.RadioButton radioUm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}