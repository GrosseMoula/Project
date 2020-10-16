package com.example.donkeykong.models;

public class Position <T> {
	
	//double car les sizes des fenetres sont exprim�s en double 
	
	private T x;
	private T y;
	
	public Position(T x,T y)
	{
		this.x = x;
		this.y = y;
	}
	
	public Position()
	{
		//Au cas ou l'on veux attribuer values � x et y par des setters
	}

	public T getX() {
		return x;
	}

	public void setX(T x) {
		this.x = x;
	}

	public T getY() {
		return y;
	}

	public void setY(T y) {
		this.y = y;
	}
	
	

}
