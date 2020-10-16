
    function Check()
    {
        var login = document.getElementById('inputId').value;
        var mdp = document.getElementById('inputMdp').value;
        if(login == "" && mdp == "")
        {
            alert("Veuillez entrer des données svp");
        }
        else if (login == "")
        {
            alert("Veuillez entrer un identifiant svp");
        }
        else if(mdp == "")
        {
            alert("Veuillez entrer un mot de passe svp");
        }

    }
