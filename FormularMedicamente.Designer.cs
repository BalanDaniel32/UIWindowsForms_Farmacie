﻿namespace UIWindowsForms_Farmacie
{
    partial class Formular
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
            this.gpbDiscipline = new System.Windows.Forms.GroupBox();
            this.ckbPCLP = new System.Windows.Forms.CheckBox();
            this.ckbPOO = new System.Windows.Forms.CheckBox();
            this.ckbPIU = new System.Windows.Forms.CheckBox();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.gpbProgrameStudiu = new System.Windows.Forms.GroupBox();
            this.rdbElectronica = new System.Windows.Forms.RadioButton();
            this.rdbCalculatoare = new System.Windows.Forms.RadioButton();
            this.rdbAutomatica = new System.Windows.Forms.RadioButton();
            this.lblSpecializare = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.gpbDiscipline.SuspendLayout();
            this.gpbProgrameStudiu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDiscipline
            // 
            this.gpbDiscipline.Controls.Add(this.ckbPCLP);
            this.gpbDiscipline.Controls.Add(this.ckbPOO);
            this.gpbDiscipline.Controls.Add(this.ckbPIU);
            this.gpbDiscipline.Location = new System.Drawing.Point(147, 244);
            this.gpbDiscipline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbDiscipline.Name = "gpbDiscipline";
            this.gpbDiscipline.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbDiscipline.Size = new System.Drawing.Size(308, 50);
            this.gpbDiscipline.TabIndex = 41;
            this.gpbDiscipline.TabStop = false;
            // 
            // ckbPCLP
            // 
            this.ckbPCLP.AutoSize = true;
            this.ckbPCLP.Location = new System.Drawing.Point(16, 14);
            this.ckbPCLP.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPCLP.Name = "ckbPCLP";
            this.ckbPCLP.Size = new System.Drawing.Size(73, 17);
            this.ckbPCLP.TabIndex = 20;
            this.ckbPCLP.Text = "Raceala";
            this.ckbPCLP.UseVisualStyleBackColor = true;
            this.ckbPCLP.CheckedChanged += new System.EventHandler(this.CkbDiscipline_CheckedChanged);
            // 
            // ckbPOO
            // 
            this.ckbPOO.AutoSize = true;
            this.ckbPOO.Location = new System.Drawing.Point(120, 15);
            this.ckbPOO.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPOO.Name = "ckbPOO";
            this.ckbPOO.Size = new System.Drawing.Size(60, 17);
            this.ckbPOO.TabIndex = 21;
            this.ckbPOO.Text = "Dureri";
            this.ckbPOO.UseVisualStyleBackColor = true;
            this.ckbPOO.CheckedChanged += new System.EventHandler(this.CkbDiscipline_CheckedChanged);
            // 
            // ckbPIU
            // 
            this.ckbPIU.AutoSize = true;
            this.ckbPIU.Location = new System.Drawing.Point(214, 14);
            this.ckbPIU.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPIU.Name = "ckbPIU";
            this.ckbPIU.Size = new System.Drawing.Size(78, 17);
            this.ckbPIU.TabIndex = 22;
            this.ckbPIU.Text = "Calmante";
            this.ckbPIU.UseVisualStyleBackColor = true;
            this.ckbPIU.CheckedChanged += new System.EventHandler(this.CkbDiscipline_CheckedChanged);
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(43, 245);
            this.lblDiscipline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(28, 13);
            this.lblDiscipline.TabIndex = 40;
            this.lblDiscipline.Text = "Boli";
            // 
            // gpbProgrameStudiu
            // 
            this.gpbProgrameStudiu.Controls.Add(this.rdbElectronica);
            this.gpbProgrameStudiu.Controls.Add(this.rdbCalculatoare);
            this.gpbProgrameStudiu.Controls.Add(this.rdbAutomatica);
            this.gpbProgrameStudiu.Location = new System.Drawing.Point(147, 113);
            this.gpbProgrameStudiu.Margin = new System.Windows.Forms.Padding(4);
            this.gpbProgrameStudiu.Name = "gpbProgrameStudiu";
            this.gpbProgrameStudiu.Padding = new System.Windows.Forms.Padding(4);
            this.gpbProgrameStudiu.Size = new System.Drawing.Size(277, 77);
            this.gpbProgrameStudiu.TabIndex = 39;
            this.gpbProgrameStudiu.TabStop = false;
            // 
            // rdbElectronica
            // 
            this.rdbElectronica.AutoSize = true;
            this.rdbElectronica.Location = new System.Drawing.Point(20, 39);
            this.rdbElectronica.Margin = new System.Windows.Forms.Padding(4);
            this.rdbElectronica.Name = "rdbElectronica";
            this.rdbElectronica.Size = new System.Drawing.Size(87, 17);
            this.rdbElectronica.TabIndex = 10;
            this.rdbElectronica.TabStop = true;
            this.rdbElectronica.Text = "Boli_Grave";
            this.rdbElectronica.UseVisualStyleBackColor = true;
            // 
            // rdbCalculatoare
            // 
            this.rdbCalculatoare.AutoSize = true;
            this.rdbCalculatoare.Location = new System.Drawing.Point(20, 11);
            this.rdbCalculatoare.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCalculatoare.Name = "rdbCalculatoare";
            this.rdbCalculatoare.Size = new System.Drawing.Size(72, 17);
            this.rdbCalculatoare.TabIndex = 8;
            this.rdbCalculatoare.TabStop = true;
            this.rdbCalculatoare.Text = "Raceala";
            this.rdbCalculatoare.UseVisualStyleBackColor = true;
            this.rdbCalculatoare.CheckedChanged += new System.EventHandler(this.rdbCalculatoare_CheckedChanged);
            // 
            // rdbAutomatica
            // 
            this.rdbAutomatica.AutoSize = true;
            this.rdbAutomatica.Location = new System.Drawing.Point(140, 11);
            this.rdbAutomatica.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAutomatica.Name = "rdbAutomatica";
            this.rdbAutomatica.Size = new System.Drawing.Size(59, 17);
            this.rdbAutomatica.TabIndex = 9;
            this.rdbAutomatica.TabStop = true;
            this.rdbAutomatica.Text = "Dureri";
            this.rdbAutomatica.UseVisualStyleBackColor = true;
            // 
            // lblSpecializare
            // 
            this.lblSpecializare.AutoSize = true;
            this.lblSpecializare.Location = new System.Drawing.Point(43, 127);
            this.lblSpecializare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecializare.Name = "lblSpecializare";
            this.lblSpecializare.Size = new System.Drawing.Size(92, 13);
            this.lblSpecializare.TabIndex = 38;
            this.lblSpecializare.Text = "Recomandarea";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(135, 449);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 36;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(287, 369);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(139, 28);
            this.btnAfiseaza.TabIndex = 34;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.BtnAfiseaza_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(147, 317);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(277, 20);
            this.txtNote.TabIndex = 33;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(147, 71);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(277, 20);
            this.txtPrenume.TabIndex = 32;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(147, 36);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(277, 20);
            this.txtNume.TabIndex = 31;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(147, 369);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(124, 28);
            this.btnAdauga.TabIndex = 30;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.BtnAdauga_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(43, 317);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 29;
            this.lblNote.Text = "Pret";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(43, 71);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(68, 13);
            this.lblPrenume.TabIndex = 28;
            this.lblPrenume.Text = "Afectiunea";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(24, 36);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(111, 13);
            this.lblNume.TabIndex = 27;
            this.lblNume.Text = "Nume Medicament";
            this.lblNume.Click += new System.EventHandler(this.lblNume_Click);
            // 
            // FormularMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.gpbDiscipline);
            this.Controls.Add(this.lblDiscipline);
            this.Controls.Add(this.gpbProgrameStudiu);
            this.Controls.Add(this.lblSpecializare);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularMedicament";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbDiscipline.ResumeLayout(false);
            this.gpbDiscipline.PerformLayout();
            this.gpbProgrameStudiu.ResumeLayout(false);
            this.gpbProgrameStudiu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDiscipline;
        private System.Windows.Forms.CheckBox ckbPCLP;
        private System.Windows.Forms.CheckBox ckbPOO;
        private System.Windows.Forms.CheckBox ckbPIU;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.GroupBox gpbProgrameStudiu;
        private System.Windows.Forms.RadioButton rdbElectronica;
        private System.Windows.Forms.RadioButton rdbCalculatoare;
        private System.Windows.Forms.RadioButton rdbAutomatica;
        private System.Windows.Forms.Label lblSpecializare;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
    }
}