 find -name "*.java" > sources.txt
#Penser à changer le chemin du module 
javac --module-path /usr/share/openjfx/lib --add-modules=javafx.base,javafx.controls,javafx.fxml,javafx.graphics,javafx.media,javafx.swing,javafx.web -d out @sources.txt
# Mettre tous les fichiers soources dans le dossier out(images,fxml,score.txt,son)
cp -r ./css_files/* ./out
cp -r ./vues/* ./out

cp Score.txt ./out

cd out



java --module-path /usr/share/openjfx/lib --add-modules=javafx.base,javafx.controls,javafx.fxml,javafx.graphics,javafx.media,javafx.swing,javafx.web com.example.donkeykong.Main
