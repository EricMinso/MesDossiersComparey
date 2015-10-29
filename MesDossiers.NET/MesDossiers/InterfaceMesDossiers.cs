using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace MesDossiers
{
    public partial class InterfaceMesDossiers : Form
    {
        public InterfaceMesDossiers()
        {
            InitializeComponent();
        }

        private void btnChoisirDossierGauche_Click( object sender, EventArgs e )
        {
            if( DialogResult.OK == dlgChoixDossiers.ShowDialog() )
            {
                tbxDossierGauche.Text = dlgChoixDossiers.SelectedPath;
            }
        }

        private void btnChoixDossierDroite_Click( object sender, EventArgs e )
        {
            if( DialogResult.OK == dlgChoixDossiers.ShowDialog() )
            {
                tbxDossierDroite.Text = dlgChoixDossiers.SelectedPath;
            }
        }

        private void btnFermer_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnGo_Click( object sender, EventArgs e )
        {
            List<string> uniquesGauche;
            List<string> uniquesDroite;
            List<string> doublons;

            List<string> listeGauche = MesDossiers.convertToString( new MesDossiers( tbxDossierGauche.Text ).getListeFileInfos() );
            List<string> listeDroite = MesDossiers.convertToString( new MesDossiers( tbxDossierDroite.Text ).getListeFileInfos() );

            MesDossiers.getDoublonsUniques( listeGauche, listeDroite, out uniquesGauche, out uniquesDroite, out doublons );

            lbxUniquesGauche.Items.Clear();
            lbxUniquesDroite.Items.Clear();
            lbxDoublons.Items.Clear();

            lbxUniquesGauche.Items.AddRange( uniquesGauche.ToArray() );
            lbxUniquesDroite.Items.AddRange( uniquesDroite.ToArray() );
            lbxDoublons.Items.AddRange( doublons.ToArray() );
        }
    }
}
