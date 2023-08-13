Er bestaan momenteel twee models in de applicatie: 
 - Game
 - Category


<h1>Game</h1>

Het game model bestaat uit de volgende variables:
 - Id
 - Name
 - Description
 - Link
 - ImageLink
 - CategoryId
 - Category


**Id**

Dit is de unieke identificatie van een game. Hiermee zal er op de achtergrond van de applicatie verwezen worden naar specifieke games.


**Name**

Dit is de weergeef naam van een game.


**Description**

Dit is de omschrijving van een game.


**Link**

Dit is de link naar de game. Alle games op de website zijn html games, deze worden gehost op websites en kunnen in je eigen pagina embedded worden. Dit is de link die embedded wordt.


**ImageLink**

Dit is de link van de foto die weergeven wordt voor een game. 


**CategoryID**

Hier wordt het ID opgeslagen van de category waar de game onder valt. Aan de hand van dit ID kan er in het programma gefilterd worden op categorieën.


**Category**

Dit is een variabel dat niet in de database opgeslagen wordt en slechts een link is binnen .NET naar het Category model. 



<h1>Category</h1>

Het game model bestaat uit de volgende variables:
 - Id
 - CategoryName
 - ShowInNav


**Id**

Dit is de unieke identificatie van een categorie. Hiermee zal er op de achtergrond van de applicatie verwezen worden naar specifieke categorieën.


**CategoryName**

Dit is de weergeef naam van een categorie.


**ShowInNav**

Aan de hand van dit variabel wordt bepaald of een categorie in de navigatiebalk op de website weergeven wordt.
