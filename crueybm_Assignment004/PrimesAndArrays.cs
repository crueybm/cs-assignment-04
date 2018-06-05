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
    class PrimesAndArrays
    {
        public static Boolean isPrime(int num)          //Determines if a given number is a prime.
        {
            Boolean status = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if ((num % i) == 0) return false;
            }
            return status;
        }

        public static ArrayList BuildListOfPrimes()     //Builds an array that fills with only prime numbers.
        {
            ArrayList primes = new ArrayList();

            for (int i = 1; i < 1000; i++)
            {
                if (isPrime(i)) primes.Add(i);
            }
            return primes;
        }
    }
}
