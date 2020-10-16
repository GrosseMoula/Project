<html lang="fr">
<head>
    <meta charset = "utf-8">
    <link rel="stylesheet" type="text/css" href="./css/monStyle.css">
    <link rel="stylesheet" type="text/css" href="./css/forms.css">
    <link rel="stylesheet" href="./css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">

    <script src="https://unpkg.com/react@16/umd/react.production.min.js"></script>
    <script src="https://unpkg.com/react-dom@16/umd/react-dom.production.min.js"></script>
    <script src="https://unpkg.com/babel-standalone@6.15.0/babel.min.js"></script>

    <title>Connexion</title>

</head>

<body>

<?php require_once ("en_tete_site.php") ?>

<div class="container">
    <div class="d-flex justify-content-center h-100">
        <div class="card">
            <div class="card-header">
                <h3 class = "pacific text-center">Connexion</h3>
            </div>
            <div class="card-body">
                <form method = post action = "./code_connexion.php">
                    <div class="input-group form-group">
                        <div class="input-group-prepend">
                            <span class="input-group-text"><i class="fas fa-user"></i></span>
                        </div>
                        <input id = "inputId"type="text" class="form-control pacific" placeholder="Login" name = "login">

                    </div>
                    <br/>
                    <div class="input-group form-group">
                        <div class="input-group-prepend">
                            <span class="input-group-text"><i class="fas fa-key"></i></span>
                        </div>
                        <input id = "inputMdp" type="password" class="form-control pacific" placeholder="Mot de passe" name = "mdp">
                    </div>
                    <br/>
                    <br/>
                    <div class="form-group">
                        <input type="submit" value="Connexion" onclick = "Check()" class="blanco btn float-right login_btn pacific">
                    </div>
                </form>
            </div>
            <div class="card-footer">
                <div class="d-flex justify-content-center links pacific">
                    Toujours pas inscrit ? <a href="inscription.php">Inscription</a>
                </div>

            </div>
        </div>
    </div>
</div>

<div id = "root">

</div>



<script src = "./check.js">
</script>

<script type="text/babel">
    function AddForms() {
        class Hello extends React.Component {
            render() {
                return (
                    <form method="POST" action="inscription_code.php">
                        <div class="container row register-form align-content-center">
                            <div class="form">
                                <div class="note">
                                    <p class="pacific">Veuillez vous inscrire</p>
                                </div>
                                <div class="form-content">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <input type="text" class="form-control pacific" placeholder="Veuillez choisir un login" name="login"/>
                                                <br/>
                                                <input type="text" class="form-control pacific" placeholder="Votre nom" name = "nom"/>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <input type="password" class="form-control pacific" placeholder="Veuillez choisir un mot de passe" name="mdp"/>
                                                <br/>
                                                <input type="text" class="form-control pacific" placeholder="Votre prénom" name = "prenom"/>
                                            </div>
                                        </div>
                                        <div class="col-md-6 text-center">
                                            <div class="form-group">
                                                <input type="text" class="form-control pacific" placeholder="Votre email" name = "email"/>
                                            </div>
                                        </div>



                                    </div>
                                    <div className="col-md-6 text-center">
                                        <div className="form-group">
                                            <button type="submit" class = "btn-primary mb-2 my-sm-0 pacific"
                                                    placeholder="inscription">Inscription
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </form>


                )

            }
        }

        ReactDOM.render(<Hello/>, document.getElementById('root'));
    }

</script>





</body>

</html>
