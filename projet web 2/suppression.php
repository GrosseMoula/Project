<?php
require_once("connection_bdd.php");
require_once ("script_securite.php");
$id = $_GET['id'];

if($id == $_SESSION["PROFILE"]["LOGIN"])
{
    echo ("Vous ne pouvez pas vous supprimer");
}
else
    {
    $ps = $pdo->prepare("DELETE FROM users WHERE ID=?");
    $params = array($id);
    $ps->execute($params);
    header("Refresh:0 ; url=accueil.php");

}


?>

