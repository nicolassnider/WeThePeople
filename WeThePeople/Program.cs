// See https://aka.ms/new-console-template for more information

using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Numerics;

internal class Program
{
    public static void Main(string[] args)
    {

        var weThePeople = "we the people of the united states in order to form a more perfect union etc";
        Console.WriteLine(weThePeople);
        Encrypt("we the people of the united states in order to form a more perfect union etc");
        Console.WriteLine("\n");
        
        var cheatingIsNotAllowed = "cheating is not allowed";
        Console.WriteLine(cheatingIsNotAllowed);
        Encrypt(cheatingIsNotAllowed);
        Console.WriteLine("\n");

        var theRocks = "the rocks";
        Console.WriteLine(theRocks);
        Encrypt(theRocks);
        Console.WriteLine("\n");

        void Encrypt(string input)
        {
            //delete whitespaces
            input = input.Replace(" ", ""); //"therocks"
            //get length of input
            int len = input.Length; //8
            //get row and col
            int row = (int)Math.Sqrt(len); //2
            int col = (int)Math.Ceiling(Math.Sqrt(len));  //3
            //get area r*c
            int area = row * col;  //6
            //if area is less than length, row takes col value
            if (area < len)
            {
                row = col; //row = 3
            }
            int index = 0;
            char[,] arr = new char[row, col];
            
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (index < len)
                    {
                        arr[i, j] = input[index];
                        index++;
                    }
                }
                /*
                 * [0,0] t
                 * [0,1] h
                 * [0,2] e
                 * [1,0] r
                 * [1,1] o
                 * [1,2] c
                 * [2,0] k
                 * [2,1] s
                 * [2,2] \0
                 */
            }
            //iterate the array and print the values in column order
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(arr[j, i]);
                }
                //print a space
                Console.Write(" ");                
            }
        }
    }
}

