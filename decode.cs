using System;
using System.Collections.Generic;
namespace decode
{
  class Program
  {
    static void Main(string[] args)
    {
        string[,] arr2D =  new string[,] {
            {"A","B","C","D","E"},
            {"F","G","H","I","J"},
            {"K","L","M","N","O"},
            {"P","Q","R","S","T"},
            {"U","V","W","X","Y"}
            };

        int rowLength = arr2D.GetLength(0); 
        int colLength = arr2D.GetLength(1); 

        Console.WriteLine("Enter Password:");
        string userInput = Console.ReadLine().ToUpper(); 

        char[] myArray = userInput.ToCharArray(); 

        List<int> coordinates = new List<int>(); 

        foreach (char letter in  myArray) 
        {
            for (int i = 0; i < rowLength; i++) 
            {
                for (int j=0; j < colLength; j++)
                {
                    string newLetter = letter.ToString();
                    if (newLetter.Equals(arr2D[i,j]))
                    {
                        coordinates.Add(i);
                        coordinates.Add(j);
                    }
                }
            }
        }
        int[] newArr = coordinates.ToArray(); //converts list to array
        Console.WriteLine("Decrypted Password: " +string.Join("",newArr));
    }
  }
}