<?php require_once ("connexion_bd.php") ?>
<?php require_once ('script_securite.php')?>

<html lang="fr">
<head>
    <meta charset = "utf-8">
    <link rel="stylesheet" type="text/css" href="./css/monStyle.css">
    <link rel="stylesheet" type="text/css" href="./css/map.css">
    <link rel="stylesheet" href="./css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="http://www.openlayers.org/api/OpenLayers.js"></script>
    <style>
        .map {
            height: 400px;
            width: 100%;
        }
    </style>

    <title>Carte</title>

</head>

<body>
<?php require_once("navbar_site.php") ?>



<br/>


<br/>

<div id="map"></div>

</div>

<script>
    map = new OpenLayers.Map("map");
    map.addLayer(new OpenLayers.Layer.OSM());

    var lonLat = new OpenLayers.LonLat( -0.1279688 ,51.5077286 )
        .transform(
            new OpenLayers.Projection("EPSG:4326"), // transform from WGS 1984
            map.getProjectionObject() // to Spherical Mercator Projection
        );
    var zoom=16;
    var markers = new OpenLayers.Layer.Markers( "Markers" );
    map.addLayer(markers);

    markers.addMarker(new OpenLayers.Marker(lonLat));
    map.setCenter (lonLat, zoom);

        <?php
            $ps = $pdo->prepare("SELECT * FROM photos");
            $ps->execute();
            while($photo = $ps->fetch())
            {

            ?>




    var lonLat = new OpenLayers.LonLat(<?php echo $photo['LONGITUDE'];?>,<?php echo $photo['LATITUDE'];?>)
        .transform(
            new OpenLayers.Projection("EPSG:4326"), // transform from WGS 1984
            map.getProjectionObject() // to Spherical Mercator Projection
        );

    var photo = './images/<?php echo $photo['PHOTO'];?>';

    var zoom=16;
    var size = new OpenLayers.Size(50,50);
    var sizepo = new OpenLayers.Size(130,30);
    var offset = new OpenLayers.Pixel(-(size.w/2), -size.h);
    var icon = new OpenLayers.Icon(photo, size , offset);
    var markers = new OpenLayers.Layer.Markers( "Markers" );
    popup = new OpenLayers.Popup("lacostetn", lonLat,sizepo,"photo : <?php echo $photo['PHOTO'];?>", true);
    map.addPopup(popup);
    map.addLayer(markers);

    markers.addMarker(new OpenLayers.Marker(lonLat,icon));

    <?php  } ?>


</script>


</body>
</html>
