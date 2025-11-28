Feature: Pouvoir souscrire une assurance habitation

Scenario: Login 
    Given je suis sur la page de connexion
    When je saisis "john.doe@example.com" dans le champ login
    And je saisis "password123" dans le champ password
    And je clique sur le bouton Login
    Then je suis redirigé vers la page de sélection du prospect


Scenario: Souscrire une assurance habitation pour un appartement
    Given je suis sur la page de connexion
    When je saisis "john.doe@example.com" dans le champ login
    And je saisis "password123" dans le champ password
    And je clique sur le bouton Login
    Then je suis redirigé vers la page de sélection du prospect
    
    When je saisis "12345" dans le champ de recherche par identifiant client
    And je clique sur le bouton Next Step
    Then je suis redirigé vers la page de remplissage des détails du logement
    
    When je remplis l'adresse du logement avec les informations suivantes:
        | Champ         | Valeur          |
        | Street Number | 15              |
        | Street Name   | Rue de la Paix  |
        | City          | Paris           |
        | Post Code     | 75001           |
        | Region        | Île-de-France   |
        | Country       | France          |
    And je sélectionne "Apartment" comme type de logement
    And je remplis les détails de l'appartement avec les informations suivantes:
        | Champ                           | Valeur |
        | Total floors of the building    | 4to7   |
        | Your apartment is at (x)th floor| 3      |
        | Do you have an elevator         | yes    |
        | Number of rooms                 | 3      |
        | Surface (sq meters)             | 75     |
    And je clique sur le bouton Next Step
    Then je suis redirigé vers la page suivante du processus de souscription