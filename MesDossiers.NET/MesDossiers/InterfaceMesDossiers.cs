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
#region Variables d'instance

        private List<FileInfo> _uniquesGauche;
        private List<FileInfo> _uniquesDroite;
        private List<FileInfo> _doublons;

#endregion
#region Constructeurs

        public InterfaceMesDossiers()
        {
            InitializeComponent();

            this.tbxDossierGauche.DragEnter += new DragEventHandler( this.TextBox_DragEnter );
            this.tbxDossierDroite.DragEnter += new DragEventHandler( this.TextBox_DragEnter );
            this.tbxDossierGauche.DragDrop += new DragEventHandler( this.TextBox_DragDrop );
            this.tbxDossierDroite.DragDrop += new DragEventHandler( this.TextBox_DragDrop );
        }

#endregion
#region Comparateurs

        public delegate int déléguéComparateur<in FileInfo>( FileInfo x, FileInfo y );

        private static int comparerParNom( FileInfo x, FileInfo y )
        {
            return x.Name.CompareTo( y.Name );
        }

        private static int comparerParExtension( FileInfo x, FileInfo y )
        {
            return x.Extension.CompareTo( y.Extension );
        }

        private static int comparerParTaille( FileInfo x, FileInfo y )
        {
            if( x.Length > y.Length ) return 1;
            else if( x.Length < y.Length ) return -1;
            else return 0;
        }

        private static int comparerParDate( FileInfo x, FileInfo y )
        {
            return x.LastWriteTimeUtc.CompareTo( y.LastWriteTimeUtc );
        }

        private static int comparerParChemin( FileInfo x, FileInfo y )
        {
            return x.FullName.CompareTo( y.FullName );
        }

#endregion
#region Méthodes privées

        private void go()
        {
            MesDossiers comparateur = new MesDossiers( tbxDossierGauche.Text, tbxDossierDroite.Text );
            comparateur.calculer( this.cbxNom.Checked, this.cbxTaille.Checked, this.cbxDate.Checked, this.tbxExclure.Text );

            this._uniquesGauche = comparateur.getListeFileInfoUniquesGauche();
            this._uniquesDroite = comparateur.getListeFileInfoUniquesDroite();
            this._doublons = comparateur.getListeFileInfoDoublons();

            remplirListView( lvwUniquesGauche, this._uniquesGauche );
            remplirListView( lvwUniquesDroite, this._uniquesDroite );
            remplirListView( lvwDoublons, this._doublons );

            gbxUniquesGauche.Text = "Uniquement à gauche (" + this._uniquesGauche.Count + ")";
            gbxUniquesDroite.Text = "Uniquement à droite (" + this._uniquesDroite.Count + ")";
            gbxDoublons.Text = "Doublons (" + this._doublons.Count + ")";
        }

        private void trier( ListView listView, List<FileInfo> listeData, Comparison<FileInfo> comparateur )
        {
            listeData.Sort( comparateur );
            remplirListView( listView, listeData );
        }

        private string rendreTailleLisible( long taille )
        {
            double fTaille = (double) taille;

            if( taille < 1024 )                 return "< 1 Ko";
            else if( taille < 1048576 )         return Math.Round( fTaille / 1024, 1 ) + " Ko";
            else if( taille < 1073741824 )      return Math.Round( fTaille / 1048576, 1 ) + " Mo";
            else                                return Math.Round( fTaille / 1073741824, 1 ) + " Go";
            //else if( taille < 1048576 )             return ( taille / 1024 ) + " Ko";
            //else if( taille < 1073741824 )          return ( taille / 1048576 ) + " Mo";
            //else                                    return ( taille / 1073741824 ) + " Go";
        }

        private void remplirListView( ListView listView, List<FileInfo> listeData )
        {
            listView.Items.Clear();

            foreach( FileInfo info in listeData )
            {
                ListViewItem lvi = listView.Items.Add( info.Name );
                lvi.SubItems.Add( info.Extension );
                lvi.SubItems.Add( rendreTailleLisible( info.Length ) );
                lvi.SubItems.Add( info.LastWriteTime.ToShortDateString() + " " + info.LastWriteTime.ToShortTimeString() );
                lvi.SubItems.Add( info.FullName );
            }
        }

