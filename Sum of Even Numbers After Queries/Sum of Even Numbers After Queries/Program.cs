using System;

namespace Sum_of_Even_Numbers_After_Queries
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[] { 1, 2, 3, 4 };

            int[,] queries = new int[,] { {1, 0},
                {-3, 1},
                { -4,0 },
                { 2,3 }

            };

            int[] answer = new int[nums.Length];



            for (int coluna = 0; coluna < queries.GetLength(0); coluna++)
            {
                if (coluna == queries[coluna, 1]) //irá ver se o apontador tme o mesmo vallor que esta  namlinha 1 coluna x
                {

                    // se tiver o mesmo valor vai somar
                    Console.WriteLine("Apontador: " + coluna + "\tQueries:  " + queries[coluna, 1]);

                    nums[coluna] +=  queries[coluna, 0];

                }
                else //se nao tiver, bem.... logo se ve
                {

                    //if(coluna < queries[coluna,1])


                    //  coluna = queries[coluna, 1];


                }

                for (int linha =0; linha < queries.GetLength(0); linha++)
                {
                    

                }



            }

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("{0}", nums[i]);

            //}


            //fazer as somas de todos os numeros pares
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if ( nums[i] % 2 == 0 && nums[i + 1] % 2 == 0 )
                {

                    answer[i] = nums[i] + nums[i + 1]; //vai guardar a soma dos numeros pares  

                }

            }

            Console.WriteLine("ARRAY NUMS: ");
            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine("{0}", nums[i]);

            }

        }
    }
}
 