using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_of_Even_Numbers_After_Queries
{
    class Program
    {
        static void Main()
        {
            int temporario = 0 ;
            int[] nums = new int[] { 1 };
            int[,] queries = new int[,] { {4 ,0}};

            int[] answer = new int[nums.Length];
        
            
            
            for (int coluna = 0; coluna < nums.Length; coluna++)
            {
               
                if (coluna == queries[coluna, 1]) //irá ver se o apontador tme o mesmo vallor que esta  namlinha 1 coluna x
                {

                    // se tiver o mesmo valor vai soma
                    nums[coluna] +=  queries[coluna, 0];
                 }
                else 
                {

                    temporario = coluna;
                    //coluna = 0;
                    coluna = queries[coluna, 1]; //vai igualar o valor que esta no index da matriz

                    nums[coluna] += queries[temporario, 0]; // soma os valores que estao na primeira linha da matriz

                    coluna = temporario;

                                   }

                for(int i=0; i < answer.Length; i++) //tenho de fazer um loop a parte para que possa fazer a soma de todo o array
                {
                    if (nums[i] %2==0)
                    {
                        answer[coluna] += nums[i];
                    }
                        

                }

            }

            Console.WriteLine("ARRAY Final: ");
            for (int i = 0; i < answer.Length; i++)
            {
               // answer[i] = pares[i] + pares[i + 1];
                Console.WriteLine("{0}", answer[i]);

            }

        }
    }
}
 