# Exercice de l'atelier
## Prompt Simple:

Se positionner sur le fichier Program.cs
### Prompt 1: donner un prompt à Copilot pour automatiser le page login.
`Automatiser le page login avec user A89387 et password EF2vSK89`

### Prompt 2: Prompt avec le code HTML:
```
Automatiser le page login avec user A89387 et password EF2vSK89 sur Edge en utilisant le code HTML suivant:

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

Le code ne vérifie pas si le login est reussi. lui demander d'ajouter une assertion pour verifier que
### Prompt 2: Prompt pour assertion
```
le script ne verifie pas si le login est reussi.
Ajouter une assertion pour verifier que le message d'erreur de login n'est pas affiché
```