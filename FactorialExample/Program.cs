using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialExample
{
    class Program
    {
        public static ulong Factorial(ulong num)
        {
            return (num == 0) ? 1 : (num * Factorial(num - 1));
        }

        static void Main(string[] args)
        {
            char restartProgram;
            do
            {
                #region VARIABLE DECLARATION

                int inputNum = 0;
                ulong factorial = 1;

                #endregion

                #region WRITE TEXT ON CONSOLE

                Console.Clear();
                Console.WriteLine();
                Console.Write(Environment.NewLine + "Please Enter number a Number : ");

                #endregion

                #region USER INPUT

                try
                {
                    int.TryParse(Convert.ToString(Console.ReadLine()), out inputNum);
                }
                catch { inputNum = 0; }

                #endregion

                if (inputNum > 0)
                {
                    #region LOGIC 1

                    Enumerable.Range(1, inputNum).ToList().ForEach(x => { factorial *= Convert.ToUInt64(x); });

                    Console.WriteLine();
                    Console.WriteLine("LOGIC 1: Factorial: " + factorial);

                    #endregion

                    #region LOGIC 2 - By Method

                    factorial = Factorial(Convert.ToUInt64(inputNum));
                    Console.WriteLine("LOGIC 2: Factorial: " + factorial);

                    #endregion
                }
                else
                {
                    Console.WriteLine("Please enter correct number.");
                }

                #region RESUME PROGRAM

                Console.WriteLine();
                Console.Write("Do you want to continue (Y/N)? ");
                char.TryParse(Convert.ToString(Console.ReadLine()), out restartProgram);

                #endregion

            } while (restartProgram.Equals('y') || restartProgram.Equals('Y'));
        }
    }
}
