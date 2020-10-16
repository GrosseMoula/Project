package com.example.donkeykong.controller;

import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;

import com.example.donkeykong.models.Reading;

import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import javafx.scene.control.ListView;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;

public class HighScoreController implements Initializable{

	ArrayList<String> score = new ArrayList<String>();
		
	Reading read;
	
	@FXML
	ListView<String> highscore;
	
	@FXML
	Label test;
	
	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		
		try {
			read = new Reading();
			read.readFile("Score.txt", score);
			insertInTableView();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		
		
		
		
		
	}
	private void insertInTableView() 
	{
		for (int i = 0; i < score.size(); i++) 
		{
			highscore.getItems().add(score.get(i));
		}
		
	}
	
	

}
