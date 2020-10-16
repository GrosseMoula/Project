package com.example.donkeykong.main;

import java.io.File;
import java.net.URL;


import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;

public class Main extends Application{

	@Override
	public void start(Stage arg0) throws Exception {
		Parent root = FXMLLoader.load(Main.class.getClassLoader().getResource("accueil_layout.fxml"));
		Scene scene = new Scene(root);
		arg0.setScene(scene);
		arg0.setTitle("Donkey Kong : Accueil");
		arg0.setResizable(false);

		arg0.show();
		
	}
	

}
