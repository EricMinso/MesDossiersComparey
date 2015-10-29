﻿namespace MesDossiers
{
    partial class InterfaceMesDossiers
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMaître = new System.Windows.Forms.TableLayoutPanel();
            this.flpBoutons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.dlgChoixDossiers = new System.Windows.Forms.FolderBrowserDialog();
            this.tlpGauche = new System.Windows.Forms.TableLayoutPanel();
            this.tbxDossierGauche = new System.Windows.Forms.TextBox();
            this.flpBoutonsGauches = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChoisirDossierGauche = new System.Windows.Forms.Button();
            this.gbxGauche = new System.Windows.Forms.GroupBox();
            this.lbxUniquesGauche = new System.Windows.Forms.ListBox();
            this.gbxDroite = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxDossierDroite = new System.Windows.Forms.TextBox();
            this.flpBoutonsDroites = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChoixDossierDroite = new System.Windows.Forms.Button();
            this.lbxUniquesDroite = new System.Windows.Forms.ListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbxDoublons = new System.Windows.Forms.ListBox();
            this.gbUniquesGauche = new System.Windows.Forms.GroupBox();
            this.tlpRésultats = new System.Windows.Forms.TableLayoutPanel();
            this.gbxDoublons = new System.Windows.Forms.GroupBox();
            this.gbUniquesDroite = new System.Windows.Forms.GroupBox();
            this.tlpMaître.SuspendLayout();
            this.flpBoutons.SuspendLayout();
            this.tlpGauche.SuspendLayout();
            this.flpBoutonsGauches.SuspendLayout();
            this.gbxGauche.SuspendLayout();
            this.gbxDroite.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpBoutonsDroites.SuspendLayout();
            this.gbUniquesGauche.SuspendLayout();
            this.tlpRésultats.SuspendLayout();
            this.gbxDoublons.SuspendLayout();
            this.gbUniquesDroite.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMaître
            // 
            this.tlpMaître.AutoSize = true;
            this.tlpMaître.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMaître.ColumnCount = 2;
            this.tlpMaître.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMaître.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMaître.Controls.Add(this.gbxDroite, 1, 0);
            this.tlpMaître.Controls.Add(this.flpBoutons, 1, 2);
            this.tlpMaître.Controls.Add(this.gbxGauche, 0, 0);
            this.tlpMaître.Controls.Add(this.tlpRésultats, 0, 1);
            this.tlpMaître.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMaître.Location = new System.Drawing.Point(0, 0);
            this.tlpMaître.Name = "tlpMaître";
            this.tlpMaître.Padding = new System.Windows.Forms.Padding(10);
            this.tlpMaître.RowCount = 3;
            this.tlpMaître.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaître.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaître.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaître.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMaître.Size = new System.Drawing.Size(918, 728);
            this.tlpMaître.TabIndex = 0;
            // 
            // flpBoutons
            // 
            this.flpBoutons.AutoSize = true;
            this.flpBoutons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBoutons.Controls.Add(this.btnFermer);
            this.flpBoutons.Controls.Add(this.btnGo);
            this.flpBoutons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBoutons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBoutons.Location = new System.Drawing.Point(462, 686);
            this.flpBoutons.Name = "flpBoutons";
            this.flpBoutons.Size = new System.Drawing.Size(443, 29);
            this.flpBoutons.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(365, 3);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 0;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // tlpGauche
            // 
            this.tlpGauche.AutoSize = true;
            this.tlpGauche.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGauche.ColumnCount = 1;
            this.tlpGauche.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGauche.Controls.Add(this.tbxDossierGauche, 0, 0);
            this.tlpGauche.Controls.Add(this.flpBoutonsGauches, 0, 1);
            this.tlpGauche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpGauche.Location = new System.Drawing.Point(10, 23);
            this.tlpGauche.Name = "tlpGauche";
            this.tlpGauche.RowCount = 2;
            this.tlpGauche.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGauche.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGauche.Size = new System.Drawing.Size(423, 61);
            this.tlpGauche.TabIndex = 1;
            // 
            // tbxDossierGauche
            // 
            this.tbxDossierGauche.AllowDrop = true;
            this.tbxDossierGauche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDossierGauche.Location = new System.Drawing.Point(3, 3);
            this.tbxDossierGauche.Name = "tbxDossierGauche";
            this.tbxDossierGauche.Size = new System.Drawing.Size(417, 20);
            this.tbxDossierGauche.TabIndex = 0;
            // 
            // flpBoutonsGauches
            // 
            this.flpBoutonsGauches.AutoSize = true;
            this.flpBoutonsGauches.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBoutonsGauches.Controls.Add(this.btnChoisirDossierGauche);
            this.flpBoutonsGauches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBoutonsGauches.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBoutonsGauches.Location = new System.Drawing.Point(3, 29);
            this.flpBoutonsGauches.Name = "flpBoutonsGauches";
            this.flpBoutonsGauches.Size = new System.Drawing.Size(417, 29);
            this.flpBoutonsGauches.TabIndex = 1;
            // 
            // btnChoisirDossierGauche
            // 
            this.btnChoisirDossierGauche.Location = new System.Drawing.Point(309, 3);
            this.btnChoisirDossierGauche.Name = "btnChoisirDossierGauche";
            this.btnChoisirDossierGauche.Size = new System.Drawing.Size(105, 23);
            this.btnChoisirDossierGauche.TabIndex = 0;
            this.btnChoisirDossierGauche.Text = "Sélectionner";
            this.btnChoisirDossierGauche.UseVisualStyleBackColor = true;
            this.btnChoisirDossierGauche.Click += new System.EventHandler(this.btnChoisirDossierGauche_Click);
            // 
            // gbxGauche
            // 
            this.gbxGauche.AutoSize = true;
            this.gbxGauche.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxGauche.Controls.Add(this.tlpGauche);
            this.gbxGauche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGauche.Location = new System.Drawing.Point(13, 13);
            this.gbxGauche.Name = "gbxGauche";
            this.gbxGauche.Padding = new System.Windows.Forms.Padding(10);
            this.gbxGauche.Size = new System.Drawing.Size(443, 94);
            this.gbxGauche.TabIndex = 2;
            this.gbxGauche.TabStop = false;
            this.gbxGauche.Text = "Ensemble Gauche";
            // 
            // lbxUniquesGauche
            // 
            this.lbxUniquesGauche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxUniquesGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxUniquesGauche.FormattingEnabled = true;
            this.lbxUniquesGauche.HorizontalScrollbar = true;
            this.lbxUniquesGauche.Location = new System.Drawing.Point(10, 23);
            this.lbxUniquesGauche.Name = "lbxUniquesGauche";
            this.lbxUniquesGauche.Size = new System.Drawing.Size(271, 528);
            this.lbxUniquesGauche.TabIndex = 2;
            // 
            // gbxDroite
            // 
            this.gbxDroite.AutoSize = true;
            this.gbxDroite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxDroite.Controls.Add(this.tableLayoutPanel1);
            this.gbxDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDroite.Location = new System.Drawing.Point(462, 13);
            this.gbxDroite.Name = "gbxDroite";
            this.gbxDroite.Padding = new System.Windows.Forms.Padding(10);
            this.gbxDroite.Size = new System.Drawing.Size(443, 94);
            this.gbxDroite.TabIndex = 3;
            this.gbxDroite.TabStop = false;
            this.gbxDroite.Text = "Ensemble Droite";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbxDossierDroite, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpBoutonsDroites, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 61);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tbxDossierDroite
            // 
            this.tbxDossierDroite.AllowDrop = true;
            this.tbxDossierDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDossierDroite.Location = new System.Drawing.Point(3, 3);
            this.tbxDossierDroite.Name = "tbxDossierDroite";
            this.tbxDossierDroite.Size = new System.Drawing.Size(417, 20);
            this.tbxDossierDroite.TabIndex = 0;
            // 
            // flpBoutonsDroites
            // 
            this.flpBoutonsDroites.AutoSize = true;
            this.flpBoutonsDroites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBoutonsDroites.Controls.Add(this.btnChoixDossierDroite);
            this.flpBoutonsDroites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBoutonsDroites.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBoutonsDroites.Location = new System.Drawing.Point(3, 29);
            this.flpBoutonsDroites.Name = "flpBoutonsDroites";
            this.flpBoutonsDroites.Size = new System.Drawing.Size(417, 29);
            this.flpBoutonsDroites.TabIndex = 1;
            // 
            // btnChoixDossierDroite
            // 
            this.btnChoixDossierDroite.Location = new System.Drawing.Point(309, 3);
            this.btnChoixDossierDroite.Name = "btnChoixDossierDroite";
            this.btnChoixDossierDroite.Size = new System.Drawing.Size(105, 23);
            this.btnChoixDossierDroite.TabIndex = 0;
            this.btnChoixDossierDroite.Text = "Sélectionner";
            this.btnChoixDossierDroite.UseVisualStyleBackColor = true;
            this.btnChoixDossierDroite.Click += new System.EventHandler(this.btnChoixDossierDroite_Click);
            // 
            // lbxUniquesDroite
            // 
            this.lbxUniquesDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxUniquesDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxUniquesDroite.FormattingEnabled = true;
            this.lbxUniquesDroite.HorizontalScrollbar = true;
            this.lbxUniquesDroite.Location = new System.Drawing.Point(10, 23);
            this.lbxUniquesDroite.Name = "lbxUniquesDroite";
            this.lbxUniquesDroite.Size = new System.Drawing.Size(272, 528);
            this.lbxUniquesDroite.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(284, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbxDoublons
            // 
            this.lbxDoublons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxDoublons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDoublons.FormattingEnabled = true;
            this.lbxDoublons.Location = new System.Drawing.Point(10, 23);
            this.lbxDoublons.Name = "lbxDoublons";
            this.lbxDoublons.Size = new System.Drawing.Size(271, 528);
            this.lbxDoublons.TabIndex = 3;
            // 
            // gbUniquesGauche
            // 
            this.gbUniquesGauche.AutoSize = true;
            this.gbUniquesGauche.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbUniquesGauche.Controls.Add(this.lbxUniquesGauche);
            this.gbUniquesGauche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUniquesGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUniquesGauche.Location = new System.Drawing.Point(3, 3);
            this.gbUniquesGauche.Name = "gbUniquesGauche";
            this.gbUniquesGauche.Padding = new System.Windows.Forms.Padding(10);
            this.gbUniquesGauche.Size = new System.Drawing.Size(291, 561);
            this.gbUniquesGauche.TabIndex = 4;
            this.gbUniquesGauche.TabStop = false;
            this.gbUniquesGauche.Text = "Uniquement à gauche";
            // 
            // tlpRésultats
            // 
            this.tlpRésultats.AutoSize = true;
            this.tlpRésultats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpRésultats.ColumnCount = 3;
            this.tlpMaître.SetColumnSpan(this.tlpRésultats, 2);
            this.tlpRésultats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRésultats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRésultats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRésultats.Controls.Add(this.gbUniquesGauche, 0, 0);
            this.tlpRésultats.Controls.Add(this.gbxDoublons, 1, 0);
            this.tlpRésultats.Controls.Add(this.gbUniquesDroite, 2, 0);
            this.tlpRésultats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRésultats.Location = new System.Drawing.Point(13, 113);
            this.tlpRésultats.Name = "tlpRésultats";
            this.tlpRésultats.RowCount = 1;
            this.tlpRésultats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRésultats.Size = new System.Drawing.Size(892, 567);
            this.tlpRésultats.TabIndex = 5;
            // 
            // gbxDoublons
            // 
            this.gbxDoublons.AutoSize = true;
            this.gbxDoublons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxDoublons.Controls.Add(this.lbxDoublons);
            this.gbxDoublons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDoublons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDoublons.Location = new System.Drawing.Point(300, 3);
            this.gbxDoublons.Name = "gbxDoublons";
            this.gbxDoublons.Padding = new System.Windows.Forms.Padding(10);
            this.gbxDoublons.Size = new System.Drawing.Size(291, 561);
            this.gbxDoublons.TabIndex = 5;
            this.gbxDoublons.TabStop = false;
            this.gbxDoublons.Text = "Doublons";
            // 
            // gbUniquesDroite
            // 
            this.gbUniquesDroite.AutoSize = true;
            this.gbUniquesDroite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbUniquesDroite.Controls.Add(this.lbxUniquesDroite);
            this.gbUniquesDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUniquesDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUniquesDroite.Location = new System.Drawing.Point(597, 3);
            this.gbUniquesDroite.Name = "gbUniquesDroite";
            this.gbUniquesDroite.Padding = new System.Windows.Forms.Padding(10);
            this.gbUniquesDroite.Size = new System.Drawing.Size(292, 561);
            this.gbUniquesDroite.TabIndex = 6;
            this.gbUniquesDroite.TabStop = false;
            this.gbUniquesDroite.Text = "Uniquement à droite";
            // 
            // SousEnsembleDossier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 728);
            this.Controls.Add(this.tlpMaître);
            this.Name = "SousEnsembleDossier";
            this.Text = "Doublons de Dossiers";
            this.tlpMaître.ResumeLayout(false);
            this.tlpMaître.PerformLayout();
            this.flpBoutons.ResumeLayout(false);
            this.tlpGauche.ResumeLayout(false);
            this.tlpGauche.PerformLayout();
            this.flpBoutonsGauches.ResumeLayout(false);
            this.gbxGauche.ResumeLayout(false);
            this.gbxGauche.PerformLayout();
            this.gbxDroite.ResumeLayout(false);
            this.gbxDroite.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flpBoutonsDroites.ResumeLayout(false);
            this.gbUniquesGauche.ResumeLayout(false);
            this.tlpRésultats.ResumeLayout(false);
            this.tlpRésultats.PerformLayout();
            this.gbxDoublons.ResumeLayout(false);
            this.gbUniquesDroite.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMaître;
        private System.Windows.Forms.GroupBox gbxDroite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbxDossierDroite;
        private System.Windows.Forms.FlowLayoutPanel flpBoutonsDroites;
        private System.Windows.Forms.Button btnChoixDossierDroite;
        private System.Windows.Forms.ListBox lbxUniquesDroite;
        private System.Windows.Forms.FlowLayoutPanel flpBoutons;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.GroupBox gbxGauche;
        private System.Windows.Forms.TableLayoutPanel tlpGauche;
        private System.Windows.Forms.TextBox tbxDossierGauche;
        private System.Windows.Forms.FlowLayoutPanel flpBoutonsGauches;
        private System.Windows.Forms.Button btnChoisirDossierGauche;
        private System.Windows.Forms.ListBox lbxUniquesGauche;
        private System.Windows.Forms.FolderBrowserDialog dlgChoixDossiers;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox gbUniquesGauche;
        private System.Windows.Forms.ListBox lbxDoublons;
        private System.Windows.Forms.TableLayoutPanel tlpRésultats;
        private System.Windows.Forms.GroupBox gbxDoublons;
        private System.Windows.Forms.GroupBox gbUniquesDroite;
    }
}
