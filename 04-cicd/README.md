**Regel 1**: Hier wordt de naam van de workflow gedefinieerd. Dit is ook de naam die aan de linkerkant op de GitHub Actions pagina wordt weergegeven. Het is dus belangrijk dat je bij het zien van de naam direct weet waarvoor het script dient. 

**Regel 3-7**: Hier wordt aangegeven wanneer het script in werking gezet wordt. In deze situatie is dat dus, bij een push, of pull request in elke branch.

**Regel 9**: Hier worden “jobs” gedefinieerd. Jobs zijn eigenlijk niets meer dan een selectie stappen die opeenvolgend worden uitgevoerd, op dezelfde runner (een server die de workflows uitvoert).

**Regel 10**: Hier wordt de naam van de job gedefinieerd. In dit geval is de naam “build”

**Regel 12**: Hier wordt aangegeven op welk besturingssysteem de runner moet draaien. Er is keuze tussen Windows, MacOS en Linux. In dit geval is er gekozen voor Linux, specifiek de meest recente Ubuntu-versie.

**Regel 14**: Vanaf hier worden er stappen gedefinieerd.

**Regel 15-21**: Dit is een Discord feedback pipeline. Dit specifieke gedeelte stuurt een bericht in een discordserver dat aangeeft dat de workflow gestart is. (Zie Afbeelding 5). Ook is het gebruik van secrets hier te zien. Het is ook mogelijk om een naam in te stellen voor de bot, en de kleur van het bericht.

**Regel 23-24**: Hier wordt de stap “Checkout” gedefinieerd. Checkout zorgt ervoor dat de workflow toegang krijgt tot de repository.

**Regel 26-29**: Hier wordt .NET opgezet. In ons geval is het .NET 6.

**Regel 31-32**: Hier worden de “dependencies gerestored”. Dit wil zeggen dat de benodigde libraries, aan de hand van NuGet, gedownload worden indien deze missen. NuGet is de package manager die normaliter gebruikt wordt door .NET applicaties.

**Regel 34-35**: Hier wordt de applicatie gebuild met de voorheen verzamelde libraries. Er is een “no-restore” modifier meegegeven. Dit houdt in dat de benodigde libraries niet opnieuw gedownload worden, dit is tenslotte niet nodig aangezien dit in de vorige stap is gebeurd. Het is belangrijk om dit in verschillende stappen te hebben, indien een probleem zich voordoet.

**Regel 37-38**: Hier wordt de applicatie getest aan de hand van de unit testing methodiek. De verbosity modifier bepaalt wat er in de log weergeven wordt. Het “normal” level weergeeft alle display errors, waarschuwingen, events met hoog belang, sommige status events en een build samenvatting. De “no-build” modifier is meegegeven zodat de applicatie niet opnieuw gebouwd wordt. Dit is in de vorige stap al gebeurd.

**Regel 40-48**: Hier wordt mogelijk nog een bericht in de discord server gestuurd. Zoals te zien op de afbeelding wordt er hier gebruikgemaakt van een if statement. Dit if statement zorgt ervoor dat deze stap zich alleen uitvoert indien alle voorgaande stappen succesvol zijn geweest. 

