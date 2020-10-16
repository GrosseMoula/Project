module DonkeyKong {
	//besoin de mettre les dépendances explicites pour utiliser les classes
	requires javafx.graphics; 
	requires javafx.controls;
	requires javafx.fxml;
	requires javafx.media;
	exports com.example.donkeykong.main;
	opens com.example.donkeykong.main to javafx.fxml;
	opens com.example.donkeykong.controller to javafx.fxml;
	
	
	
}