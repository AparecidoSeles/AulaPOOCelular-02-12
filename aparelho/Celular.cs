using System;

namespace AulaPOOCelular_02_12.aparelho
{
    public class Celular
    {
        // Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
        // Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
        // Só será possível executar tais métodos se o celular estiver ligado.



        //PROPRIEDADES
        public string cor = "preto";
        public string modelo = "Asus";
        public float tamanho = 5.5f;
        public bool ligado;
        string resposta ;

        //MÉTODOS
        public string Ligar(){

                System.Console.WriteLine("Deseja ligar o celular? s/n ");
                resposta = Console.ReadLine();

                if (resposta == "s")
                {
                    Console.WriteLine("Celular ligado" );
                    ligado = true;
                    
                } else{
                    Console.WriteLine("Celular desligado");
                    ligado = false;
                }

            return resposta;
        }
         public string Desligar(){

            System.Console.WriteLine("Desligando celular");
            return "";
        }
        public string FazerLigacao(){
                    Console.WriteLine("Ligação efetuada");
           return "";
        }
        public string EnviarMenssagem(){

            return "";
        } 
        // public string 
    }
}