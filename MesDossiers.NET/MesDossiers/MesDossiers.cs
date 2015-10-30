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
#region Variables d'instance

        private string _nomRacineGauche = null;
        private string _nomRacineDroite = null;

        private List<FileInfo> _listeGauche = null;
        private List<FileInfo> _listeDroite = null;

        private List<FileInfo> _listeUniquesGauche = null;
        private List<FileInfo> _listeUniquesDroite = null;
        private List<FileInfo> _listeDoublons = null;

#endregion
#region Propriétés

        

#endregion
#region Constructeurs

        public MesDossiers( string nomRacineGauche, string nomRacineDroite )
        {
            this._nomRacineGauche = nomRacineGauche;
            this._nomRacineDroite = nomRacineDroite;
        }

#endregion
#region Méthodes privées d'instance

        private bool contient( List<FileInfo> liste, FileInfo fichier, bool compareNom, bool compareTaille, bool compareDate )
        {
            foreach( FileInfo elt in liste )
            {
                if(( ! compareNom    || elt.Name == fichier.Name )
                 &&( ! compareTaille || elt.Length == fichier.Length )
                 &&( ! compareDate   || elt.LastWriteTimeUtc.Equals( fichier.LastWriteTimeUtc )))
                    return true;
            }
            
            return false;
        }

        private List<string> convertir( List<FileInfo> listeFileInfos )
        {
            List<string> listeChaines = new List<string>();

            foreach( FileInfo info in listeFileInfos )
            {
                listeChaines.Add( info.Name );
            }

            return listeChaines;
        }

#endregion
#region Méthodes publiques d'instance

        public void calculer( bool compareNom, bool compareTaille, bool compareDate, string exclure = "" )
        {
            if( !( compareNom || compareTaille || compareDate ) )
                throw new Exception( "Un critère de comparaison est nécessaire au minimum" ); 

            this._listeGauche = getListeFileInfos( new DirectoryInfo( this._nomRacineGauche ) );
            this._listeDroite = getListeFileInfos( new DirectoryInfo( this._nomRacineDroite ) );

            this._listeDoublons = new List<FileInfo>();
            this._listeUniquesGauche = new List<FileInfo>();
            this._listeUniquesDroite = new List<FileInfo>();

            foreach( FileInfo fichier in this._listeGauche )
            {
                if( 0 == exclure.Length || 0 > fichier.FullName.IndexOf( exclure ) )
                {
                    if( contient( this._listeDroite, fichier, compareNom, compareTaille, compareDate ) )
                    {
                        this._listeDoublons.Add( fichier );
                    }
                    else
                    {
                        this._listeUniquesGauche.Add( fichier );
                    }
                }
            }

            foreach( FileInfo fichier in this._listeDroite )
            {
                if( 0 == exclure.Length || 0 > fichier.FullName.IndexOf( exclure ) )
                {
                    if( contient( this._listeGauche, fichier, compareNom, compareTaille, compareDate ) )
                    {
                        if( !contient( this._listeDoublons, fichier, compareNom, compareTaille, compareDate ) )
                            throw new Exception( "Doublon non détecté !?" );
                    }
                    else
                    {
                        this._listeUniquesDroite.Add( fichier );
                    }
                }
            }
        }

        public List<FileInfo> getListeFileInfos( DirectoryInfo racine = null )
        {
            if( null == racine )
                racine = new DirectoryInfo( this._nomRacineGauche );

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


        public List<FileInfo> getListeFileInfoUniquesGauche()
        {
            return this._listeUniquesGauche;
        }

        public List<FileInfo> getListeFileInfoUniquesDroite()
        {
            return this._listeUniquesDroite;
        }

        public List<FileInfo> getListeFileInfoDoublons()
        {
            return this._listeDoublons;
        }

        public List<string> getListeStringUniquesGauche()
        {
            return convertir( this._listeUniquesGauche );
        }

        public List<string> getListeStringUniquesDroite()
        {
            return convertir( this._listeUniquesDroite );
        }

        public List<string> getListeStringDoublons()
        {
            return convertir( this._listeDoublons );
        }

        /*public List<string> GetListe()
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
        }/*/

        /*public static void getDoublonsUniques( List<string> listeGauche, List<string> listeDroite, out List<string> listeUniquesGauche, out List<string> listeUniquesDroite, out List<string> listeDoublons )
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
                    if( !listeDoublons.Contains( fichier ) )
                        throw new Exception( "Doublon non détecté" );
                }
                else
                {
                    listeUniquesDroite.Add( fichier );
                }
            }
        }*/

#endregion
    }
}
