namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
                Estrutura de exceções no DOTNET

                Exception
                    > SystemException
                        >> IndexOutOfRangeException
                        >> NullReferenceException
                        >> InvalidCastException
                        >> etc...
                    > ApplicationException

                ApplicationException: São criadas pelo DEV, são personalizadas
                SystemException: São geradas pelo DOTNET, das bibliotecas do próprio DOTNET
            */

            try
            {
                System.Console.WriteLine(">>> Dentro do TRY");
                int n1 = 10;
                int result = n1 / 0;
                System.Console.WriteLine(">>> Fim do TRY");
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine(">>> Capturou um erro de DIVISÃO POR ZEROS:");
                System.Console.WriteLine(e);
                System.Console.WriteLine(">>> Message: " + e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(">>> Capturou um erro:");
                System.Console.WriteLine(e);
                System.Console.WriteLine(">>> Message: " + e.Message);
            }
            finally
            {
                System.Console.WriteLine("FINALLY: Executa sempre, com ou sem erro!");
            }
        }
    }
}