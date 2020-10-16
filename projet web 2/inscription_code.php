<?php

    require_once('connexion_bd.php');

    $login = $_POST['login'];
    $mdp = md5($_POST['mdp']);
    $name = $_POST['nom'];
    $surname = $_POST['prenom'];
    $email = $_POST['email'];
    $role = "user";

    $ps = $pdo->prepare("INSERT INTO users (LOGIN,PASSWORD,NOM,PRENOM,EMAIL,ROLE) VALUES (?,?,?,?,?,?)");
    $params = array($login,$mdp,$name,$surname,$email,$role);
    $ps->execute($params);
    header('location:yes.php');
?>






