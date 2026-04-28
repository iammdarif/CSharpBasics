namespace ExceptionHandling
{
    internal class Program
    {

        const string operator_symbol = "OPERATORSYMBOL";
        const string operand_1 = "OPERAND1";
        const string operand_2 = "OPERAND2";

        static void Main(string[] args)
        {
            int operand1, operand2;
            int result = 0;
            char operatorSymbol;

            Console.WriteLine("Basic Calculator");
            Console.WriteLine("-----------------");
            Console.WriteLine();


            try
            {
                Console.WriteLine("Main method execution started.");
                Console.WriteLine();

                Console.WriteLine("Please enter a whole number value for the first operand:");
                operand1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a whole number value for the second operand:");
                operand2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a valid operator symbol ('+', '-', '*', '/'):");
                operatorSymbol = char.Parse(Console.ReadLine());

                result = Calculate(operand1, operand2, operatorSymbol);                

                Console.WriteLine();
                Console.WriteLine($"{operand1} {operatorSymbol} {operand2} = {result}");
            }
            catch (CalculationResultOverflowException ex)
            {
                //Logger.Log($"{ex.StackTrace}");
                Logger.Log(ex, LogLevel.Basic);
                //Console.WriteLine();
                //Console.WriteLine($"Inner exception: {ex.InnerException?.Message}");
                ExceptionDisplayFormat(ex.Message);
                //Console.WriteLine($"Calculation result is greater or smaller than {Int32.MinValue} and {Int32.MaxValue}");
            }
            catch (OverflowException ex)
            {
                ExceptionDisplayFormat(ex.Message);
                Console.WriteLine($"Operand 1 or Operand 2 is greater or smaller than {Int32.MinValue} and {Int32.MaxValue}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Inner exception: {ex.InnerException?.Message}");
                ExceptionDisplayFormat(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                ExceptionDisplayFormat(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                ExceptionDisplayFormat(ex.Message);

            }
            catch (FormatException ex)
            {
                ExceptionDisplayFormat(ex.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Main method execution completed.");
            }          

            
            Console.ReadKey(); 
        }

        private static void ExceptionDisplayFormat(string ex)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ex}");
            Console.ResetColor();
        }

        private static int Calculate(int operand1, int operand2, char operatorSymbol)
        { 
            int result = 0;

            try
            {
                switch (operatorSymbol)
                {
                    case '+':
                        checked
                        {
                            result = operand1 + operand2;
                        }
                        break;
                    case '-':
                        checked
                        {
                            result = operand1 - operand2;
                        }
                        break;
                    case '*':
                        checked
                        {
                            result = operand1 * operand2;
                        }
                        break;
                    case '/':
                        checked
                        {
                            result = operand1 / operand2;
                        }
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operator symbol. Please use one of the following: '+', '-', '*', '/'");
                        //Console.WriteLine("Invalid operator symbol. Please use one of the following: '+', '-', '*', '/'");
                        break;
                }
            }
            catch (OverflowException ex)
            {
                throw new CalculationResultOverflowException(ex.Message, ex.InnerException);
            }
            catch (InvalidOperationException ex)
            {
                throw new ArgumentException($"{nameof(operatorSymbol)} is invalid.", operator_symbol, ex.InnerException);
            }
            catch (DivideByZeroException ex)
            { 
                throw new ArgumentException($"Cannot divide by zero. {nameof(operand2)} cannot be zero when the operator is '/'.", operand_2, ex.InnerException);
            }
            finally
            {
                Console.WriteLine("Calculate method execution completed.");
            }
            
            return result;
        }
    }
}
