using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];
            try
            {
                Cadastrar("teste");
                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine(arr[i]);
                //}
            }
            catch (IndexOutOfRangeException iEx)
            {
                Console.WriteLine(iEx.Message);
                Console.WriteLine("Não encontrei o index na lista");
            }
            catch (ArgumentNullException aEx)
            {
                Console.WriteLine(aEx.Message);
                Console.WriteLine("Oops! Algo deu errado!");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Exceção customizada");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Oops! Algo deu errado!");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
                Console.WriteLine("Aqui eu poderia fechar um arquivo");
            }

            //Cadastrar("");
        }

        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new MinhaException(DateTime.Now);
                //throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }


            public DateTime QuandoAconteceu { get; set; }         
        }
    }
}
