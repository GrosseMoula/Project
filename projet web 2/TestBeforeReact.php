<?php require_once ('script_securite.php') ?>
<html lang="fr">
<head>
    <meta charset = "utf-8">
    <link rel="stylesheet" type="text/css" href="./css/monStyle.css">
    <link rel="stylesheet" type="text/css" href="./css/profile.css">
    <link rel="stylesheet" href="./css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">



    <script src="https://unpkg.com/react@16/umd/react.production.min.js"></script>
    <script src="https://unpkg.com/react-dom@16/umd/react-dom.production.min.js"></script>
    <script src="https://unpkg.com/babel-standalone@6.15.0/babel.min.js"></script>



    <?php $titrepage = "Accueil"; ?>
    <title><?php echo $titrepage; ?></title>

</head>
<body>
<?php require_once('navbar_site.php') ?>
<br/>
<br/>
<div class="col-sm-6 col-md-4 col-lg-3 mt-4">
    <div class="card">
        <img class="card-img-top" src="https://picsum.photos/200/150/?random
">
        <div class="card-block">
            <figure class="profile">
                <img src="https://picsum.photos/200/150/?random" class="profile-avatar" alt="">
            </figure>
            <h4 class="card-title mt-3">Tawshif Ahsan Khan</h4>
            <div class="meta">
                <a>Friends</a>
            </div>
            <div class="card-text">
                Tawshif is a web designer living in Bangladesh.
            </div>
        </div>
        <div class="card-footer">
            <small>Last updated 3 mins ago</small>
            <button class="btn btn-secondary float-right btn-sm">show</button>
        </div>
    </div>
</div>
</div>

</body>
</html>

