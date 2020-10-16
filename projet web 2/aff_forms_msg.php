<?php
require_once("connexion_bd.php");
require_once ("script_securite.php");
?>


<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" type="text/css" href="./css/messages.css">
    <link rel="stylesheet" type="text/css" href="./css/monStyle.css">
    <link rel="stylesheet" type="text/css" href="./css/card.css">
    <link rel="stylesheet" type="text/css" href="./css/style.css">
    <link rel="stylesheet" type="text/css" href="./css/bootstrap-select.min.css">

    <link rel="stylesheet" href="./css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <style>
        .gras{
            font-weight: bold;
        }
    </style>
</head>
<body>
<div class = "container card">
    <form method = "POST" action = "./insert_msg.php">
        <br/>
        <h4 class = "text-center pacific">Envoie de messages</h4>
        <br/>
        <?php
            $ps  = $pdo->prepare("SELECT LOGIN FROM users");
            $ps->execute();
        ?>
        <div class="form-group row align-content-lg-center">
            <label class = "pacific ">Destinataire</label>
            <div class="form-group centre">
                <select class="form-control" name = "recepteur_id">
                    <?php
                        while($log = $ps->fetch()){
                    ?>
                    <option ><?php echo $log['LOGIN']; ?></option>
                    <?php
                        }
                    ?>
                </select>
            </div>


        </div>
        <br/>

        <div class="form-group row align-content-lg-center">
            <label class = "pacific">Message</label>
            <div class="form-group centre col-md-6">
                <textarea class="form-control" name = "message" rows="5" id="comment"></textarea>
            </div>
        </div>
        <br/>
        <br/>
        <div class="form-group row py-3 d-flex justify-content-around">
            <button type="submit" class="btn btn-secondary pacific">Inserer</button>
        </div>

        <br/>


    </form>
</div>




</body>
</html>