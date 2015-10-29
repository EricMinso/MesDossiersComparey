 
import argparse
import logging
import os
import os.path
import sys


#ENCODING="ISO-8859-15"
ENCODING="utf-8"

EXTENSION=".txt"


"""
Point d'entree
"""
def main( args ):

	# Parsage des arguments
	parser = argparse.ArgumentParser( description='Diff' )
	parser.add_argument( '-e', '--exclure',	required=False,	help='Pattern de fichiers a exclure' )
	parser.add_argument( '-n', '--nom',		required=False,	help='Nom du test' )
	parser.add_argument( '-d', '--dir',		required=False, help='La reference' )
	parser.add_argument( '-s', '--subset',	required=True,	help='Le sous-ensemble' )
	arguments = parser.parse_args()

	# Fichier sortie
	nomFichierDoublons = 'liste.doublons.' + arguments.nom + EXTENSION	if arguments.nom else 'liste.doublons' + EXTENSION
	nomFichierUniques  = 'liste.uniques.'  + arguments.nom + EXTENSION	if arguments.nom else 'liste.uniques'  + EXTENSION

	nbArgs = len( args ) - 1
	
	# Dossier de travail
	dossierRacine = arguments.dir    if arguments.dir    else os.getcwd()
	dossierSubset = arguments.subset if arguments.subset else None

	# Ensembles
	setRacine = set()
	# setSubset = set()
	setDoublons = set()
	setUniques  = set()

	# Parcours arborescence reference
	for dirpath, dirnames, filenames in os.walk( dossierRacine ):					
		for filename in filenames:
			if not( arguments.exclure and( arguments.exclure in filename or arguments.exclure in dirpath )):
				setRacine.add( filename )

	# Parcours sous-ensemble
	for dirpath, dirnames, filenames in os.walk( dossierSubset ):					
		for filename in filenames:
			if not( arguments.exclure and( arguments.exclure in filename or arguments.exclure in dirpath )):
				if filename in setRacine:
					setDoublons.add( filename )
				else:
					setUniques.add( filename + '\t;\t' + dirpath + os.sep + filename )

	listeDoublons = list()
	listeUniques  = list( setUniques  )

	# Parcours arborescence reference
	for dirpath, dirnames, filenames in os.walk( dossierRacine ):					
		for filename in filenames:
			if filename in setDoublons:
				listeDoublons.append( filename + '\t;\t' + dirpath + os.sep + filename )

	listeDoublons.sort()
	listeUniques.sort()

	# Fichiers presents simultanement dans le sous-ensemble et dans la reference
	with open( nomFichierDoublons, mode='w', encoding=ENCODING ) as fichierDoublons:
		message = "%d fichiers presents dans les deux dossiers"%( len( listeDoublons ))
		print( message )
		fichierDoublons.write( "%s\n"%message )
		
		for filename in listeDoublons:
			fichierDoublons.write( "%s\n" % filename )
	
	# Fichiers du sous-ensemble absents de la reference
	with open( nomFichierUniques, mode='w', encoding=ENCODING ) as fichierUniques:
		message = "%d fichiers uniquement dans le sous-ensemble %s"%( len( listeUniques ), dossierSubset )
		print( message )
		fichierUniques.write( "%s\n"%message )
		
		for filename in listeUniques:
			fichierUniques.write( "%s\n" % filename )

	print( "Resultats ecrits" )


# Execute la fonction main, seulement si le script est appele directement, et non pas depuis un autre script
if( __name__ == "__main__" ):
	main( sys.argv )
	
