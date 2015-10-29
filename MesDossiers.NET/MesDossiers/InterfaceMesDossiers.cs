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

            this.tbxDossierGauche.DragEnter += new DragEventHandler( this.TextBox_DragEnter );
            this.tbxDossierDroite.DragEnter += new DragEventHandler( this.TextBox_DragEnter );
            this.tbxDossierGauche.DragDrop += new DragEventHandler( this.TextBox_DragDrop );
            this.tbxDossierDroite.DragDrop += new DragEventHandler( this.TextBox_DragDrop );
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
            try
            {
                MesDossiers comparateur = new MesDossiers( tbxDossierGauche.Text, tbxDossierDroite.Text );
                comparateur.calculer( this.cbxNom.Checked, this.cbxTaille.Checked, this.cbxDate.Checked );

                /*List<string> uniquesGauche = comparateur.getListeStringUniquesGauche();
                List<string> uniquesDroite = comparateur.getListeStringUniquesDroite();
                List<string> doublons = comparateur.getListeStringDoublons();//*/

                List<FileInfo> uniquesGauche = comparateur.getListeFileInfoUniquesGauche();
                List<FileInfo> uniquesDroite = comparateur.getListeFileInfoUniquesDroite();
                List<FileInfo> doublons = comparateur.getListeFileInfoDoublons();

                lbxUniquesGauche.Items.Clear();
                lbxUniquesDroite.Items.Clear();
                lbxDoublons.Items.Clear();

                lbxUniquesGauche.Items.AddRange( uniquesGauche.ToArray() );
                lbxUniquesDroite.Items.AddRange( uniquesDroite.ToArray() );
                lbxDoublons.Items.AddRange( doublons.ToArray() );
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }






#region Drag'n Drop

        private void TextBox_DragDrop( object sender, DragEventArgs e )
        {
            // Handle FileDrop data.
            if( e.Data.GetDataPresent( DataFormats.FileDrop ) )
            {
                // Assign the file names to a string array, in 
                // case the user has selected multiple files.
                string[] files = (string[]) e.Data.GetData( DataFormats.FileDrop );
                try
                {
                    // Assign the first image to the picture variable.
                    ///this.picture = Image.FromFile( files[ 0 ] );
                    // Set the picture location equal to the drop point.
                    ///this.pictureLocation = this.PointToClient( new Point( e.X, e.Y ) );

                    ( (TextBox) sender ).Text = files[ 0 ];

                }
                catch( Exception ex )
                {
                    Program.DisplayException( ex );
                    return;
                }
            }

            /* / Handle Bitmap data.
            if( e.Data.GetDataPresent( DataFormats.Bitmap ) )
            {
                try
                {
                    // Create an Image and assign it to the picture variable.
                    this.picture = (Image) e.Data.GetData( DataFormats.Bitmap );
                    // Set the picture location equal to the drop point.
                    this.pictureLocation = this.PointToClient( new Point( e.X, e.Y ) );
                }
                catch( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                    return;
                }
            } // */
            // Force the form to be redrawn with the image.
            this.Invalidate();
        }

        private void TextBox_DragEnter( object sender, DragEventArgs e )
        {
            // If the data is a file or a bitmap, display the copy cursor.
            if( //e.Data.GetDataPresent( DataFormats.Bitmap ) ||
               e.Data.GetDataPresent( DataFormats.FileDrop ) )
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

#endregion
    }
}
