<?php
require_once("connexion_bd.php");
require_once("script_securite.php");
$id = $_GET['id'];
$comm = $_POST['comm'];
$user = $_SESSION['PROFILE']['LOGIN'];



$ps = $pdo->prepare("INSERT INTO commentaires (COMMENTAIRE,PHOTO_ID,USERS_ID) VALUES (?,?,?)");
$params = array($comm,$id,$user);
$ps->execute($params);
header("Refresh:0 ; url=accueil.php");

?>
