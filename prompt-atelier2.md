# ATELIER 2 : DONNER DU CONTEXTE

-----------------
Prompt 1
-----------------

Vous allez m'aider à générer des scripts d'automatisation basés sur Selenium et le Framework WebEngine.
J'utilise l'approche BDD avec ReqnRoll (qui remplace SpecFlow).

Pour le script, veuillez prendre en compte la consigne suivante :

# Pour initialiser un nouveau driver, utiliser BrowserFactory:
var driver = BrowserFactory.GetDriver(AxaFrance.WebEngine.Platform.Windows, AxaFrance.WebEngine.BrowserType.ChromiumEdge);
dans le code, tu peux importer le namespace et utiliser le nom de class court

Vous allez instantier une nouvelle instance de driver au debut de chaque scenario et le détruire à la fin de chaque test.


# Ne pas utiliser FindElement directement, mais utiliser la mécanique des ElementDescription et PageModel.

ElementDescription permet de décrire comment trouver un objet dans l'application.
Pour une page Web, on utilise la classe WebElementDescription. Vous pouvez combiner un ou plusieurs attributs pour identifier l'élément de façon sûre et unique.

Vous allez déclarer un page model par page dans le dossier "PageModels" et utiliser le page model dans le script.


# WEBELEMENTDESCRIPTION POUR LES ÉLÉMENTS SUR UNE PAGE WEB

La classe WebElementDescription possède les propriétés (avec get; set;) suivantes :

 * ClassName : équivalent à l’attribut HTML "class". Le nom de classe peut contenir des espaces.
 * CssSelector : utiliser le sélecteur CSS pour localiser l’élément Web.
 * Id : équivalent à l’attribut HTML "id".
 * InnerText : le texte à l’intérieur de la balise HTML.
 * LinkText : le texte d’un lien hypertexte HTML (habituellement dans la balise <a>).
 * Name : équivalent à l’attribut HTML "name".
 * TagName : le nom de la balise HTML, ex : div, a, input, ...
 * XPath : utiliser XPath pour localiser l’élément Web.
 * Attributes : tout attribut HTML standard ou non-standard.
 * Attributes.Name : le nom de l’attribut.
 * Attributes.Value : la valeur de l’attribut.


# EXEMPLE D'UN WEBELEMENTDESCRIPTION EN C# :
```csharp
using AxaFrance.WebEngine.Web;
using AxaFrance.WebEngine;

// Identifier un élément par Id
var SelectLanguage = new WebElementDescription(driver)
{
    Id = "language"
};

// Identifier un élément par plusieurs localisateurs
var SelectLanguage = new WebElementDescription(driver)
{
    TagName = "div",
    ClassName = "class1 class2"
};

// Identifier un élément par des attributs DOM personnalisés
var customDiv = new WebElementDescription(driver)
{
    Attributes = new HtmlAttribute[]
    {
        new HtmlAttribute("custom_name", "scroll_intoview"),
    }
};
```

# Actions
WebElementDescription expose des methodes suivant pour interagir avec l'élement:
* Click()
* SendKeys(string)
* SetValue(string)
* SetSecure(string) - Set the value of a password textbox
* Exists()
* Clear()
* MouseHover()
* ScrollIntoView()
* SelectByIndex(int) - Select an option from html tag <select> by its displayed text.
* SelectByText(string) - Select an option from html tag <select> by its displayed text.
* SelectByValue(string) - Select an option from html tag <select> by its value.
* CheckByValue(string) - Checks an RadioButton from a given RadioGroup (used for radio button group, <input type="radio"> elements)


# ENSUITE, ORGANISER LES ÉLÉMENTS D'UNE PAGE DANS UN PAGE MODEL
WebElementDescription peut être utilisé pour créer des classes Page Model.

Exemple : CalculatorPage est le modèle utilisé pour tester une application Android, qui hérite de la classe PageModel.
Pour tester des applications Web, ajoutez des WebElementDescription à la place de AppElementDescription.
```csharp
using OpenQA.Selenium;
using AxaFrance.WebEngine.MobileApp;

public class CalculatorPage : PageModel
{
    public AppElementDescription Digit0 {get;set;} = new AppElementDescription
    {
        Id = "com.Android.calculator2:id/digit_0"
    };

    public AppElementDescription Equals {get;set;} = new AppElementDescription
    {
        Id = "com.Android.calculator2:id/eq"
    };

    public AppElementDescription Multiply {get;set;} = new AppElementDescription
    {
        ClassName = "Android.widget.Button",
        AccessbilityId = "multiply"
    };

    public CalculatorPage(WebDriver driver) : base(driver)
    {
    }
}
```

En mode Page, nous utilisons WebDriver et non pas IWebDriver.

----------------------------------------

Si tout est clair, dites-moi OK, on va commencer à automatiser le test !


---------------
Prompt 2
---------------
Implementer le scenario: Login Step Definitions se trouve ici: #.....
voici le html du page Login: 
```html
coller le html du page login ici
```


---------------
Prompt 3
---------------
Continue implementer le scénario. voici le html du page cherche prospect:
```html
coller le html du page cherche prospect ici
```


---------------
Prompt 4
---------------
maintenant la derniere partie: remplir le formulaire:
```html
coller le html du page formulaire ici
```




