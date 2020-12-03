namespace AulaPOOCelular_02_12.aparelho
{
    public class Celular
    {
        // Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
        // Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
        // Só será possível executar tais métodos se o celular estiver ligado.



        //PROPRIEDADES
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;


        //MÉTODOS
        public string Ligar(){

                System.Console.WriteLine("Ligando celular");
            return cor;
        }
         public string Desligar(){

            System.Console.WriteLine("Desligando celular");
            return Desligar();
        }
        public string FazerLigacao(){
            
            return FazerLigacao();
        }
        public string EnviarMenssagem(){

            return EnviarMenssagem();
        } 
        // public string 
    }
}