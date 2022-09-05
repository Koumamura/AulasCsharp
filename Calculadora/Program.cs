using System;
using System.Linq;


namespace Calculator{

    class  Program{
        static string Operador = "";
        static float Result = 0.0f;
        static float FloatCurrent = 0.0f;
         static int IntCurrent = 0;
        static void Main(string[] args) {
            
            Console.Clear(); 

            Menu();
            
        }
        
        static void Menu(){
             Console.Clear();
             Console.WriteLine("Digiteo o Valor de acordo com a operação deseja fazer ! ");
             Console.WriteLine("");
             Console.WriteLine(" 1 - Soma");
             Console.WriteLine(" 2 - Subtração");
             Console.WriteLine(" 3 - Multiplicar");
             Console.WriteLine(" 4 - Divisão");

             int Opcao = TestInt(Console.ReadLine()) ;
             if (Opcao  == 1 || Opcao  == 2|| Opcao  == 3|| Opcao == 4){
                 Console.Clear();
                Console.WriteLine("Digite o Primeiro Valor");
         
          

                float Valor1 = TestFloat(Console.ReadLine());
                 Console.WriteLine("Digite o Segundo Valor");
                float Valor2 = TestFloat(Console.ReadLine());
                Operacao(Opcao, Valor1, Valor2);
                Console.WriteLine("");  
                Console.WriteLine($"o Resultado da {Operador} é {Result}");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Deseja Realizar mais um calculo ?");
                Console.WriteLine(""); 
                Console.WriteLine(" 1 - Sim  , 2 - Não ");

                Opcao = TestInt(Console.ReadLine());
                if (Opcao == 2)
                    System.Environment.Exit(-1);
                else 
                    Menu();

           
              }
            else{
                Console.WriteLine(" Valor Invalido");
                Menu();
            }



           
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Adicione o Segundo  valor : ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float Subtrac = valor1 - valor2;
        }
        
        static void Operacao(int operacao, float valor1, float valor2){
                           
                switch (operacao)
                {
                    case 1 : Result = valor1 + valor2;  Operador = "Soma" ; break;
                    case 2 : Result = valor1 - valor2; Operador = "Subtração" ;break;
                    case 3 : Result = valor1 * valor2; Operador = "Multiplicação"; break;
                    case 4 : Result = valor1 / valor2; Operador = "Divisão";break;                  
                    
                }
           
        }

        static float TestFloat (string input){
        
            if(input.All(char.IsDigit) & input != null & input != "")
                FloatCurrent = float.Parse(input);
               
            else {
                Console.WriteLine($" O Valor {input} é Invalido"); Console.ReadKey(); Menu();  }
            
            return FloatCurrent ;

        }
        static int TestInt( string input){
        
            if(input.All(char.IsDigit) & input != null & input != "") {             
                IntCurrent = int.Parse(input);    }
            else {
                Console.WriteLine("Valor é Invalido"); Console.ReadKey(); Menu();  }
            
            return IntCurrent ;

        }
    }
        
}