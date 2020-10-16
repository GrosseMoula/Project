<?php
require_once("connexion_bd.php");
require_once("script_securite.php");
$id = $_SESSION['PROFILE']['LOGIN'];
$message = $_POST['message'];
$recepteur_id = $_POST['recepteur_id'];


$ps = $pdo->prepare("INSERT INTO messages (MESSAGE,ENVOYEUR_ID,RECEPTEUR_ID) VALUES (?,?,?)");
$params = array($message,$id,$recepteur_id);
$ps->execute($params);
header("Refresh:0 ; url=messagerie.php");
?>