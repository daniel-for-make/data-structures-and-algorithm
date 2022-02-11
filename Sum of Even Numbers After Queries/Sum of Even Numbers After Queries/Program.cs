using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_of_Even_Numbers_After_Queries
{
    class Program
    {
        static void Main()
        {
            int temporario = 0;
            int[] nums = new int[] { 1, 2, 3, 4 };

            int[,] queries = new int[,] { {1, 0},
                {-3, 1},
                { -4,0 },
                { 2,3 }

            };

            int[] answer = new int[nums.Length];
            int[] pares = new int[nums.Length];
            
                
            for (int coluna = 0; coluna < nums.Length; coluna++)
            {
               
                if (coluna == queries[coluna, 1]) //irá ver se o apontador tme o mesmo vallor que esta  namlinha 1 coluna x
                {

                    // se tiver o mesmo valor vai somar
                    nums[coluna] +=  queries[coluna, 0];

                    //if (nums[coluna] % 2 == 0)
                    //{

                    //    pares[coluna] = nums[coluna];

                    //} 
                  
                }
                else 
                {

                    temporario = coluna;
                    //coluna = 0;
                    coluna = queries[coluna, 1]; //vai igualar o valor que esta no index da matriz

                    nums[coluna] += queries[temporario, 0]; // soma os valores que estao na primeira linha da matriz

                    coluna = temporario;

                   
                }
                Console.WriteLine("SOMOU " + "{0}", nums[coluna]); //cada vez que somar eu quero ver o que esta lá dentro
            }

          //  pares.ForEach(Console.WriteLine);
            



            Console.WriteLine("ARRAY Final: ");
            for (int i = 0; i < answer.Length; i++)
            {
               // answer[i] = pares[i] + pares[i + 1];
                Console.WriteLine("{0}", nums[i]);

            }

        }
    }
}
 