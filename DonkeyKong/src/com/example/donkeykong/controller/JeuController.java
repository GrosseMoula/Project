package com.example.donkeykong.controller;

import java.io.FileNotFoundException;
import java.net.URL;
import java.util.Random;
import java.util.ResourceBundle;

import com.example.donkeykong.main.Main;
import com.example.donkeykong.models.CreateImage;
import com.example.donkeykong.models.Position;
import com.example.donkeykong.models.Score;
import com.example.donkeykong.models.Vie;

import javafx.animation.Animation;
import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.event.EventHandler;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Label;
import javafx.scene.image.ImageView;
import javafx.scene.input.KeyCode;
import javafx.scene.layout.Pane;
import javafx.scene.media.Media;
import javafx.scene.media.MediaPlayer;
import javafx.stage.Stage;
import javafx.util.Duration;

public class JeuController implements Initializable {

	private Position<Integer> position;
	@FXML
	protected Pane screen;
	@FXML
	protected ImageView singe;
	@FXML
	protected Label testmgl,life;

	private Random random;
	
	public Scene scene;
	
	static int point;

	private CreateImage createBanane,createBombe;
	
	private static Score score;
	
	private Vie vie;
	
	private Timeline timeline_addbanane, timeline_movebanane,timeline_addbombe,timeline_movebombe;
	
	public void Settings(double difficult,boolean volume) throws Exception
	{
		//double difficult repris du controlleur settings
		setTimerBanane();
		moveBanane(difficult,volume);
		setTimerBombe();
		moveBombe(difficult,volume);
		
		//difficculté plus grande
		if(score.getScore()%150==0)
		{
			difficult = difficult - 0.1;
		}
	}
	
	
	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		score = new Score(0,15);
		vie = new Vie(1);
		setSingePosition();
	}

	private void checkLife() throws Exception {
		if(vie.getVie() == 0)
		{
			timeline_addbanane.stop();
			timeline_addbombe.stop();
			timeline_movebanane.stop();
			timeline_movebombe.stop();
			///System.out.println(score.getScore());
			showEndGame(score.getScore());
			
		}
		
	}

	private void moveBombe(double difficult,boolean volume) throws Exception{
		
		timeline_movebombe = new Timeline(new KeyFrame(Duration.seconds(difficult), new EventHandler<ActionEvent>() {
		
			@Override
			public void handle(ActionEvent arg0) {
				for (ImageView bombe : createBombe.getListe_banane())
				{
					bombe.setY(bombe.getY() + 15);
					if(bombe.getBoundsInParent().intersects(singe.getBoundsInParent()))
					{
						vie.DecrementVie();
						life.setText("Vies : " + vie.getVie());
						if(volume)
						{
							Media death = new Media(Main.class.getClassLoader().getResource("mariojumps.wav").toString());
							MediaPlayer mediaplayer_1 = new MediaPlayer(death);
							mediaplayer_1.setVolume(0.1);
							mediaplayer_1.play();
						}
						createBombe.getListe_banane().remove(bombe);
						screen.getChildren().remove(bombe);
						try {
							checkLife();
						} catch (Exception e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						}
						
						
					}	
				}
			}
		}));
		timeline_movebombe.setCycleCount(Animation.INDEFINITE);
		timeline_movebombe.play();
		
		
	}

	private void setTimerBombe() {
		
		createBombe = new CreateImage(Main.class.getClassLoader().getResource("bombe.png").toString(), 40);
		timeline_addbombe = new Timeline(new KeyFrame(Duration.seconds(15), new EventHandler<ActionEvent>() {
			public void handle(ActionEvent arg) {
				Integer a = new Random().nextInt((int) screen.getPrefWidth());
				//System.out.println(a);
				try {
					createBombe.Create(a);
					screen.getChildren().add(createBombe.getImageView());
				} catch (FileNotFoundException e) {
					
					e.printStackTrace();
				}

			}
		}));
		timeline_addbombe.setCycleCount(Animation.INDEFINITE);
		timeline_addbombe.play();
	}

	private void moveBanane(double difficult,boolean volume) throws Exception{
		Media takebanana = new Media(Main.class.getClassLoader().getResource("dk_6.wav").toString());
		MediaPlayer mediaplayer_2 = new MediaPlayer(takebanana);
		mediaplayer_2.setVolume(0.1);
		timeline_movebanane = new Timeline(new KeyFrame(Duration.seconds(difficult), new EventHandler<ActionEvent>() {
		
			@Override
			public void handle(ActionEvent arg0) {
				for (ImageView banane : createBanane.getListe_banane())
				{
					//similaire au for in en Python ou au foreach en c#
					banane.setY(banane.getY() + 15);
					if(banane.getBoundsInParent().intersects(singe.getBoundsInParent()))
					{
						score.ScoreIncrement();
						testmgl.setText("Score : "+ score.getScore());
						if(volume)
						{
							Media takebanana = new Media(Main.class.getClassLoader().getResource("dk_6.wav").toString());
							MediaPlayer mediaplayer_2 = new MediaPlayer(takebanana);
							mediaplayer_2.setVolume(0.1);
							mediaplayer_2.play();
						}
						createBanane.getListe_banane().remove(banane);
						screen.getChildren().remove(banane);
						
					}
				}
				
			}
			
		}));
		timeline_movebanane.setCycleCount(Animation.INDEFINITE);
		timeline_movebanane.play();
		
		
	}

	private void setTimerBanane() {

		createBanane = new CreateImage(Main.class.getClassLoader().getResource("banana.png").toString(), 40);
		timeline_addbanane = new Timeline(new KeyFrame(Duration.seconds(3), new EventHandler<ActionEvent>() {
			public void handle(ActionEvent arg) {
				Integer a = new Random().nextInt((int) screen.getPrefWidth());
				//System.out.println(a);
				try {
					createBanane.Create(a);
					screen.getChildren().add(createBanane.getImageView());
				} catch (FileNotFoundException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}

			}
		}));
		timeline_addbanane.setCycleCount(Animation.INDEFINITE);
		timeline_addbanane.play();
		

	}

	private void setSingePosition() {

		// testmgl.setText(String.valueOf(this.screen.getBoundsInParent().getWidth()));
		position = new Position <Integer>(10, 230);

		singe.setX(position.getX());
		singe.setY(position.getY());
	}

	public void MoveSinge(Scene scene) {
		this.scene = scene;

		// J'essaye la fonction lambda
		scene.setOnKeyPressed(e -> {

			if (e.getCode().equals(KeyCode.LEFT) && singe.getX() != -380) {
				position = new Position <Integer>((int)singe.getX(), (int)singe.getY());
				singe.setX(position.getX() - 5);
			}

			if (e.getCode().equals(KeyCode.RIGHT) && singe.getX() != 380) {
				position = new Position <Integer>((int)singe.getX(), (int)singe.getY());
				singe.setX(position.getX() + 5);
			}

		});

	}
	
	public void showEndGame(int score) throws Exception
	{
		setScore(score);
		Stage stage = new Stage();
		FXMLLoader fxmlLoader = new FXMLLoader(Main.class.getClassLoader().getResource("end_game_layout.fxml"));
		Parent root = fxmlLoader.load();
		Scene scene = new Scene(root);
		stage.setScene(scene);
		stage.setResizable(false);
		stage.show();
		
	}
	
	public static int getScore()
	{
		return JeuController.point;
	}
	public void setScore(int score)
	{
		JeuController.point = score;
	}

}
