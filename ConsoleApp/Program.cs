using CalcDecomposition.Shared;
using CalcDecomposition.Shared.Queries;
using System;

namespace DecompositionCalculationApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var breakApp = false;

            while (!breakApp)
            {
                try
                {
                    Console.WriteLine("====================================================================");
                    Console.WriteLine(Constants.EscolhaOpcoes);
                    Console.WriteLine(Constants.OpcaoUm);
                    Console.WriteLine(Constants.OpcaoDois);

                    var option = Convert.ToInt32(Console.ReadLine());

                    if (OptionIsValid(option))
                    {
                        if (option == 2)
                        {
                            breakApp = true;
                            Console.WriteLine(Constants.AppFinalizado);
                            return;
                        }

                        Console.WriteLine($"\n{Constants.InformeUmNumero}");
                        var number = Convert.ToInt32(Console.ReadLine());

                        var result = Calculate(number);

                        if (!result.Success)
                            WriteError(result.Message);
                        else
                            Console.WriteLine(result.ToString());
                    }
                    else
                        WriteError(Constants.OpcaoMenuInvalida);
                }
                catch (Exception ex)
                {
                    WriteError(ex.Message);
                }
            }
        }

        private static bool OptionIsValid(int number) => number == 1 || number == 2;

        private static void WriteError(string message)
        {
            Console.WriteLine(Constants.NaoFoiPossivelCalcular);
            Console.WriteLine($"{Constants.Erro}: {message}");
            Console.WriteLine(Constants.TentarNovamente);
            Console.WriteLine("");
        }

        private static CalculateDivisorResult Calculate(int number)
        {
            try
            {
                return CalculateDivisorQueries.GetDividersByNumber(number);
            }
            catch (Exception ex)
            {
                return new CalculateDivisorResult(false, ex.Message);
            }
        }
    }
}
