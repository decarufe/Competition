# language en
Feature: Inscription
	Afin de démarrer une compétition
	En tant qu'organisateur
	Je veux inscrire des partipants

Scenario: Inscription d'un nouveau participant
	Given Jow Blow n'est pas inscrit
	When Jow Blow s'inscrit
	Then Il doit fournir son "numéro de terrain"

