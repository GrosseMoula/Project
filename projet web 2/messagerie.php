<?php

require_once ('script_securite.php') ?>
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



    <title>Messagerie</title>

</head>
<body>
<?php require_once("navbar_site.php"); ?>


<br>
<nav class="navbar navbar-light bg-light py-3 d-flex justify-content-around">
    <a class="navbar-brand" href="#" onclick = "Reception()">
        <img src="./images/internet.png" width="30" height="30" class="d-inline-block align-top" alt="">
        Messages reçus
    </a>

    <a class="navbar-brand" href="#" onclick = "Envoyer()" >
        <img src="./images/plus.png" width="30" height="30" class="d-inline-block align-top" alt="">
        Envoyer un message
    </a>

    <a class="navbar-brand" href="#" onclick = "Envoie()">
        <img src="./images/logout.png" width="30" height="30" class="d-inline-block align-top" alt="">
        Messages envoyés
    </a>
</nav>
<br>
<br>

<div id = "root">

</div>



<script>
    function Reception() {


        xmlhttp = new XMLHttpRequest();

        xmlhttp.onreadystatechange=function() {
            if (this.readyState==4 && this.status==200) {
                document.getElementById("root").innerHTML=this.responseText;
            }
        };
        xmlhttp.open("GET","aff_msg_recu.php",true);
        xmlhttp.send();



    }

</script>

<script>
    function Envoie() {


        xmlhttp = new XMLHttpRequest();

        xmlhttp.onreadystatechange=function() {
            if (this.readyState==4 && this.status==200) {
                document.getElementById("root").innerHTML=this.responseText;
            }
        };
        xmlhttp.open("GET","aff_msg_envoye.php",true);
        xmlhttp.send();



    }

</script>

<script>
    function Envoyer() {


        xmlhttp = new XMLHttpRequest();

        xmlhttp.onreadystatechange=function() {
            if (this.readyState==4 && this.status==200) {
                document.getElementById("root").innerHTML=this.responseText;
            }
        };
        xmlhttp.open("GET","aff_forms_msg.php",true);
        xmlhttp.send();



    }

</script>

</body>



