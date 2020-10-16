package com.example.donkeykong.controller;

import java.net.URL;
import java.util.ResourceBundle;

import com.example.donkeykong.models.Writing;

import javafx.application.Platform;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;

public class EndGameController implements Initializable {
	
	@FXML
	Label LabelScore;
	
	@FXML
	TextField name;
	
	Writing write;
	
	int score;
	
	
	
	@FXML
	protected void Validate(ActionEvent e) throws Exception
	{
		
		write = new Writing();
		write.writeToFile("Score.txt",name.getText() + " : " + JeuController.getScore()+"\n");
		Platform.exit();
		
	}

	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		LabelScore.setText("Votre score : "+JeuController.getScore());
		
	}


}
