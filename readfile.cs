//Created for sharp develop
using System;
using System.IO;

namespace sharp
{
	class Program
	{
		public static void Main(string[] args)
		{		
			String path = @"C:\Users\admin\Documents\SharpDevelop\readfile\file.txt";
			
			 using (StreamReader sr = new StreamReader(path, true))
			 {
			 	string line;
			 	
                        while ((line = sr.ReadLine()) != null)
                        {
                        	int vowel = 0;
                            int consonant = 0;
                            int charCount = 0;
                            string letter = line.ToUpper();
                            
                            for (int i = 0; i < line.Length; i++)
                                {
                                    string j = letter[i].ToString(); 
                                    if (j == "A" || j == "E" || j == "I" || j == "O" || j == "U") 
                                        {
                                            vowel++;
                                            charCount++;                                       
                                           
                                        }
                                    else if(j == "B" ||j == "C" ||j == "D" ||j == "F" ||j == "G" ||j == "H" ||j == "J" ||j == "K" ||j == "L" ||j == "M" ||j == "N" ||j == "P" ||j == "Q" ||j == "R" ||j == "S" ||j == "T" ||j == "V" ||j == "W" ||j == "X" ||j == "Y" || j == "Z") //checks consonants through filters
                                        {
                                            consonant++; 
                                            charCount++; 
                                            
                                        }
                                    else if(j == "." || j == "," )
                                    	{
                                    		charCount++;
                                   		}
                                    else
                                        {
                                            continue;
                                        }
                                }
                            
                        	Console.WriteLine("TEXT: " + line); 
                            Console.WriteLine("Number of Characters: " + charCount + ".");
                            Console.WriteLine("Number of Vowel Letters: " + vowel + ".");
                            Console.WriteLine("Number of Consonant Letters: " + consonant + ".");
                        }
			 }
			 
			Console.ReadKey(true);
		}
	}
}
