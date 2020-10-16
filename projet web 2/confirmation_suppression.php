<?php
require_once("script_securite.php");
$id = $_GET['id'];


?>

<html lang="fr">
<head>
    <meta charset = "utf-8">
    <link rel="stylesheet" type="text/css" href="./css/monStyle.css">
    <link rel="stylesheet" type="text/css" href="./css/profile.css">
    <link rel="stylesheet" type="text/css" href="./css/style.css">
    <link rel="stylesheet" type="text/css" href="./css/card.css">

    <link rel="stylesheet" href="./css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <script src="https://unpkg.com/react@16/umd/react.production.min.js"></script>
    <script src="https://unpkg.com/react-dom@16/umd/react-dom.production.min.js"></script>
    <script src="https://unpkg.com/babel-standalone@6.15.0/babel.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular.min.js"></script>



    <title>Suppression</title>

</head>

<body>
<?php require_once('navbar_site.php') ?>

<div>
    <br/>
    <h4 class = " pacific blanco text-center">Etes vous sur de vouloir supprimer ?</h4>
    <div class="text-center py-3 d-flex justify-content-around">
        <a href = "suppression.php?id=<?= $id?>" class = "btn btn-primary pacific">Oui</a>
        <a href = "accueil.php" class = "btn btn-primary pacific">Non</a>
    </div>

</div>
</body>