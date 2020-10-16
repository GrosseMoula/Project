<?php
try
{
	$connexion = "mysql:host=localhost:3306;dbname=projet_web";
	$pdo = new PDO($connexion,"root","root");
}
catch(PDOException $e)
{
	$erreur = "Erreur PDO dans ".$e->getMessage();
	die($erreur);
} 
?>