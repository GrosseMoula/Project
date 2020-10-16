<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" type="text/css" href="./css/card.css">
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
$ps = $pdo->prepare("SELECT * FROM photos INNER JOIN users ON USERS_ID = LOGIN");
$ps->execute();

?>
<div class="row">
<?php while ($photo = $ps->fetch()) {

    $ps2 = $pdo->prepare("SELECT * FROM commentaires WHERE PHOTO_ID = ?");
    $params2 = array($photo['ID_PHOTO']);
    $ps2->execute($params2);
    $nom_img = pathinfo($photo['PHOTO']);
    ?>



        <div class="container card mb-5 " style="width: 18rem;">
            <br/>
            <img class="card-img-top" src="./images/<?php echo $photo['PHOTO'] ?>" >
            <div class="card-body">
                <h5 class="card-title gras pacific"><?php echo $nom_img['filename'] ?></h5>
                <p class="card-text"><?php echo "Cette image a été inséré par ".$photo['NOM']." ".$photo['PRENOM']." à ".$photo["LIEU"] ?></p>
            </div>
            <ul class = "list-group list-group-flush">
                <?php while ($com = $ps2->fetch()) { ?>
                <li class="list-group-item">
                    <p class = "gras pacific py-3 d-flex justify-content-around"><?php echo $com['USERS_ID'] . " : "?></p><?php echo $com['COMMENTAIRE']?>
                </li>
                <?php } ?>


            </ul>

            <div class = "card-body py-3 d-flex justify-content-around">
                <form method = "POST" enctype="multipart/form-data" action="insertion_com.php?id= <?php echo $photo['ID_PHOTO'] ?>">

                        <input class = "form-control" type = "text" name = "comm"/>
                        <br/>
                        <button class="btn btn-secondary float-right btn-sm">Inserer</button>


                </form>
            </div>

            <div class = "card-body">
                <p class="card-text"><small class="text-muted">Inséré le : <?php echo $photo['MOMENT'] ?></small></p>
            </div>



        </div>
    </div>
</div>

<br/>
<br/>
<?php } ?>





</body>
</html>

