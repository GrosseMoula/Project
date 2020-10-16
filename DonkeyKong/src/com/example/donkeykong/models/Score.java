package com.example.donkeykong.models;

public class Score {
	
	private int score;
	
	private int incrementation;

	public Score(int score,int inc) {
		this.score = score;
		this.incrementation = inc;
	}

	public int getScore() {
		return score;
	}

	public void setScore(int score) {
		this.score = score;
	}
	
	public void ScoreIncrement()
	{
		score = score + this.incrementation;
		
	}
	

}
