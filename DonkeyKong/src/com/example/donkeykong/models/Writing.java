package com.example.donkeykong.models;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class Writing{

	public void writeToFile(String file_name, String value) {
		
		File file = new File(file_name);
		FileWriter fileWriter = null;
		
		try
		{
			fileWriter = new FileWriter(file,true);
			fileWriter.write(value);
		}
		catch(IOException e)
		{
			e.printStackTrace();
		}
		finally {
			try 
			{
				fileWriter.close();
			} 
			catch (IOException e) 
			{
				e.printStackTrace();
			}
		}
			
		
		
		
		
	}

}
