<?php
    require_once("connexion_bd.php");
    $login = $_POST['login'];
    $ps = $pdo->prepare("SELECT * FROM users WHERE LOGIN = ?");
    $params = array($login);
    $ps->execute($params);
?>

<?php require_once ('script_securite.php') ?>
<html lang="fr">
<head>
    <meta charset = "utf-8">
    <link rel="stylesheet" type="text/css" href="./css/monStyle.css">
    <link rel="stylesheet" href="./css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <script src="https://unpkg.com/react@16/umd/react.production.min.js"></script>
    <script src="https://unpkg.com/react-dom@16/umd/react-dom.production.min.js"></script>
    <script src="https://unpkg.com/babel-standalone@6.15.0/babel.min.js"></script>



    <title>Liste des profils</title>

</head>

<body>
<?php require_once ("navbar_site.php") ?>
<br/><br/>

<table class="table table-dark">
    <thead>
    <tr class = "text-center py-3 d-flex justify-content-around">
        <th scope="col" class = "pacific">Login</th>
        <th scope="col" class = "pacific">Nom</th>
        <th scope="col" class = "pacific">Prenom</th>
        <th scope="col" class = "pacific">Adresse mail</th>
        <th scope="col" class = "pacific">Gerer</th>
    </tr>
    </thead>
    <tbody>
    <?php while($user = $ps->fetch()) { ?>
    <tr class = "text-center py-3 d-flex justify-content-around">
        <th scope="row" class = "pacific blanco"><?php echo $user['LOGIN'] ?></th>
        <td class = "pacific blanco"><?php echo $user['NOM'] ?></td>
        <td class = "pacific blanco"><?php echo $user['PRENOM'] ?></td>
        <td class = "pacific blanco"><?php echo $user['EMAIL'] ?></td>
        <td class = "float-left"><a href = "profil_result.php?id=<?php echo($user['LOGIN']) ?>"><img src = "./images/profile_121261.png"/></a></td>
		<?php if ($_SESSION['PROFILE']['ROLE'] == "admin") { ?>
        <td><a href = "confirmation_suppression.php?id=<?php echo($user['LOGIN']) ?>"><img src = "./images/trash_120980.png"/></a></td>
		<?php } ?>
    </tr>
    <?php } ?>
    </tbody>
</table>
</body>
</html>





