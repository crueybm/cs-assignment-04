/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 09/21/2017
 * Assignment: 004
 * Description: Takes two prime numbers (alpha and beta), and then determines if (a+b)+1 and (a+b)-1 are both prime, 
 * then adds them together and keeps a running sum for all prime numbers (a & b) under 1000.
 * Citations: Utils.cs (From assignment 02, slightly modified for this assignment.)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace crueybm_Assignment004
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList alpha = PrimesAndArrays.BuildListOfPrimes();                  //Creates and fills ArrayList alpha with prime numbers.
            ArrayList beta = PrimesAndArrays.BuildListOfPrimes();                   //Creates and fills ArrayList beta with prime numbers.
            int m = 0;                                                              //Creates variable int m, used later in the code.

            for (int i = 0; i < alpha.Count; i++)                                   //Starts a for-loop that steps through the elements in ArrayList alpha.
            {
                for (int j = 0; j < beta.Count; j++)                                //Starts a for-loop that steps through the elements in ArrayList beta.
                {
                    int k = (Convert.ToInt32(alpha[i])) + (Convert.ToInt32(beta[j])) + 1;   //Creates int k, and sets it to (alpha[i] + beta[j]) + 1.
                    int l = (Convert.ToInt32(alpha[i])) + (Convert.ToInt32(beta[j])) - 1;   //Creates int k, and sets it to (alpha[i] + beta[j]) - 1.
                    if (PrimesAndArrays.isPrime(k) && PrimesAndArrays.isPrime(l))   //Runs ints k and l through an if statement to verify that they are prime numbers.
                    {
                        m += (k + l);                                               //Adds the sum of variables k and l to variable m.
                    }
                }
            }
            Console.WriteLine("Solution " + m);                                     //Writes the solution of the problem.
        }
    }
}
