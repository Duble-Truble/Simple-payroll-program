namespace Edit
{
    partial class VpisUr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VpisUr));
            this.Stur = new System.Windows.Forms.TextBox();
            this.IzberiPodjetje = new System.Windows.Forms.ComboBox();
            this.IzberiZaposlenega = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ShraniU = new System.Windows.Forms.Button();
            this.IzberiMesec = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Prazniki = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Boleznine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fondUr = new System.Windows.Forms.TextBox();
            this.fond = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Stur
            // 
            this.Stur.Location = new System.Drawing.Point(137, 83);
            this.Stur.Name = "Stur";
            this.Stur.Size = new System.Drawing.Size(81, 20);
            this.Stur.TabIndex = 0;
            // 
            // IzberiPodjetje
            // 
            this.IzberiPodjetje.FormattingEnabled = true;
            this.IzberiPodjetje.Location = new System.Drawing.Point(323, 97);
            this.IzberiPodjetje.Name = "IzberiPodjetje";
            this.IzberiPodjetje.Size = new System.Drawing.Size(121, 21);
            this.IzberiPodjetje.TabIndex = 1;
            this.IzberiPodjetje.SelectedIndexChanged += new System.EventHandler(this.IzberiPodjetjeV_SelectedIndexChanged);
            // 
            // IzberiZaposlenega
            // 
            this.IzberiZaposlenega.FormattingEnabled = true;
            this.IzberiZaposlenega.Location = new System.Drawing.Point(323, 151);
            this.IzberiZaposlenega.Name = "IzberiZaposlenega";
            this.IzberiZaposlenega.Size = new System.Drawing.Size(121, 21);
            this.IzberiZaposlenega.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 36;
            this.label8.Text = "Vnesi število ur:";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(18, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(638, 3);
            this.label13.TabIndex = 42;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(283, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(3, 160);
            this.label14.TabIndex = 45;
            // 
            // ShraniU
            // 
            this.ShraniU.BackColor = System.Drawing.Color.LavenderBlush;
            this.ShraniU.Location = new System.Drawing.Point(271, 234);
            this.ShraniU.Name = "ShraniU";
            this.ShraniU.Size = new System.Drawing.Size(103, 32);
            this.ShraniU.TabIndex = 46;
            this.ShraniU.Text = "Shrani:";
            this.ShraniU.UseVisualStyleBackColor = false;
            this.ShraniU.Click += new System.EventHandler(this.ShraniU_Click);
            // 
            // IzberiMesec
            // 
            this.IzberiMesec.FormattingEnabled = true;
            this.IzberiMesec.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "Marec",
            "April",
            "Maj",
            "Junij",
            "Julij",
            "August",
            "September",
            "Oktober",
            "November",
            "December"});
            this.IzberiMesec.Location = new System.Drawing.Point(508, 97);
            this.IzberiMesec.Name = "IzberiMesec";
            this.IzberiMesec.Size = new System.Drawing.Size(121, 21);
            this.IzberiMesec.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(338, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "Izberi podjetje:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(327, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "Izberi zaposlenega:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(490, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(166, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "Časovno obdobje za mesec:";
            // 
            // Prazniki
            // 
            this.Prazniki.Location = new System.Drawing.Point(137, 129);
            this.Prazniki.Name = "Prazniki";
            this.Prazniki.Size = new System.Drawing.Size(81, 20);
            this.Prazniki.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Prazniki:";
            // 
            // Boleznine
            // 
            this.Boleznine.Location = new System.Drawing.Point(137, 173);
            this.Boleznine.Name = "Boleznine";
            this.Boleznine.Size = new System.Drawing.Size(81, 20);
            this.Boleznine.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Boleznine:";
            // 
            // fondUr
            // 
            this.fondUr.Location = new System.Drawing.Point(508, 152);
            this.fondUr.Name = "fondUr";
            this.fondUr.Size = new System.Drawing.Size(121, 20);
            this.fondUr.TabIndex = 59;
            // 
            // fond
            // 
            this.fond.AutoSize = true;
            this.fond.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fond.Location = new System.Drawing.Point(512, 136);
            this.fond.Name = "fond";
            this.fond.Size = new System.Drawing.Size(111, 13);
            this.fond.TabIndex = 60;
            this.fond.Text = "Fond ur za mesec:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Za tekoči mesec:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(455, 260);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(210, 13);
            this.label31.TabIndex = 184;
            this.label31.Text = "© Edit  Vse pravice pridržane. 2020";
            // 
            // VpisUr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 278);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fond);
            this.Controls.Add(this.fondUr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Boleznine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prazniki);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.IzberiMesec);
            this.Controls.Add(this.ShraniU);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IzberiZaposlenega);
            this.Controls.Add(this.IzberiPodjetje);
            this.Controls.Add(this.Stur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VpisUr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vpis ur:";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VpisUr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Stur;
        private System.Windows.Forms.ComboBox IzberiPodjetje;
        private System.Windows.Forms.ComboBox IzberiZaposlenega;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ShraniU;
        private System.Windows.Forms.ComboBox IzberiMesec;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Prazniki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Boleznine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fondUr;
        private System.Windows.Forms.Label fond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label31;
    }
}