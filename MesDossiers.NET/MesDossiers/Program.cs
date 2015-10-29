using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesDossiers
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new InterfaceMesDossiers() );
        }

        /// <summary>
        /// Displays all exceptions the same way
        /// </summary>
        /// <param name="ex">The exception to display</param>
        public static void DisplayException( Exception ex )
        {
            MessageBox.Show(
                ex.GetType() + " : " + ex.Message + "\n" + ex.StackTrace,
                "Erreur : " + ex.Source,
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1
            );

            if( ex.InnerException != null &&
              DialogResult.Yes == MessageBox.Show( "Plus d'information disponible. Afficher ?", "'InnerException' trouvée", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ) )
                DisplayException( ex.InnerException );
        }
    }
}
