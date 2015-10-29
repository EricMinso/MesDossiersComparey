using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace MesDossiers
{
    public class MesDossiers
    {
#region static

        public static void getDoublonsUniques( List<string> listeGauche, List<string> listeDroite, out List<string> listeUniquesGauche, out List<string> listeUniquesDroite, out List<string> listeDoublons )
        {
            listeDoublons = new List<string>();
            listeUniquesGauche = new List<string>();
            listeUniquesDroite = new List<string>();

            foreach( string fichier in listeGauche )
            {
                if( listeDroite.Contains( fichier ) )
                {
                    listeDoublons.Add( fichier );
                }
                else
                {
                    listeUniquesGauche.Add( fichier );
                }
            }

            foreach( string fichier in listeDroite )
            {
                if( listeGauche.Contains( fichier ) )
                {
                    if( !listeDoublons.Contains( fichier ))
                        throw new Exception( "Doublon non détecté" );
                }
                else
                {
                    listeUniquesDroite.Add( fichier );
                }
            }
        }

        public static List<string> convertToString( List<FileInfo> listeFileInfos )
        {
            List<string> listeChaines = new List<string>();

            foreach( FileInfo info in listeFileInfos )
            {
                listeChaines.Add( info.Name );
            }

            return listeChaines;
        }

#endregion
#region instance

        private string _nomRacine;

        public MesDossiers( string nomRacine )
        {
            this._nomRacine = nomRacine;
        }

        public List<FileInfo> getListeFileInfos( DirectoryInfo racine = null )
        {
            if( null == racine )
                racine = new DirectoryInfo( this._nomRacine );

            DirectoryInfo[] subDirs = racine.GetDirectories();
            List<FileInfo> listeFichiers = new List<FileInfo>();

            try
            {
                listeFichiers.AddRange( racine.GetFiles() );

                foreach( DirectoryInfo subdir in subDirs )
                    listeFichiers.AddRange( getListeFileInfos( subdir ) );

                return listeFichiers;
            }
            catch( Exception )
            {
                return new List<FileInfo>();
            }
        }

        public List<string> GetListe()
        {
            try
            {
                List<string> listeNomFichiers = new List<string>();
                List<FileInfo> listeFichiers = getListeFileInfos( new DirectoryInfo( this._nomRacine ));

                foreach( FileInfo fichier in listeFichiers )
                    listeNomFichiers.Add( fichier.FullName );

                return listeNomFichiers;
            }
            catch( Exception )
            {
                return new List<string>();
            }
        }
    }

#endregion
}
