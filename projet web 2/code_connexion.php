<?php


require_once ("connexion_bd.php");

$login = $_POST['login'];
$password = md5($_POST['mdp']);
if(isset($login) && isset($password))
{
	$ps = $pdo->prepare("SELECT * FROM users WHERE LOGIN = ? AND PASSWORD = ?");
	$params = array($login, $password);
	$ps->execute($params);

	if($user = $ps->fetch()) {
	session_start();
	$_SESSION['PROFILE'] = $user;
	header("location: accueil.php ");
	}

	else
	{
		header("location:no.php");
	}
}

else if(empty($login) && empty($password)){
	header("location : connexion.php");
}





?>



	
	