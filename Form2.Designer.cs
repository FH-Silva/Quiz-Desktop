﻿namespace Quiz_atividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioUm = new System.Windows.Forms.RadioButton();
            this.radioDois = new System.Windows.Forms.RadioButton();
            this.radioTres = new System.Windows.Forms.RadioButton();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geografia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qual é o maior oceâno do mundo?";
            // 
            // radioUm
            // 
            this.radioUm.AutoSize = true;
            this.radioUm.BackColor = System.Drawing.Color.Transparent;
            this.radioUm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioUm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUm.ForeColor = System.Drawing.Color.White;
            this.radioUm.Location = new System.Drawing.Point(105, 170);
            this.radioUm.Name = "radioUm";
            this.radioUm.Size = new System.Drawing.Size(170, 26);
            this.radioUm.TabIndex = 20;
            this.radioUm.Text = "Oceâno Pacífico";
            this.radioUm.UseVisualStyleBackColor = false;
            // 
            // radioDois
            // 
            this.radioDois.AutoSize = true;
            this.radioDois.BackColor = System.Drawing.Color.Transparent;
            this.radioDois.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioDois.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDois.ForeColor = System.Drawing.Color.White;
            this.radioDois.Location = new System.Drawing.Point(105, 202);
            this.radioDois.Name = "radioDois";
            this.radioDois.Size = new System.Drawing.Size(152, 26);
            this.radioDois.TabIndex = 20;
            this.radioDois.Text = "Oceâno Índico";
            this.radioDois.UseVisualStyleBackColor = false;
            // 
            // radioTres
            // 
            this.radioTres.AutoSize = true;
            this.radioTres.BackColor = System.Drawing.Color.Transparent;
            this.radioTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioTres.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTres.ForeColor = System.Drawing.Color.White;
            this.radioTres.Location = new System.Drawing.Point(105, 234);
            this.radioTres.Name = "radioTres";
            this.radioTres.Size = new System.Drawing.Size(171, 26);
            this.radioTres.TabIndex = 20;
            this.radioTres.Text = "Oceâno Atlântico";
            this.radioTres.UseVisualStyleBackColor = false;
            // 
            // btnVerifica
            // 
            this.btnVerifica.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVerifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerifica.Font = new System.Drawing.Font("Arial", 12F);
            this.btnVerifica.ForeColor = System.Drawing.Color.White;
            this.btnVerifica.Location = new System.Drawing.Point(251, 344);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(95, 36);
            this.btnVerifica.TabIndex = 1;
            this.btnVerifica.Text = "Confirmar";
            this.btnVerifica.UseVisualStyleBackColor = false;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // Form2
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
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioUm;
        private System.Windows.Forms.RadioButton radioDois;
        private System.Windows.Forms.RadioButton radioTres;
        private System.Windows.Forms.Button btnVerifica;
    }
}