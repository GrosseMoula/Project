package com.example.donkeykong.models;

public class Vie {
	
	private int vie;
	
	public Vie(int vie)
	{
		this.vie = vie;
	}

	public int getVie() {
		return vie;
	}

	public void setVie(int vie) {
		this.vie = vie;
	}
	
	public void DecrementVie()
	{
		this.vie = this.vie - 1;
	}

}
