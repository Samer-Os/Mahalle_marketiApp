﻿namespace Mahalle_marketi.UserControls
{
    partial class UC_kayitlar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.PanelKayitlar = new System.Windows.Forms.Panel();
            this.labelKayitlar = new System.Windows.Forms.Label();
            this.btn_satisGecmisi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_borc_arama = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_kayitlar = new System.Windows.Forms.Panel();
            this.PanelKayitlar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelKayitlar
            // 
            this.PanelKayitlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelKayitlar.Controls.Add(this.labelKayitlar);
            this.PanelKayitlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelKayitlar.Location = new System.Drawing.Point(0, 0);
            this.PanelKayitlar.Name = "PanelKayitlar";
            this.PanelKayitlar.Size = new System.Drawing.Size(654, 110);
            this.PanelKayitlar.TabIndex = 4;
            // 
            // labelKayitlar
            // 
            this.labelKayitlar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKayitlar.AutoSize = true;
            this.labelKayitlar.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKayitlar.ForeColor = System.Drawing.Color.White;
            this.labelKayitlar.Location = new System.Drawing.Point(253, 31);
            this.labelKayitlar.Name = "labelKayitlar";
            this.labelKayitlar.Size = new System.Drawing.Size(149, 49);
            this.labelKayitlar.TabIndex = 0;
            this.labelKayitlar.Text = "Kayıtlar";
            // 
            // btn_satisGecmisi
            // 
            this.btn_satisGecmisi.BackColor = System.Drawing.Color.White;
            this.btn_satisGecmisi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_satisGecmisi.Checked = true;
            this.btn_satisGecmisi.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.btn_satisGecmisi.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_satisGecmisi.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btn_satisGecmisi.CustomizableEdges = customizableEdges1;
            this.btn_satisGecmisi.FillColor = System.Drawing.Color.Empty;
            this.btn_satisGecmisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_satisGecmisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_satisGecmisi.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_satisGecmisi.Location = new System.Drawing.Point(5, 0);
            this.btn_satisGecmisi.Name = "btn_satisGecmisi";
            this.btn_satisGecmisi.PressedColor = System.Drawing.Color.GreenYellow;
            this.btn_satisGecmisi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btn_satisGecmisi.Size = new System.Drawing.Size(157, 50);
            this.btn_satisGecmisi.TabIndex = 5;
            this.btn_satisGecmisi.Text = "Satış Kayıtları";
            this.btn_satisGecmisi.Click += new System.EventHandler(this.btn_satisGecmisi_Click);
            // 
            // btn_borc_arama
            // 
            this.btn_borc_arama.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_borc_arama.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.btn_borc_arama.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_borc_arama.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btn_borc_arama.CustomizableEdges = customizableEdges3;
            this.btn_borc_arama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_borc_arama.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_borc_arama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_borc_arama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_borc_arama.FillColor = System.Drawing.Color.White;
            this.btn_borc_arama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borc_arama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_borc_arama.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_borc_arama.Location = new System.Drawing.Point(168, 0);
            this.btn_borc_arama.Name = "btn_borc_arama";
            this.btn_borc_arama.PressedColor = System.Drawing.Color.GreenYellow;
            this.btn_borc_arama.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btn_borc_arama.Size = new System.Drawing.Size(216, 50);
            this.btn_borc_arama.TabIndex = 6;
            this.btn_borc_arama.Text = "Kişi arama";
            this.btn_borc_arama.Click += new System.EventHandler(this.btn_stok_girisi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_borc_arama);
            this.panel1.Controls.Add(this.btn_satisGecmisi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 50);
            this.panel1.TabIndex = 7;
            // 
            // panel_kayitlar
            // 
            this.panel_kayitlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_kayitlar.Location = new System.Drawing.Point(0, 160);
            this.panel_kayitlar.Name = "panel_kayitlar";
            this.panel_kayitlar.Size = new System.Drawing.Size(654, 451);
            this.panel_kayitlar.TabIndex = 8;
            // 
            // UC_kayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_kayitlar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelKayitlar);
            this.Name = "UC_kayitlar";
            this.Size = new System.Drawing.Size(654, 611);
            this.Load += new System.EventHandler(this.UC_kayitlar_Load);
            this.PanelKayitlar.ResumeLayout(false);
            this.PanelKayitlar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelKayitlar;
        private Label labelKayitlar;
        private Guna.UI2.WinForms.Guna2Button btn_satisGecmisi;
        private Guna.UI2.WinForms.Guna2Button btn_borc_arama;
        private Panel panel1;
        private Panel panel_kayitlar;
    }
}
