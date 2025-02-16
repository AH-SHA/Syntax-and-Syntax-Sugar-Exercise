namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ORIGINAL CODE - has been commented out
            //int answer = 4;
            //string response;
            //if (answer < 9)
            //{
                //response = answer + " is less than nine";
            //}
            //else
            //{
                //response = answer + " is greater than or equal to nine";
            //}


            /* NOTE:  The original code didn't "run" in VSS.  I tried to update the .NET version, but I am
             * not sure the update was properly applied.  So, this file displays the answer, but
             * the answer is not operable.*/

            //Convert existing code to "Inline If" statement:

            var answer = 4;

            var response = (answer < 9) ? answer + " is less than nine" : answer + " is greater than or equal to nine";

            Console.WriteLine(response);
              
            

        }
    }
}
