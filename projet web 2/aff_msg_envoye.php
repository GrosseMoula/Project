<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" type="text/css" href="./css/messages.css">
    <link rel="stylesheet" type="text/css" href="./css/monStyle.css">
    <style>
        .gras{
            font-weight: bold;
        }
    </style>
</head>
<body>
<?php
require_once ('connexion_bd.php');
require_once ('script_securite.php');
$id = $_SESSION['PROFILE']['LOGIN'];
$ps = $pdo->prepare("SELECT * FROM messages WHERE ENVOYEUR_ID = ?");
$params = array($id);
$ps->execute($params);

?>

<?php while($messagerecu = $ps->fetch()) { ?>
    <div class="centre container">
        <img src="./images/kisspng-el-risitas-issou-internet-forum-high-definition-te-hd-jesus-images-5b5213a566dfb7.8449786915321056374214.jpg" alt="Avatar" style="width:100%;">
        <p class = "pacific"><?php echo $messagerecu["MESSAGE"]; ?></p>
        <span class="time-right pecific">Envoyé à : <?php echo $messagerecu["RECEPTEUR_ID"]; ?></span>
    </div>
    <br>
<?php } ?>






</body>
</html>
