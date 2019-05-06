using System;

namespace Calculadorasinmenu
{
    class Program
    {
        static void Main(string[] args)
        {

            string formula;
            double resultado = 0;
            int operador = 0; //1=+, 2=-, 3=*, 4=/
            int indice = 0;
            int segundaOperacion = 0;
            double num1, num2;
            Console.WriteLine("introduce una operacion: ");
            formula = Console.ReadLine();
            while (formula != "q")
            {


                for (int i = 0; i < formula.Length; i++)
                {
                    if (formula.Substring(i, 1) == "m")
                    {
                        if (segundaOperacion < 1)
                        {
                            Console.WriteLine("error, no has usado anteriormente la memoria");
                            i = formula.Length;
                        }

                    }
                    else if ((char.IsDigit(formula, i) == false))
                    {

                        indice = i;
                        switch (formula.Substring(i, 1))
                        {
                            case "+":
                                operador = 1; //1=+, 2=-, 3=*, 4=/
                                break;
                            case "-":
                                operador = 2; //1=+, 2=-, 3=*, 4=/
                                break;
                            case "*":
                                operador = 3; //1=+, 2=-, 3=*, 4=/
                                break;
                            case "/":
                                operador = 4; //1=+, 2=-, 3=*, 4=/
                                break;

                        }
                        if (formula.Substring(0, 1) == "m")
                        {
                            num1 = resultado;
                        }
                        else
                        {
                            num1 = Convert.ToDouble(formula.Substring(0, indice));
                        }
                        num2 = Convert.ToDouble(formula.Substring(indice + 1, formula.Length - indice - 1));
                        switch (operador)
                        {
                            case 1:
                                resultado = num1 + num2;
                                break;
                            case 2:
                                resultado = num1 - num2;
                                break;
                            case 3:
                                resultado = num1 * num2;
                                break;
                            case 4:
                                resultado = num1 / num2;
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine(resultado);

                    }
                }
                segundaOperacion = 1;
                Console.WriteLine("introduce una operacion: ");
                formula = Console.ReadLine();
            }




        }
    }
}
