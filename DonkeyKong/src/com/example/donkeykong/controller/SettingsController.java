package com.example.donkeykong.controller;

import java.net.URL;
import java.util.ResourceBundle;

import com.example.donkeykong.main.Main;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Label;
import javafx.scene.control.RadioButton;
import javafx.stage.Stage;

public class SettingsController implements Initializable{

	@FXML
	RadioButton yesvolume;
	@FXML
	RadioButton novolume;
	@FXML
	RadioButton easy;
	@FXML
	RadioButton moyen;
	@FXML
	RadioButton hard;
	@FXML
	Label CheckError;
	@FXML
	protected void Begin(ActionEvent e) throws Exception
	{
		boolean volume = false;
		if(this.setvolume() == "" || this.setdifficult() == 0)
		{
			CheckError.setText("Veuillez selectionner qu'une valeur par params");
		}
		else
		{
			if(this.setvolume() == "Oui")
			{
				volume = true;
			}
			else if(this.setvolume() == "Non")
			{
				volume = false;
			}
			creategame(volume,this.setdifficult());
		}
		
		
	
	}
	
	private double setdifficult() 
	{
		double difficult = 0;
		
		if(easy.isSelected() && moyen.isSelected() && hard.isSelected())
		{
			difficult = 0;
		}
		else if(easy.isSelected() && moyen.isSelected())
		{
			difficult = 0;
		}
		else if(easy.isSelected() && hard.isSelected())
		{
			difficult = 0;
		}
		else if(moyen.isSelected() && hard.isSelected())
		{
			difficult = 0;
		}
		else
		{
			if(easy.isSelected())
			{
				difficult = 1;
			}
			else if(moyen.isSelected())
			{
				difficult = 0.5;
			}
			else if (hard.isSelected())
			{
				difficult = 0.25;
			}
		}
		
		return difficult;
		
	}

	private String setvolume() {
		String volume = "";
		if(yesvolume.isSelected() && novolume.isSelected())
		{
			volume = "";
		}
		else
		{
			if(yesvolume.isSelected())
			{
				volume = "Oui";
			}
			else if(novolume.isSelected())
			{
				volume = "Non";
			}
		}
		return volume;
		
	}

	@Override
	public void initialize(URL arg0, ResourceBundle arg1) 
	{	
		
		this.setvolume();
		this.setdifficult();
		
	}


	private void creategame(boolean volume,double difficulty) throws Exception
	{
		Stage stage = new Stage();
		FXMLLoader fxmlLoader = new FXMLLoader(Main.class.getClassLoader().getResource("jeu_layout.fxml"));
		Parent root = fxmlLoader.load();
		Scene scene = new Scene(root);
		//Passer des values entre controllers
		//les evenements doivent etre créer dans la scene, et non dans un nodes ou un parent(Pane,VBox)
		((JeuController) fxmlLoader.getController()).MoveSinge(scene);
		((JeuController) fxmlLoader.getController()).Settings(difficulty,volume);
		
		
		stage.setScene(scene);
		stage.setResizable(false);
		stage.setTitle("Donkey Kong : Le jeu");
		stage.show();
		
	}

}
