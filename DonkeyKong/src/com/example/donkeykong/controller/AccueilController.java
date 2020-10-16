package com.example.donkeykong.controller;

import java.net.URL;
import java.util.ResourceBundle;

import com.example.donkeykong.main.Main;

import javafx.application.Platform;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;
import javafx.stage.Window;



public class AccueilController implements Initializable{

	@FXML
	protected void Quit(ActionEvent e)
	{
		Platform.exit();
	}
	
	@FXML
	protected void Play(ActionEvent e) throws Exception
	{
		createGame();
	}
	
	@FXML
	protected void Showscore(ActionEvent e) throws Exception
	{
		ShowScore();
	}
	
	
	private void ShowScore() throws Exception
	{
		Stage stage = new Stage();
		FXMLLoader fxmlLoader = new FXMLLoader(Main.class.getClassLoader().getResource("high_score_layout.fxml"));
		Parent root = fxmlLoader.load();
		Scene scene = new Scene(root);
		stage.setScene(scene);
		stage.setResizable(false);
		stage.setTitle("Donkey Kong : Le jeu");
		stage.show();
		
	}

	private void createGame() throws Exception {
		
		Stage stage = new Stage();
		FXMLLoader fxmlLoader = new FXMLLoader(Main.class.getClassLoader().getResource("Settings.fxml"));
		Parent root = fxmlLoader.load();
		Scene scene = new Scene(root);
		stage.setScene(scene);
		stage.setResizable(false);
		stage.setTitle("Donkey Kong : Le jeu");
		stage.show();
		
		
		
	}

	@Override
	public void initialize(URL stage, ResourceBundle arg1)
	{
		
	}
	

	
	

}