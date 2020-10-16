<?php require_once ('script_securite.php') ?>
<html lang="fr">
<head>
    <meta charset = "utf-8">
    <link rel="stylesheet" type="text/css" href="./css/monStyle.css">
    <link rel="stylesheet" type="text/css" href="./css/profile.css">
    <link rel="stylesheet" type="text/css" href="./css/style.css">
    <link rel="stylesheet" type="text/css" href="./css/card.css">
    <link rel="stylesheet" type="text/css" href="./css/bootstrap-select.min.css">

    <link rel="stylesheet" href="./css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <script src="https://unpkg.com/react@16/umd/react.production.min.js"></script>
    <script src="https://unpkg.com/react-dom@16/umd/react-dom.production.min.js"></script>
    <script src="https://unpkg.com/babel-standalone@6.15.0/babel.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular.min.js"></script>



    <title>Accueil</title>

</head>

<body>
<?php require_once("navbar_site.php"); ?>


<br>

        <nav class="navbar navbar-light bg-light py-3 d-flex justify-content-around">
            <a class="navbar-brand" href="#" onclick = Test()>
                <img src="./images/internet.png" width="30" height="30" class="d-inline-block align-top" alt="">
                Accueil
            </a>

            <a class="navbar-brand" href="#" onclick = Image()>
                <img src="./images/plus.png" width="30" height="30" class="d-inline-block align-top" alt="">
                Ajouter une image
            </a>

            <a class="navbar-brand" href="#" onclick = Disconnect()>
                <img src="./images/logout.png" width="30" height="30" class="d-inline-block align-top" alt="">
                Se deconnecter
            </a>
        </nav>
    <br>
    <br>

        <div id = "root">

        </div>



</body>
<script>
    function Test() {


                    xmlhttp = new XMLHttpRequest();

                    xmlhttp.onreadystatechange=function() {
                        if (this.readyState==4 && this.status==200) {
                            document.getElementById("root").innerHTML=this.responseText;
                        }
                    };
                    xmlhttp.open("GET","aff_photo.php",true);
                    xmlhttp.send();



    }

</script>

<script type="text/babel">
    function Disconnect (){
        class Hello extends React.Component {
            render() {
                return (
                    <div>
                        <h4 class = " pacific blanco text-center">Etes vous sur de vouloir vous déconnecter ?</h4>
                        <div class="text-center py-3 d-flex justify-content-around">
                            <a href = "deconnexion.php" class = "btn btn-primary pacific">Oui</a>
                            <a href = "accueil.php" class = "btn btn-primary pacific">Non</a>
                        </div>

                    </div>
                )

            }
        }
        ReactDOM.render(<Hello/>, document.getElementById('root'));
    }

</script>

<script type ="text/babel">
    function Image() {
        class Hello extends React.Component {
            render() {
                return (
                    <div class = "container card">
                        <form method = "POST" enctype="multipart/form-data" >
                            <br/>
                            <h4 class = "text-center pacific">Veuillez inserer une image</h4>
                            <br/>
                            <div class="form-group row align-content-lg-center">
                                <label class = "pacific ">Image</label>
                                <input class = "centre" type = "file" name = "image"/>


                            </div>
                            <br/>
                            <div class="form-group row align-content-lg-center">
                                <label class = "pacific">Lieu</label>
                                <div class = "input-group col-md-4 centre">
                                    <input class = "form-control" type = "text" name = "endroit"/>
                                </div>
                            </div>
                            <br/>
                            <div class="form-group row py-3 d-flex justify-content-around">
                                <label class = "pacific">Photo prise à l'endroit actuel ?</label>

                                <input class = "form-control" type = "radio" name = "ici"/>

                            </div>
                            <br/>
                            <div class="form-group row py-3 d-flex justify-content-around">
                                <button type="submit" class="btn btn-secondary pacific">Inserer</button>
                            </div>

                            <br/>


                        </form>
                    </div>



                )

            }
        }

        ReactDOM.render(<Hello/>, document.getElementById('root'));



    }
</script>


</html>