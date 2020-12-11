using System;
using AulaPOOCelular_02_12.aparelho;



namespace AulaPOOCelular_02_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular ();

            Console.WriteLine("-------------------");
            Console.WriteLine("     Hello Word    ");
            Console.WriteLine("-------------------");

            //ligar celular
            string resposta = celular.Ligar();

            Console.WriteLine(" escolha a ação que deseja fazer");

            int opcao;
            do
            {
                Console.WriteLine("[1] - Fazer ligação");
                Console.WriteLine("[2] - Mandar menssagem ");
                Console.WriteLine("[0] - Desligar celular ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        celular.FazerLigacao();
                        break;

                    case 2:
                    celular.EnviarMenssagem();
                        break;

                    default:
                        break;
                }
                

            } while (opcao != 0);
           
        }
    }
}
