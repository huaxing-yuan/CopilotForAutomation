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
Utiliser moins d'attribute que possible (permet d'identifier un element de facon unique)

Vous allez déclarer un page model par page dans le dossier "PageModels" et utiliser le page model dans le script.


# WebElementDescription Pour Les Élements sur une page web

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


# Exemple d'un WebElementDescirption en C# si utiliser individuellement :
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


# Ensuite, Organiser les élements d'une page dans un Page Model
WebElementDescription peut être utilisé pour créer des classes Page Model.
Chaque WebElementDescription est un propriété (get, set).
Exemple : CalculatorPage est le modèle utilisé pour tester une application calculatrice, qui hérite de la classe PageModel.
```csharp
using OpenQA.Selenium;
using AxaFrance.WebEngine.MobileApp;
namespace MyApplication.PageModels {
    public class CalculatorPage : PageModel
    {
        public WebElementDescription Digit0 {get; set;} = new WebElementDescription
        {
            Id = "digit0"
        };

        public WebElementDescription Equals {get; set;} = new WebElementDescription
        {
            Id = "symbol_equal"
        };

        public WebElementDescription Multiply {get; set;} = new WebElementDescription
        {
            ClassName = "action",
            Name = "Multiply"
        };

        public CalculatorPage(WebDriver driver) : base(driver)
        {
        }
    }
}
```

En mode PageModel, nous utilisons WebDriver et non pas IWebDriver.
Pas besoin de passer le driver au constructeur de chaque WebElementDescription, car le PageModel s'en charge.
----------------------------------------

Si tout est clair, dites-moi OK, on va commencer à automatiser le test !


---------------
Prompt 2
---------------
Implementer le scenario: Login Step Definitions se trouve ici: #.....
voici le html du page Login: 
```html
<div class="align-self-center container" style="margin: 50px auto 50px auto; padding: 20px; border: 2px solid; border-radius: 20px">
        <h1 class="h1 text-success">Login</h1>
        <div style="margin: 5px">
            <span style="width: 100px; display:inline-block">Login: </span><input type="text" name="login">
        </div>
        <div style="margin: 5px">
            <span style="width: 100px; display: inline-block">Password: </span><input type="password" name="password">
        </div>
        <div class="alert-danger" id="errorMessage" style="display: none">
        </div>
        <div>
            <button>Forget password</button>
            <button onclick="login()">Login</button>
        </div>
    </div>
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




