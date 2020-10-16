
<nav class="navbar navbar-expand-lg navbar-light bg-light">
    <a class="navbar-brand pacific" href="accueil.php">Accueil</a>


    <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav mr-auto">
            <li class="nav-item active">
                <a class="nav-link pacific" href="carte.php">Carte<span class="sr-only">(current)</span></a>
            </li>
            <li class="nav-item">
                <a class="nav-link pacific" href="profil.php">Profil</a>
            </li>
            <li class="nav-item">
                <a class="nav-link pacific" href="messagerie.php">Messagerie</a>
            </li>


        </ul>

        <form class="form-inline my-2 my-lg-0" method = "POST" action = "./liste_profil.php">
            <input class="form-control mr-sm-2" type="search" name = "login" placeholder="Rechercher un profil" aria-label="Search">
            <button class= "btn-primary mb-2 my-sm-0 pacific" type="submit">Rechercher</button>
        </form>
    </div>
</nav>