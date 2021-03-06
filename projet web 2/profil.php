<?php require_once ('script_securite.php') ?>
<html lang="fr">
<head>
    <meta charset = "utf-8">
    <link rel="stylesheet" type="text/css" href="./css/monStyle.css">
    <link rel="stylesheet" type="text/css" href="./css/profile.css">
    <link rel="stylesheet" href="./css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <title>Profil</title>

</head>
<body>
<?php require_once('navbar_site.php') ?>
<br/>
<br/>
<div class="container">
    <div class="row">
        <div class="col-12">
            <div class="card">

                <div class="card-body">
                    <div class="card-title mb-4">
                        <div class="d-flex justify-content-start">
                            <div class="image-container">
                                <img src="./images/kisspng-el-risitas-issou-internet-forum-high-definition-te-hd-jesus-images-5b5213a566dfb7.8449786915321056374214.jpg" id="imgProfile" style="width: 150px; height: 150px" class="img-thumbnail" />

                            </div>
                            <div class="userData ml-3">
                                <h2 class="d-block" style="font-size: 1.5rem; font-weight: bold"><?php echo $_SESSION['PROFILE']['NOM']." ".$_SESSION['PROFILE']['PRENOM']?></h2>
                            </div>
                            <div class="ml-auto">
                                <input type="button" class="btn btn-primary d-none"/>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-12">
                            <ul class="nav nav-tabs mb-4" id="myTab" role="tablist">
                                <li class="nav-item">
                                    <a class="nav-link active"  data-toggle="tab" href="#basicInfo" aria-selected="true">Informations</a>
                                </li>
                            </ul>
                            <div class="tab-content ml-1">
                                <div class="tab-pane fade show active">


                                    <div class="row">
                                        <div class="col-sm-3 col-md-2 col-5">
                                            <label style="font-weight:bold;">Nom</label>
                                        </div>
                                        <div class="col-md-8 col-6">
                                            <?php echo $_SESSION['PROFILE']['NOM']?>
                                        </div>
                                    </div>
                                    <hr />

                                    <div class="row">
                                        <div class="col-sm-3 col-md-2 col-5">
                                            <label style="font-weight:bold;">Prenom</label>
                                        </div>
                                        <div class="col-md-8 col-6">
                                            <?php echo $_SESSION['PROFILE']['PRENOM']?>
                                        </div>
                                    </div>
                                    <hr />
                                    <div class="row">
                                        <div class="col-sm-3 col-md-2 col-5">
                                            <label style="font-weight:bold;">Login</label>
                                        </div>
                                        <div class="col-md-8 col-6">
                                            <?php echo $_SESSION['PROFILE']['LOGIN']?>
                                        </div>
                                    </div>
                                    <hr />
                                    <div class="row">
                                        <div class="col-sm-3 col-md-2 col-5">
                                            <label style="font-weight:bold;">Email</label>
                                        </div>
                                        <div class="col-md-8 col-6">
                                            <?php echo $_SESSION['PROFILE']['EMAIL']?>
                                        </div>
                                    </div>
                                    <hr />

                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
</body>
</html>

