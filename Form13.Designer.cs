namespace Quiz_atividade
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.listRank = new System.Windows.Forms.ListBox();
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listRank
            // 
            this.listRank.BackColor = System.Drawing.SystemColors.Window;
            this.listRank.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listRank.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRank.ForeColor = System.Drawing.Color.Black;
            this.listRank.FormattingEnabled = true;
            this.listRank.ItemHeight = 17;
            this.listRank.Location = new System.Drawing.Point(54, 122);
            this.listRank.Name = "listRank";
            this.listRank.Size = new System.Drawing.Size(455, 191);
            this.listRank.TabIndex = 0;
            this.listRank.Tag = "";
            this.listRank.SelectedIndexChanged += new System.EventHandler(this.listRank_SelectedIndexChanged);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.Black;
            this.voltar.Location = new System.Drawing.Point(494, 365);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 13;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(581, 400);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.listRank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form13";
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRank;
        private System.Windows.Forms.Button voltar;
    }
}