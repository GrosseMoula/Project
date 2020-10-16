package com.example.donkeykong.models;

import java.io.*;
import java.util.ArrayList;
import java.util.Scanner;

public class Reading{

	
	public void readFile(String file_name,ArrayList<String> score) throws Exception{
		
		try {
		      File file = new File(file_name);
		      Scanner sc = new Scanner(file);
		      while (sc.hasNextLine()) {
		        String data = sc.nextLine();
		        score.add(data);
		      }
		      sc.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
	
	}





	

}
