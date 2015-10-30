namespace MesDossiers
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
            this.components = new System.ComponentModel.Container();
            this.tlpMaître = new System.Windows.Forms.TableLayoutPanel();
            this.gbxDroite = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxDossierDroite = new System.Windows.Forms.TextBox();
            this.flpBoutonsDroites = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChoixDossierDroite = new System.Windows.Forms.Button();
            this.flpBoutons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.gbxGauche = new System.Windows.Forms.GroupBox();
            this.tlpGauche = new System.Windows.Forms.TableLayoutPanel();
            this.tbxDossierGauche = new System.Windows.Forms.TextBox();
            this.flpBoutonsGauches = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChoisirDossierGauche = new System.Windows.Forms.Button();
            this.tlpRésultats = new System.Windows.Forms.TableLayoutPanel();
            this.gbxUniquesGauche = new System.Windows.Forms.GroupBox();
            this.lvwUniquesGauche = new System.Windows.Forms.ListView();
            this.clhNomGauche = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTypeGauche = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTailleGauche = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDateGauche = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCheminGauche = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuContextuel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOuvrirFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrirDossier = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxDoublons = new System.Windows.Forms.GroupBox();
            this.lvwDoublons = new System.Windows.Forms.ListView();
            this.clhNomDoublon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTypeDoublon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTailleDoublon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDateDoublon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCheminDoublon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxUniquesDroite = new System.Windows.Forms.GroupBox();
            this.lvwUniquesDroite = new System.Windows.Forms.ListView();
            this.clhNomDroite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTypeDroite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTailleDroite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDateDroite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCheminDroite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxCritères = new System.Windows.Forms.GroupBox();
            this.flpCritères = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxNom = new System.Windows.Forms.CheckBox();
            this.cbxTaille = new System.Windows.Forms.CheckBox();
            this.cbxDate = new System.Windows.Forms.CheckBox();
            this.lblExclure = new System.Windows.Forms.Label();
            this.tbxExclure = new System.Windows.Forms.TextBox();
            this.dlgChoixDossiers = new System.Windows.Forms.FolderBrowserDialog();
            this.tlpMaître.SuspendLayout();
            this.gbxDroite.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpBoutonsDroites.SuspendLayout();
            this.flpBoutons.SuspendLayout();
            this.gbxGauche.SuspendLayout();
            this.tlpGauche.SuspendLayout();
            this.flpBoutonsGauches.SuspendLayout();
            this.tlpRésultats.SuspendLayout();
            this.gbxUniquesGauche.SuspendLayout();
            this.menuContextuel.SuspendLayout();
            this.gbxDoublons.SuspendLayout();
            this.gbxUniquesDroite.SuspendLayout();
            this.gbxCritères.SuspendLayout();
            this.flpCritères.SuspendLayout();
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
            this.tlpMaître.Controls.Add(this.gbxCritères, 0, 2);
            this.tlpMaître.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMaître.Location = new System.Drawing.Point(0, 0);
            this.tlpMaître.Name = "tlpMaître";
            this.tlpMaître.Padding = new System.Windows.Forms.Padding(10);
            this.tlpMaître.RowCount = 3;
            this.tlpMaître.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaître.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaître.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaître.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMaître.Size = new System.Drawing.Size(1297, 734);
            this.tlpMaître.TabIndex = 0;
            // 
            // gbxDroite
            // 
            this.gbxDroite.AutoSize = true;
            this.gbxDroite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxDroite.Controls.Add(this.tableLayoutPanel1);
            this.gbxDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDroite.Location = new System.Drawing.Point(651, 13);
            this.gbxDroite.Name = "gbxDroite";
            this.gbxDroite.Padding = new System.Windows.Forms.Padding(10);
            this.gbxDroite.Size = new System.Drawing.Size(633, 88);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 55);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tbxDossierDroite
            // 
            this.tbxDossierDroite.AllowDrop = true;
            this.tbxDossierDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDossierDroite.Location = new System.Drawing.Point(3, 3);
            this.tbxDossierDroite.Name = "tbxDossierDroite";
            this.tbxDossierDroite.Size = new System.Drawing.Size(607, 20);
            this.tbxDossierDroite.TabIndex = 0;
            // 
            // flpBoutonsDroites
            // 
            this.flpBoutonsDroites.AutoSize = true;
            this.flpBoutonsDroites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBoutonsDroites.Controls.Add(this.btnChoixDossierDroite);
            this.flpBoutonsDroites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBoutonsDroites.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBoutonsDroites.Location = new System.Drawing.Point(0, 26);
            this.flpBoutonsDroites.Margin = new System.Windows.Forms.Padding(0);
            this.flpBoutonsDroites.Name = "flpBoutonsDroites";
            this.flpBoutonsDroites.Size = new System.Drawing.Size(613, 29);
            this.flpBoutonsDroites.TabIndex = 1;
            // 
            // btnChoixDossierDroite
            // 
            this.btnChoixDossierDroite.Location = new System.Drawing.Point(505, 3);
            this.btnChoixDossierDroite.Name = "btnChoixDossierDroite";
            this.btnChoixDossierDroite.Size = new System.Drawing.Size(105, 23);
            this.btnChoixDossierDroite.TabIndex = 0;
            this.btnChoixDossierDroite.Text = "Sélectionner";
            this.btnChoixDossierDroite.UseVisualStyleBackColor = true;
            this.btnChoixDossierDroite.Click += new System.EventHandler(this.btnChoixDossierDroite_Click);
            // 
            // flpBoutons
            // 
            this.flpBoutons.AutoSize = true;
            this.flpBoutons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBoutons.Controls.Add(this.btnFermer);
            this.flpBoutons.Controls.Add(this.btnGo);
            this.flpBoutons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpBoutons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBoutons.Location = new System.Drawing.Point(648, 695);
            this.flpBoutons.Margin = new System.Windows.Forms.Padding(0);
            this.flpBoutons.Name = "flpBoutons";
            this.flpBoutons.Size = new System.Drawing.Size(639, 29);
            this.flpBoutons.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(561, 3);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 0;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(480, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
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
            this.gbxGauche.Size = new System.Drawing.Size(632, 88);
            this.gbxGauche.TabIndex = 2;
            this.gbxGauche.TabStop = false;
            this.gbxGauche.Text = "Ensemble Gauche";
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
            this.tlpGauche.Size = new System.Drawing.Size(612, 55);
            this.tlpGauche.TabIndex = 1;
            // 
            // tbxDossierGauche
            // 
            this.tbxDossierGauche.AllowDrop = true;
            this.tbxDossierGauche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDossierGauche.Location = new System.Drawing.Point(3, 3);
            this.tbxDossierGauche.Name = "tbxDossierGauche";
            this.tbxDossierGauche.Size = new System.Drawing.Size(606, 20);
            this.tbxDossierGauche.TabIndex = 0;
            // 
            // flpBoutonsGauches
            // 
            this.flpBoutonsGauches.AutoSize = true;
            this.flpBoutonsGauches.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBoutonsGauches.Controls.Add(this.btnChoisirDossierGauche);
            this.flpBoutonsGauches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBoutonsGauches.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBoutonsGauches.Location = new System.Drawing.Point(0, 26);
            this.flpBoutonsGauches.Margin = new System.Windows.Forms.Padding(0);
            this.flpBoutonsGauches.Name = "flpBoutonsGauches";
            this.flpBoutonsGauches.Size = new System.Drawing.Size(612, 29);
            this.flpBoutonsGauches.TabIndex = 1;
            // 
            // btnChoisirDossierGauche
            // 
            this.btnChoisirDossierGauche.Location = new System.Drawing.Point(504, 3);
            this.btnChoisirDossierGauche.Name = "btnChoisirDossierGauche";
            this.btnChoisirDossierGauche.Size = new System.Drawing.Size(105, 23);
            this.btnChoisirDossierGauche.TabIndex = 0;
            this.btnChoisirDossierGauche.Text = "Sélectionner";
            this.btnChoisirDossierGauche.UseVisualStyleBackColor = true;
            this.btnChoisirDossierGauche.Click += new System.EventHandler(this.btnChoisirDossierGauche_Click);
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
            this.tlpRésultats.Controls.Add(this.gbxUniquesGauche, 0, 0);
            this.tlpRésultats.Controls.Add(this.gbxDoublons, 1, 0);
            this.tlpRésultats.Controls.Add(this.gbxUniquesDroite, 2, 0);
            this.tlpRésultats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRésultats.Location = new System.Drawing.Point(13, 107);
            this.tlpRésultats.Name = "tlpRésultats";
            this.tlpRésultats.RowCount = 1;
            this.tlpRésultats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRésultats.Size = new System.Drawing.Size(1271, 545);
            this.tlpRésultats.TabIndex = 5;
            // 
            // gbxUniquesGauche
            // 
            this.gbxUniquesGauche.AutoSize = true;
            this.gbxUniquesGauche.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxUniquesGauche.Controls.Add(this.lvwUniquesGauche);
            this.gbxUniquesGauche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxUniquesGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUniquesGauche.Location = new System.Drawing.Point(3, 3);
            this.gbxUniquesGauche.Name = "gbxUniquesGauche";
            this.gbxUniquesGauche.Padding = new System.Windows.Forms.Padding(10);
            this.gbxUniquesGauche.Size = new System.Drawing.Size(417, 539);
            this.gbxUniquesGauche.TabIndex = 4;
            this.gbxUniquesGauche.TabStop = false;
            this.gbxUniquesGauche.Text = "Uniquement à gauche";
            // 
            // lvwUniquesGauche
            // 
            this.lvwUniquesGauche.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNomGauche,
            this.clhTypeGauche,
            this.clhTailleGauche,
            this.clhDateGauche,
            this.clhCheminGauche});
            this.lvwUniquesGauche.ContextMenuStrip = this.menuContextuel;
            this.lvwUniquesGauche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwUniquesGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwUniquesGauche.FullRowSelect = true;
            this.lvwUniquesGauche.GridLines = true;
            this.lvwUniquesGauche.Location = new System.Drawing.Point(10, 23);
            this.lvwUniquesGauche.MultiSelect = false;
            this.lvwUniquesGauche.Name = "lvwUniquesGauche";
            this.lvwUniquesGauche.Size = new System.Drawing.Size(397, 506);
            this.lvwUniquesGauche.TabIndex = 2;
            this.lvwUniquesGauche.UseCompatibleStateImageBehavior = false;
            this.lvwUniquesGauche.View = System.Windows.Forms.View.Details;
            this.lvwUniquesGauche.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwUniquesGauche_ColumnClick);
            this.lvwUniquesGauche.DoubleClick += new System.EventHandler(this.lvwUniquesGauche_DoubleClick);
            // 
            // clhNomGauche
            // 
            this.clhNomGauche.Text = "Nom";
            this.clhNomGauche.Width = 150;
            // 
            // clhTypeGauche
            // 
            this.clhTypeGauche.Text = "Type";
            // 
            // clhTailleGauche
            // 
            this.clhTailleGauche.Text = "Taille";
            // 
            // clhDateGauche
            // 
            this.clhDateGauche.Text = "Date de modification";
            this.clhDateGauche.Width = 120;
            // 
            // clhCheminGauche
            // 
            this.clhCheminGauche.Text = "Chemin";
            this.clhCheminGauche.Width = 500;
            // 
            // menuContextuel
            // 
            this.menuContextuel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOuvrirFichier,
            this.tsmiOuvrirDossier});
            this.menuContextuel.Name = "menuContextuel";
            this.menuContextuel.Size = new System.Drawing.Size(153, 70);
            // 
            // tsmiOuvrirFichier
            // 
            this.tsmiOuvrirFichier.Name = "tsmiOuvrirFichier";
            this.tsmiOuvrirFichier.Size = new System.Drawing.Size(152, 22);
            this.tsmiOuvrirFichier.Text = "Ouvrir Fichier";
            this.tsmiOuvrirFichier.Click += new System.EventHandler(this.tsmiOuvrirFichier_Click);
            // 
            // tsmiOuvrirDossier
            // 
            this.tsmiOuvrirDossier.Name = "tsmiOuvrirDossier";
            this.tsmiOuvrirDossier.Size = new System.Drawing.Size(152, 22);
            this.tsmiOuvrirDossier.Text = "Ouvrir Dossier";
            this.tsmiOuvrirDossier.Click += new System.EventHandler(this.tsmiOuvrirDossier_Click);
            // 
            // gbxDoublons
            // 
            this.gbxDoublons.AutoSize = true;
            this.gbxDoublons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxDoublons.Controls.Add(this.lvwDoublons);
            this.gbxDoublons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDoublons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDoublons.Location = new System.Drawing.Point(426, 3);
            this.gbxDoublons.Name = "gbxDoublons";
            this.gbxDoublons.Padding = new System.Windows.Forms.Padding(10);
            this.gbxDoublons.Size = new System.Drawing.Size(417, 539);
            this.gbxDoublons.TabIndex = 5;
            this.gbxDoublons.TabStop = false;
            this.gbxDoublons.Text = "Doublons";
            // 
            // lvwDoublons
            // 
            this.lvwDoublons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNomDoublon,
            this.clhTypeDoublon,
            this.clhTailleDoublon,
            this.clhDateDoublon,
            this.clhCheminDoublon});
            this.lvwDoublons.ContextMenuStrip = this.menuContextuel;
            this.lvwDoublons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDoublons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDoublons.FullRowSelect = true;
            this.lvwDoublons.GridLines = true;
            this.lvwDoublons.Location = new System.Drawing.Point(10, 23);
            this.lvwDoublons.MultiSelect = false;
            this.lvwDoublons.Name = "lvwDoublons";
            this.lvwDoublons.Size = new System.Drawing.Size(397, 506);
            this.lvwDoublons.TabIndex = 3;
            this.lvwDoublons.UseCompatibleStateImageBehavior = false;
            this.lvwDoublons.View = System.Windows.Forms.View.Details;
            this.lvwDoublons.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwDoublons_ColumnClick);
            this.lvwDoublons.DoubleClick += new System.EventHandler(this.lvwDoublons_DoubleClick);
            // 
            // clhNomDoublon
            // 
            this.clhNomDoublon.Text = "Nom";
            this.clhNomDoublon.Width = 150;
            // 
            // clhTypeDoublon
            // 
            this.clhTypeDoublon.Text = "Type";
            // 
            // clhTailleDoublon
            // 
            this.clhTailleDoublon.Text = "Taille";
            // 
            // clhDateDoublon
            // 
            this.clhDateDoublon.Text = "Date de modification";
            this.clhDateDoublon.Width = 120;
            // 
            // clhCheminDoublon
            // 
            this.clhCheminDoublon.Text = "Chemin";
            this.clhCheminDoublon.Width = 500;
            // 
            // gbxUniquesDroite
            // 
            this.gbxUniquesDroite.AutoSize = true;
            this.gbxUniquesDroite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxUniquesDroite.Controls.Add(this.lvwUniquesDroite);
            this.gbxUniquesDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxUniquesDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUniquesDroite.Location = new System.Drawing.Point(849, 3);
            this.gbxUniquesDroite.Name = "gbxUniquesDroite";
            this.gbxUniquesDroite.Padding = new System.Windows.Forms.Padding(10);
            this.gbxUniquesDroite.Size = new System.Drawing.Size(419, 539);
            this.gbxUniquesDroite.TabIndex = 6;
            this.gbxUniquesDroite.TabStop = false;
            this.gbxUniquesDroite.Text = "Uniquement à droite";
            // 
            // lvwUniquesDroite
            // 
            this.lvwUniquesDroite.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNomDroite,
            this.clhTypeDroite,
            this.clhTailleDroite,
            this.clhDateDroite,
            this.clhCheminDroite});
            this.lvwUniquesDroite.ContextMenuStrip = this.menuContextuel;
            this.lvwUniquesDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwUniquesDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwUniquesDroite.FullRowSelect = true;
            this.lvwUniquesDroite.GridLines = true;
            this.lvwUniquesDroite.Location = new System.Drawing.Point(10, 23);
            this.lvwUniquesDroite.MultiSelect = false;
            this.lvwUniquesDroite.Name = "lvwUniquesDroite";
            this.lvwUniquesDroite.Size = new System.Drawing.Size(399, 506);
            this.lvwUniquesDroite.TabIndex = 3;
            this.lvwUniquesDroite.UseCompatibleStateImageBehavior = false;
            this.lvwUniquesDroite.View = System.Windows.Forms.View.Details;
            this.lvwUniquesDroite.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwUniquesDroite_ColumnClick);
            this.lvwUniquesDroite.DoubleClick += new System.EventHandler(this.lvwUniquesDroite_DoubleClick);
            // 
            // clhNomDroite
            // 
            this.clhNomDroite.Text = "Nom";
            this.clhNomDroite.Width = 150;
            // 
            // clhTypeDroite
            // 
            this.clhTypeDroite.Text = "Type";
            // 
            // clhTailleDroite
            // 
            this.clhTailleDroite.Text = "Taille";
            // 
            // clhDateDroite
            // 
            this.clhDateDroite.Text = "Date de modification";
            this.clhDateDroite.Width = 120;
            // 
            // clhCheminDroite
            // 
            this.clhCheminDroite.Text = "Chemin";
            this.clhCheminDroite.Width = 500;
            // 
            // gbxCritères
            // 
            this.gbxCritères.AutoSize = true;
            this.gbxCritères.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxCritères.Controls.Add(this.flpCritères);
            this.gbxCritères.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCritères.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCritères.Location = new System.Drawing.Point(13, 658);
            this.gbxCritères.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.gbxCritères.Name = "gbxCritères";
            this.gbxCritères.Padding = new System.Windows.Forms.Padding(10);
            this.gbxCritères.Size = new System.Drawing.Size(632, 56);
            this.gbxCritères.TabIndex = 6;
            this.gbxCritères.TabStop = false;
            this.gbxCritères.Text = "Critères";
            // 
            // flpCritères
            // 
            this.flpCritères.AutoSize = true;
            this.flpCritères.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpCritères.Controls.Add(this.cbxNom);
            this.flpCritères.Controls.Add(this.cbxTaille);
            this.flpCritères.Controls.Add(this.cbxDate);
            this.flpCritères.Controls.Add(this.lblExclure);
            this.flpCritères.Controls.Add(this.tbxExclure);
            this.flpCritères.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCritères.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpCritères.Location = new System.Drawing.Point(10, 23);
            this.flpCritères.Margin = new System.Windows.Forms.Padding(0);
            this.flpCritères.Name = "flpCritères";
            this.flpCritères.Size = new System.Drawing.Size(612, 23);
            this.flpCritères.TabIndex = 6;
            // 
            // cbxNom
            // 
            this.cbxNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxNom.AutoSize = true;
            this.cbxNom.Checked = true;
            this.cbxNom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNom.Location = new System.Drawing.Point(3, 3);
            this.cbxNom.Name = "cbxNom";
            this.cbxNom.Size = new System.Drawing.Size(48, 17);
            this.cbxNom.TabIndex = 0;
            this.cbxNom.Text = "Nom";
            this.cbxNom.UseVisualStyleBackColor = true;
            // 
            // cbxTaille
            // 
            this.cbxTaille.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxTaille.AutoSize = true;
            this.cbxTaille.Checked = true;
            this.cbxTaille.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTaille.Location = new System.Drawing.Point(57, 3);
            this.cbxTaille.Name = "cbxTaille";
            this.cbxTaille.Size = new System.Drawing.Size(51, 17);
            this.cbxTaille.TabIndex = 1;
            this.cbxTaille.Text = "Taille";
            this.cbxTaille.UseVisualStyleBackColor = true;
            // 
            // cbxDate
            // 
            this.cbxDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxDate.AutoSize = true;
            this.cbxDate.Location = new System.Drawing.Point(114, 3);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(49, 17);
            this.cbxDate.TabIndex = 2;
            this.cbxDate.Text = "Date";
            this.cbxDate.UseVisualStyleBackColor = true;
            // 
            // lblExclure
            // 
            this.lblExclure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExclure.AutoSize = true;
            this.lblExclure.Location = new System.Drawing.Point(169, 0);
            this.lblExclure.Name = "lblExclure";
            this.lblExclure.Size = new System.Drawing.Size(48, 23);
            this.lblExclure.TabIndex = 3;
            this.lblExclure.Text = "Exclure :";
            this.lblExclure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxExclure
            // 
            this.tbxExclure.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxExclure.Location = new System.Drawing.Point(223, 3);
            this.tbxExclure.Name = "tbxExclure";
            this.tbxExclure.Size = new System.Drawing.Size(187, 20);
            this.tbxExclure.TabIndex = 4;
            // 
            // InterfaceMesDossiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 734);
            this.Controls.Add(this.tlpMaître);
            this.Name = "InterfaceMesDossiers";
            this.Text = "Recherche de Fichiers en Doublons dans les Dossiers";
            this.tlpMaître.ResumeLayout(false);
            this.tlpMaître.PerformLayout();
            this.gbxDroite.ResumeLayout(false);
            this.gbxDroite.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flpBoutonsDroites.ResumeLayout(false);
            this.flpBoutons.ResumeLayout(false);
            this.gbxGauche.ResumeLayout(false);
            this.gbxGauche.PerformLayout();
            this.tlpGauche.ResumeLayout(false);
            this.tlpGauche.PerformLayout();
            this.flpBoutonsGauches.ResumeLayout(false);
            this.tlpRésultats.ResumeLayout(false);
            this.tlpRésultats.PerformLayout();
            this.gbxUniquesGauche.ResumeLayout(false);
            this.menuContextuel.ResumeLayout(false);
            this.gbxDoublons.ResumeLayout(false);
            this.gbxUniquesDroite.ResumeLayout(false);
            this.gbxCritères.ResumeLayout(false);
            this.gbxCritères.PerformLayout();
            this.flpCritères.ResumeLayout(false);
            this.flpCritères.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flpBoutons;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.GroupBox gbxGauche;
        private System.Windows.Forms.TableLayoutPanel tlpGauche;
        private System.Windows.Forms.TextBox tbxDossierGauche;
        private System.Windows.Forms.FlowLayoutPanel flpBoutonsGauches;
        private System.Windows.Forms.Button btnChoisirDossierGauche;
        private System.Windows.Forms.FolderBrowserDialog dlgChoixDossiers;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox gbxUniquesGauche;
        private System.Windows.Forms.TableLayoutPanel tlpRésultats;
        private System.Windows.Forms.GroupBox gbxDoublons;
        private System.Windows.Forms.GroupBox gbxUniquesDroite;
        private System.Windows.Forms.FlowLayoutPanel flpCritères;
        private System.Windows.Forms.CheckBox cbxNom;
        private System.Windows.Forms.CheckBox cbxTaille;
        private System.Windows.Forms.GroupBox gbxCritères;
        private System.Windows.Forms.CheckBox cbxDate;
        private System.Windows.Forms.ListView lvwUniquesGauche;
        private System.Windows.Forms.ListView lvwDoublons;
        private System.Windows.Forms.ListView lvwUniquesDroite;
        private System.Windows.Forms.ColumnHeader clhNomGauche;
        private System.Windows.Forms.ColumnHeader clhTypeGauche;
        private System.Windows.Forms.ColumnHeader clhTailleGauche;
        private System.Windows.Forms.ColumnHeader clhDateGauche;
        private System.Windows.Forms.ColumnHeader clhNomDoublon;
        private System.Windows.Forms.ColumnHeader clhTypeDoublon;
        private System.Windows.Forms.ColumnHeader clhTailleDoublon;
        private System.Windows.Forms.ColumnHeader clhDateDoublon;
        private System.Windows.Forms.ColumnHeader clhNomDroite;
        private System.Windows.Forms.ColumnHeader clhTypeDroite;
        private System.Windows.Forms.ColumnHeader clhTailleDroite;
        private System.Windows.Forms.ColumnHeader clhDateDroite;
        private System.Windows.Forms.ColumnHeader clhCheminGauche;
        private System.Windows.Forms.ColumnHeader clhCheminDoublon;
        private System.Windows.Forms.ColumnHeader clhCheminDroite;
        private System.Windows.Forms.Label lblExclure;
        private System.Windows.Forms.TextBox tbxExclure;
        private System.Windows.Forms.ContextMenuStrip menuContextuel;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrirFichier;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrirDossier;
    }
}

