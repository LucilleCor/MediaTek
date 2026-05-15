# Application MediaTek : 
Application C# écrite sous Visual Studio 2022 Entreprise et exploitant une BDD MySQL.<br><br>

## Presentation de l'application 

### Présentation du contexte
L'entreprise InfoTech Services 86 est une Entreprise de Services Numériques (ESN) spécialisée dans le développement informatique (applications de bureau, web, mobile), l’hébergement de site web, l’infogérance, la gestion de parc informatique et l’ingénierie système et réseau. 
Elle répond régulièrement à des appels d’offres en tant que société d’infogérance et prestataire de services informatiques.<br>
InfoTech Services 86 vient de remporter le marché pour différentes interventions au sein du réseau MediaTek86, dont certaines dans le domaine du développement d'application.

### But de l'application 
L'application doit permettre de gérer le personnel de chaque médiathèque, leur affectation à un service et leurs absences.
Cette application est monoposte et sera installée sur un poste du service administratif. <br>
Les actions plus précises de cette application sont : 
<ul>
<li>présenter la liste du personnel (nom, prénom, tel, mail, service)</li>
<li>permettre d'ajouter un nouveau personnel</li>
<li>permettre de modifier ou supprimer un personnel déjà existant</li>
<li>présenter la liste des absences d'un personnel précis (date de début, date de fin et motif)</li>
<li>permttre d'ajouter une nouvelle absence</li>
<li>permettre de modifier ou supprimer une absence existante</li>
</ul>
Les listes des services et des motifs sont fixes et non modifiable via cette application.<br>

### Structure de la BDD
Voici le schéma conceptuel de données présentant la structure de la BDD qui est au format MySQL : <br>
<img width="428" height="393" alt="image" src="https://github.com/user-attachments/assets/f5d8d199-15c1-43bc-8602-e741b077fb86" />

### Interface 
Voici à quoi doit ressembler la fenêtre de l'application : <br>
<img width="852" height="743" alt="image" src="https://github.com/user-attachments/assets/1ee4f6b0-9577-400d-8d62-b9ca1874c0c6" />

### Diagramme de paquetage
L'application est structurée dans le respect du pattern MVC. <br>
<img width="1008" height="1008" alt="Diagramme de paquetage" src="https://github.com/user-attachments/assets/963fdb4f-93c1-4052-a03d-9da664fa0288" />
<br>
Voici le diagramme de paquetage à la fin du codage de cette application<br>
<img width="1016" height="1174" alt="Diagramme de paquetage + authentification" src="https://github.com/user-attachments/assets/3139065d-989a-4cbb-a6ae-9f9ca24f81e2" />

#### Explications sur les couches supplémentaires
L'application contient 2 paquetages supplémentaires par rapport au MVC classique :<br>
<ul>
<li> bddmanager : contient la classe qui permet d'accéder à la base de données MySQL et d'exécuter les requêtes (classe indépendante et réutilisable).</li><br>
<li> dal (Data Access Layer) : répond aux demandes du paquetage 'controller' et exploite 'bddmanager' en lui demandant d'exécuter des requêtes.</li>
</ul>
L'avantage de cette architecture est l'isolement de la connexion (bddmanager) par rapport au reste de l'application. Le controleur ne sait pas d'où viennent les données (cela pourrait être un autre SGBDR, voire un autre type de fichier, comme XML). Le paquetage 'dal' fait l'intermédiaire en préparant des requêtes SQL. Donc on sait dans les classes de ce paquetage, qu'il est question d'une base de données relationnelle, mais ne sait pas non plus quel est le SGBDR utilisé.<br>
Changer de SGBDR reviendrait à juste changer la classe BddManager (son contenu), donc ne travailler que sur le paquetage 'bddmanager'.<br>
Changer de type de fichier reviendrait à changer aussi les classes du paquetage 'dal', sans toucher au reste de l'application.<br>

#### Présentation du cheminement
L'application démarre sur une vue : c'est la structure classique des applications C# de bureau, mais il serait aussi possible de démarrer sur un contrôleur principal.<br>
La vue crée une instance du contrôleur qui lui est dédié (chaque vue a son propre contrôleur). Quand elle a besoin d'accéder aux données (affichage ou demande de modifications), elle fait appel à son contrôleur.<br>
Le contrôleur fait appel aux classes de la couche 'dal' pour exécuter les demandes de la vue.<br>
Les classes de la couche 'dal' contiennent les requêtes qui doivent être exécutées et sollicitent la couche 'bddmanager' pour exécuter les requêtes.<br>
Chaque classe de la couche 'dal' est liée à une classe métier contenu dans 'model'. Ces classes correspondent aux tables de la base de données (avec une approche objet, donc pas de clés étrangères mais des références d'objets) et ne contiennent que la structure des données (propriétés, getters, setters).
Excepté 'bddmanager' qui est indépendant de l'application (réutilisable dans n'importe quelle application), toutes les couches exploitent le 'model' (pour le formatage des données).<br>
## Etapes de construction
Les différents commits montrent la création de l'application étape par étape.<br>
### Commit "Etape 1 : Création du visuel des interfaces"
Construction de l'interface de chaque vues (Authentification et MediaTek)
### Commit "Etape 2 : Création des classes Modèle et  des classes pour accèder à la base de données"
La structure de l'application est créée. Les paquets Model et bddmanager sont crées et completés, le dal est crée mais seul la classe Access est crée.<br>
La classe BddManager (dans la paquetage bddmanager) est un singleton qui permet de se connecter à une BDD et d'exécuter des requêtes SQL.<br>
L'application n'est pas encore opérationnelle.<br>
### Commit "Etape 3 : Authentification, actions sur le personnel"
Ajout du package Controlleur, le diagramme de paquetage final est atteint. <br>
Codage de la fenêtre d'authentification qui limite la connexion pour seulement le personnel de la table responsable. La fenêtre d'authentification est opérationnelle mais non utilisée pour faciliter les tests pour le codage de la fenêtre MediaTek. <br>
Fonctionnalités pour le personnel sont ajoutés. La partie personnel de la fenêtre MediaTek est opérationelle. <br>
### Commit "Etape 4 : Gestion des absences et route utilisateur"
Codage du reste de la fenêtre MediaTek, placement de spécificité d'accès pour les utilisateurs (ex : ne pas pouvoir changer d'absence lors de la modification de l'une d'elle)
### Commit "Etape 5 : Installeur"
Création d'un installeur pour l'application, application entière est fonctionnelle.

## Installation
Il est possible de tester l'application étape par étape (commit par commit) ou de tester directement la version finale.<br>
Pour tester une version dans un environnement de développement, il faut d'abord installer les outils suivants :<br>
. SGBDR MySQL (par exemple en installant WAMP ou un logiciel similaire)<br>
. De préférence un IDE pour manipuler le code (cette application a été réalisée sous Visual Studio 2022)<br> 
Il faut ensuite :<br>
. Dans MySQL, exécuter le script contenu dans mediatek.sql (présent en racine du dépôt) pour créer et remplir la BDD.<br>
. Récupérer le code du commit voulu, l'ouvrir dans l'IDE et l'exécuter.
