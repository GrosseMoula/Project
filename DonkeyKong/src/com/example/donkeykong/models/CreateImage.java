package com.example.donkeykong.models;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.ArrayList;

import javafx.scene.image.Image;
import javafx.scene.image.ImageView;

//Cette classe n'a pas sa place ici (doit être dans les vues), mais pour des raisons d'optimisation, nous allons le mettre avec des modèles
//Dans le modèle car c'est une données que l'on va créer, pas manipuler (donc pas dans le controlleur)

public class CreateImage {
	
	private String url;
	
	private double taille;
	
	private ImageView imageView;
	
	private Image image;
	
	private ArrayList <ImageView> liste_banane;
	
	public Position <Integer> position;
	
	public CreateImage(String url,double taille)
	{
		this.url = url;
		
		this.liste_banane = new ArrayList <ImageView>();
		
		this.taille = taille;
		
	}
	
	public void Create(Integer X) throws FileNotFoundException
	{
		this.position = new Position<Integer>(X,0);
		this.image = new Image(this.url);
		this.imageView = new ImageView();
		this.imageView.setImage(this.image);
		this.imageView.setFitHeight(40);
		this.imageView.setFitWidth(40);
		this.imageView.setX(position.getX());
		this.imageView.setY(position.getY());
		this.liste_banane.add(imageView);

	}

	public String getUrl() {
		return url;
	}

	public double getTaille() {
		return taille;
	}

	public ImageView getImageView() {
		return imageView;
	}

	public Image getImage() {
		return image;
	}

	public ArrayList<ImageView> getListe_banane() {
		return liste_banane;
	}
	
	
	
	

}
