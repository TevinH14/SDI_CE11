using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamilton_Tevin_FindErrorsFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tevin Hamiloton
              *find the errors function
              * 01/17/18
              */

            /* INSTRUCTIONS
                     *  1. Copy this code to a new project, do not work in this file!
                     *  2. Start by finding and fixing all of the Syntax Errors first.
                     *     - Syntax errors are the red squiggy lines that will prevent the code from running.
                     *  3. Now the code should run and you can see the output on the console.
                     *  4. Find the Logical Errors
                     *     - Logical errors will give you the wrong output.
                     *     - These are a bit harder to find.  Keep checking the correct output given!
                     *     - Follow any additional instructions given in the comments.
                     *  5. Once you think you are done, check your output line by line against the 
                     *     given correct output.
                     *  6. If it matches perfectly, zip your whole project file and submit it to FSO.
                     * */

            //Clear the console of the error
            Console.Clear();

            //Welcoe the user
            Console.WriteLine("Hello and welcome to the bulk price calculator!\r\n");


            //Ask for the bulk price and validate it.
            Console.WriteLine("\r\nWhat is the cost of the bulk price of your items?");

            string costBulkString = Console.ReadLine();

            decimal costBulk;

            while (!decimal.TryParse(costBulkString, out costBulk)) //Swapped string for decimal
            {
                Console.WriteLine("Please only type in numbers!\r\nWhat is the cost of the bulk price of your items?");

                costBulkString = Console.ReadLine();

            }


            //Ask the user for number of pieces in the bulk package and validate it
            Console.WriteLine("\r\nHow many of each item is in the bulk package?");

            string numberOfPiecesString = Console.ReadLine();

            int numberOfPieces;

            while (!(int.TryParse(numberOfPiecesString, out numberOfPieces))) //Swapped string for decimal
            {
                Console.WriteLine("Please only type in numbers!\r\nHow many of each item is in the bulk package?");

                numberOfPiecesString = Console.ReadLine();

            }


            //Function Call to CostPerPiece function to get the individual price
            decimal indivualCost = CostPerPieces(costBulk, numberOfPieces);

            //Give the user the per piece cost
            Console.Write("\r\nThe bulk price is {0} for {1} items.", costBulk.ToString("c"), numberOfPieces);
            Console.WriteLine("\r\nThis makes the cost of one item {0}", indivualCost.ToString("c"));


            //Ask the user for the number of items they would like to buy and validate.
            Console.WriteLine("\r\n Assuming you can get the per piece price, how many items would you like to purchase?");

            string numberWantedString = Console.ReadLine();

            int numberWanted;

            while (!(int.TryParse(numberWantedString, out numberWanted))) //Swapped string for decimal
            {
                Console.WriteLine("Please only type in numbers!\r\nHow many of each items would you like to purchase?");

                numberWantedString = Console.ReadLine();

            }


            //Function call to the FinalCost function 
            decimal amountToPay = FinalCost(indivualCost, numberWanted);

            //Final output to the user
            Console.WriteLine("The final cost for {0} items would be {1}.\r\n", numberWanted, amountToPay.ToString("c"));



        }






        public static decimal CostPerPieces(decimal cost, int numPieces)
        {

            decimal costOfOne = cost / numPieces;
            return costOfOne;

        }


        public static decimal FinalCost(decimal costOf1, int numPieces)
        {

            decimal results = costOf1 * numPieces;
            return results;

        }

    }
}

