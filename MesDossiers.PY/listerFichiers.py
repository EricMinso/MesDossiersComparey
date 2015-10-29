 
import argparse
import logging
import os
import os.path
import sys


#ENCODING="ISO-8859-15"
ENCODING="utf-8"


def analyserDossier( dossierRacine ):

	setFichiers = set()
	setDoublons = set()

	# Ouverture des fichiers et parcours de l'arborescence
	with open( 'liste.arbo.txt', mode='w', encoding=ENCODING ) as fichierArbo:
		with open( 'liste.fichiers.txt', mode='w', encoding=ENCODING ) as fichierListe:
			with open( 'liste.doublons.txt', mode='w', encoding=ENCODING ) as fichierDoublons:

				for dirpath, dirnames, filenames in os.walk( dossierRacine ):
					fichierArbo.write( "dirpath = %s\n"%dirpath )
					fichierArbo.write( "dirnames = %s\n"%dirnames )
					fichierArbo.write( "filenames = %s\n"%filenames )
					
					for filename in filenames:
						if filename in setFichiers:
							setDoublons.add( filename )
						else:
							setFichiers.add( filename )
				
				listeFichiers = list( setFichiers )
				listeDoublons = list( setDoublons )
				
				listeFichiers.sort()
				listeDoublons.sort()
				fichierListe.write( "%d elements\n"%len( listeFichiers ))
				for filename in listeFichiers:
					fichierListe.write( "%s\n" % filename )
					
				fichierDoublons.write( "%d fichiers en doublon\n"%len( listeDoublons ))
				for filename in listeDoublons:
					fichierDoublons.write( "%s\n" % filename )

	print( "Resultats dans :\nliste.arbo.txt\nliste.fichiers.txt\nliste.doublons.txt\n" )


def comparerDossiers( dossierRacine, dossierCompare ):

	print( "Comparaison :\n%s\n%s\n"%( dossierRacine, dossierCompare ))
	setFichiers1 = set()
	setFichiers2 = set()
	setUniques1  = set()
	setUniques2  = set()
	setDoublons  = set()
	
	# Dossier 1
	for dirpath, dirnames, filenames in os.walk( dossierRacine ):					
		for filename in filenames:
			setFichiers1.add( filename )

	# Dossier 2
	for dirpath, dirnames, filenames in os.walk( dossierCompare ):					
		for filename in filenames:
			setFichiers2.add( filename )

	# Uniques dans 1
	for filename in setFichiers1:
		if filename in setFichiers2:
			setDoublons.add( filename )
		else:
			setUniques1.add( filename )
			
	# Uniques dans 2
	for filename in setFichiers2:
		if filename in setFichiers1:
			setDoublons.add( filename )
		else:
			setUniques2.add( filename )

	# Transformation en listes pour tri
	listeFichiers1 = list( setFichiers1 )
	listeFichiers2 = list( setFichiers2 )
	listeUniques1  = list( setUniques1  )
	listeUniques2  = list( setUniques2  )
	listeDoublons  = list( setDoublons  )

	# Tri
	listeFichiers1.sort()
	listeFichiers2.sort()
	listeUniques1.sort()
	listeUniques2.sort()
	listeDoublons.sort()

	# Ecriture Fichier 1
	with open( 'liste.fichiers1.txt', mode='w', encoding=ENCODING ) as fichierListe1:
		message = "%d elements pour %s"%( len( listeFichiers1 ), dossierRacine )
		print( message )
		fichierListe1.write( "%s\n"%message )
		
		for filename in listeFichiers1:
			fichierListe1.write( "%s\n" % filename )

	# Ecriture Fichier 2
	with open( 'liste.fichiers2.txt', mode='w', encoding=ENCODING ) as fichierListe2:
		message = "%d elements pour %s"%( len( listeFichiers2 ), dossierCompare )
		print( message )
		fichierListe2.write( "%s\n"%message )
		
		for filename in listeFichiers2:
			fichierListe2.write( "%s\n" % filename )

	# Doublons
	with open( 'liste.doublons.txt', mode='w', encoding=ENCODING ) as fichierDoublons:
		message = "%d fichiers en doublon\n"%len( listeDoublons )
		print( message )
		fichierDoublons.write( "%s\n"%message )
		
		for filename in listeDoublons:
			fichierDoublons.write( "%s\n" % filename )
	
	# Fichiers de 1 absents de 2
	with open( 'liste.uniques1.txt', mode='w', encoding=ENCODING ) as fichierListeUniques1:
		message = "%d fichiers uniquement dans %s"%( len( listeUniques1 ), dossierRacine )
		print( message )
		fichierListeUniques1.write( "%s\n"%message )
		
		for filename in listeUniques1:
			fichierListeUniques1.write( "%s\n" % filename )
	
	# Fichiers de 2 absents de 1
	with open( 'liste.uniques2.txt', mode='w', encoding=ENCODING ) as fichierListeUniques2:
		message = "%d fichiers uniquement dans %s"%( len( listeUniques2 ), dossierCompare )
		print( message )
		fichierListeUniques2.write( "%s\n"%message )
		
		for filename in listeUniques2:
			fichierListeUniques2.write( "%s\n" % filename )


	print( "Resultats ecrits" )



"""
Point d'entree
"""
def main( args ):

	# Parsage des arguments
	#parser = argparse.ArgumentParser( description='Diff' )
	#parser.add_argument( '-t', '--trier',	action=store_true		help='Le dossier de travail' )
	#parser.add_argument( '-o', '--output',							help='Le fichier sortie' )
	#parser.add_argument( '-d', '--dir',								help='Le dossier de travail' )
	#arguments = parser.parse_args()

	# Fichier sortie
	#nomFichierSortie = arguments.output if arguments.output else "listeFichiers.txt"
	
	nbArgs = len( args ) - 1
	
	# Dossier de travail
	dossierRacine  = args[1] if nbArgs >= 1 else os.getcwd()
	dossierCompare = args[2] if nbArgs == 2 else None

	if nbArgs == 2:
		comparerDossiers( dossierRacine, dossierCompare )
	
	else:
		print( "Analyse :\n%s\n"%( dossierRacine ))
		analyserDossier( dossierRacine )



# Execute la fonction main, seulement si le script est appele directement, et non pas depuis un autre script
if( __name__ == "__main__" ):
	main( sys.argv )
	