#endregion
#region Evénements Click 
        
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
                go();
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }

        private void lvwUniquesGauche_ColumnClick( object sender, ColumnClickEventArgs e )
        {
            try
            {
                if( 0 == e.Column )         trier( ( sender as ListView ), this._uniquesGauche, comparerParNom );
                else if( 1 == e.Column )    trier( ( sender as ListView ), this._uniquesGauche, comparerParExtension );
                else if( 2 == e.Column )    trier( ( sender as ListView ), this._uniquesGauche, comparerParTaille );
                else if( 3 == e.Column )    trier( ( sender as ListView ), this._uniquesGauche, comparerParDate );
                else if( 4 == e.Column )    trier( ( sender as ListView ), this._uniquesGauche, comparerParChemin );
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }

        private void lvwDoublons_ColumnClick( object sender, ColumnClickEventArgs e )
        {
            try
            {
                if( 0 == e.Column )         trier( ( sender as ListView ), this._doublons, comparerParNom );
                else if( 1 == e.Column )    trier( ( sender as ListView ), this._doublons, comparerParExtension );
                else if( 2 == e.Column )    trier( ( sender as ListView ), this._doublons, comparerParTaille );
                else if( 3 == e.Column )    trier( ( sender as ListView ), this._doublons, comparerParDate );
                else if( 4 == e.Column )    trier( ( sender as ListView ), this._doublons, comparerParChemin );
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }

        private void lvwUniquesDroite_ColumnClick( object sender, ColumnClickEventArgs e )
        {
            try
            {
                if( 0 == e.Column )         trier( ( sender as ListView ), this._uniquesDroite, comparerParNom );
                else if( 1 == e.Column )    trier( ( sender as ListView ), this._uniquesDroite, comparerParExtension );
                else if( 2 == e.Column )    trier( ( sender as ListView ), this._uniquesDroite, comparerParTaille );
                else if( 3 == e.Column )    trier( ( sender as ListView ), this._uniquesDroite, comparerParDate );
                else if( 4 == e.Column )    trier( ( sender as ListView ), this._uniquesDroite, comparerParChemin );
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }

        private void lvwUniquesGauche_DoubleClick( object sender, EventArgs e )
        {
            try
            {
                if( 0 < ( sender as ListView ).SelectedItems.Count )
                {
                    ListViewItem selectedItem = ( sender as ListView ).SelectedItems[ 0 ];
                    String fullPath = selectedItem.SubItems[ 4 ].Text;
                    System.Diagnostics.Process.Start( fullPath );
                }
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        } 

        private void lvwDoublons_DoubleClick( object sender, EventArgs e )
        {
            try
            {
                if( 0 < ( sender as ListView ).SelectedItems.Count )
                {
                    ListViewItem selectedItem = ( sender as ListView ).SelectedItems[ 0 ];
                    String fullPath = selectedItem.SubItems[ 4 ].Text;
                    System.Diagnostics.Process.Start( fullPath );
                }
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }

        private void lvwUniquesDroite_DoubleClick( object sender, EventArgs e )
        {
            try
            {
                if( 0 < ( sender as ListView ).SelectedItems.Count )
                {
                    ListViewItem selectedItem = ( sender as ListView ).SelectedItems[ 0 ];
                    String fullPath = selectedItem.SubItems[ 4 ].Text;
                    System.Diagnostics.Process.Start( fullPath );
                }
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }

#endregion
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
#region Menu Contextuel

        private void tsmiOuvrirFichier_Click( object sender, EventArgs e )
        {
            ToolStripMenuItem myTSMI = (ToolStripMenuItem) sender;
            ContextMenuStrip myCMS = (ContextMenuStrip) myTSMI.GetCurrentParent();
            ListView myListView = (ListView) myCMS.SourceControl;

            try
            {
                if( 0 < myListView.SelectedItems.Count )
                {
                    ListViewItem selectedItem = myListView.SelectedItems[ 0 ];
                    String fullPath = selectedItem.SubItems[ 4 ].Text;
                    System.Diagnostics.Process.Start( fullPath );
                }
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }
        

        private void tsmiOuvrirDossier_Click( object sender, EventArgs e )
        {
            ToolStripMenuItem myTSMI = (ToolStripMenuItem) sender;
            ContextMenuStrip myCMS = (ContextMenuStrip) myTSMI.GetCurrentParent();
            ListView myListView = (ListView) myCMS.SourceControl;

            try
            {
                if( 0 < myListView.SelectedItems.Count )
                {
                    ListViewItem selectedItem = myListView.SelectedItems[ 0 ];
                    String fullPath = selectedItem.SubItems[ 4 ].Text;
                    // System.Diagnostics.Process.Start( Path.GetDirectoryName( fullPath ));
                    System.Diagnostics.Process.Start( "explorer.exe", @"/select, " + fullPath );
                }
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }

#endregion
    }
}
