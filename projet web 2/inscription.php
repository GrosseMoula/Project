<html lang="fr">
<head>
    <meta charset = "utf-8">
    <link rel="stylesheet" type="text/css" href="./css/monStyle.css">
    <link rel="stylesheet" type="text/css" href="./css/registration.css">
    <link rel="stylesheet" href="./css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>

    <title>Inscription</title>

</head>

<body>

<?php require_once ("en_tete_site.php") ?>

<div class="container-fluid d-inline-flex p-2 blanco">
    <div class="container">
        <div class="formBox">
            <form method = "POST" action = "./inscription_code.php">
                <div class="row">
                    <div class="col-sm-12">
                        <h1 class = "pacific">Inscription</h1>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-12">
                        <div class="inputBox">
                            <div class="inputText pacific">Login</div>
                            <textarea class="input blanco pacific" name = "login"></textarea>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-6">
                        <div class="inputBox ">
                            <div class="inputText pacific">Nom</div>
                            <input type="text" name="nom" class="input  blanco pacific">
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="inputBox">
                            <div class="inputText pacific">Prénom</div>
                            <input type="text" name="prenom" class="input  blanco pacific">
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-6">
                        <div class="inputBox">
                            <div class="inputText pacific">Email</div>
                            <input type="text" name="email" class="input  blanco pacific">
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="inputBox">
                            <div class="inputText pacific">Mot de passe</div>
                            <input type="password" name="mdp" class="input  blanco pacific">
                        </div>
                    </div>
                </div>



                <div class="row py-3 d-flex justify-content-around">
                    <div class="col-sm-6">
                        <input type="submit" name="" class="button pacific" value="S'inscrire">
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>

<script src="https://code.jquery.com/jquery-3.2.1.js"></script>
<script type="text/javascript">
    $(".input").focus(function() {
        $(this).parent().addClass("focus");
    })
</script>
</body>
</html>



