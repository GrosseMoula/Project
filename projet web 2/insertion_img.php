<?php


    $ici = $_POST['ici'];
    $endroit = $_POST['endroit'];
    require_once ("connexion_bd.php");
    require_once ("script_securite.php");

    if (isset($ici))
    {
    echo'<script>
        function getLocation() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(showPosition);
            } else {
                alert("Geolocation is not supported by this browser.");
            }
        }

        function showPosition(position) {
            
            var lat = position.coords.latitude;
            var long = position.coords.longitude;
            document.cookie = "lat =" + 0;
            document.cookie = "lat ="+lat;
            document.cookie = "long =" + 0;
            document.cookie = "long ="+long;
          
            
        }
        getLocation();
        
    </script>';
        header("Refresh:0");
        $lat = $_COOKIE['lat'];
        $long = $_COOKIE['long'];
        $url = 'http://open.mapquestapi.com/geocoding/v1/reverse?key=kCWizv562ptmcbD1NLBg3O9NmjykRDPE&location='.$lat.','.$long.'&includeRoadMetadata=true&includeNearestIntersection=true';
        $contenu = file_get_contents($url);
        $jsonTab = json_decode($contenu,true);
        $ville = $jsonTab["results"][0]["locations"][0]["adminArea3"];

        setlocale(LC_TIME, 'fr_FR');
        date_default_timezone_set('Europe/Paris');
        $moment = strftime('%A %d %B %Y, %H:%M');

        $photo = $_FILES ['image'] ['name'];
        $photo_tempo = $_FILES['image']['tmp_name'];
        move_uploaded_file($photo_tempo,"./images/$photo");

        $users = $_SESSION['PROFILE']['LOGIN'];

        $ps = $pdo->prepare("INSERT INTO photos(PHOTO,LIEU,MOMENT,LONGITUDE,LATITUDE,USERS_ID) VALUES (?,?,?,?,?,?)");
        $params = array($photo,$ville,$moment,$long,$lat,$users);
        $ps->execute($params);
        header("Refresh:0 ; url=accueil.php");



    }



    else if (!isset($ici))
    {
        if(isset($endroit))
        {
            setlocale(LC_TIME, 'fr_FR');
            date_default_timezone_set('Europe/Paris');
            $moment = strftime('%A %d %B %Y, %H:%M');

            $lien= 'http://open.mapquestapi.com/geocoding/v1/address?key=kCWizv562ptmcbD1NLBg3O9NmjykRDPE&location='.$endroit;
            $contents = file_get_contents($lien);
            $jsonTab = json_decode($contents, true);
            $LatLng = $jsonTab["results"][0]["locations"][0]["latLng"];
            $lng = $LatLng["lng"];
            $lat = $LatLng["lat"];

            $photo = $_FILES ['image'] ['name'];
            $photo_tempo = $_FILES['image']['tmp_name'];
            move_uploaded_file($photo_tempo,"./images/$photo");

            $users = $_SESSION['PROFILE']['LOGIN'];


            $ps = $pdo->prepare("INSERT INTO photos(PHOTO,LIEU,MOMENT,LONGITUDE,LATITUDE,USERS_ID) VALUES (?,?,?,?,?,?)");
            $params = array($photo,$endroit,$moment,$lng,$lat,$users);
            $ps->execute($params);
        }
    }
?>
