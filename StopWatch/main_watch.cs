using System;


namespace StopWatch{
    class main_watch{
       
        static int IntCurrent  = 0;
        
        static void Main(string[] args){
            Menu();
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("         Adicione um valor para contagem progressiva ");
            Console.WriteLine("   ------------------------------------------------------------"); 
            Console.WriteLine("     Adicione S para sinalizar Segundos : Exp -> 10s = 10 Segundos");
            Console.WriteLine("     Adicione M para sinalizar Minutos : Exp -> 1M = 1 Minutor");
            Console.WriteLine("     Digite 0 para sair da aplicação");
            string Data = Console.ReadLine().ToLower();
            // Sai da aplicação cado 0
            if(Data == "0" || Data == "0s")
                System.Environment.Exit(-1);

            char Type = char.Parse(Data.Substring(Data.Length - 1, 1));
            int Time = TestInt(Data.Substring(0, Data.Length - 1));
          

 
         

            Start(Time,Type);
        }

         //  Função comporta Dias , porem não utilizado no momento
        static void Start(int time , char type){
            
            int CurrentTime = 0;
            bool FormatoValido = true;
            switch (type)
            {
                case's':
                    time *= 1; break;
                case'm':
                    time *= 60 ; break ;
                case'h':
                    time *= (60*60) ; break ;    
                default:
               Console.WriteLine($"O formato {type}  é um Tipo invalido, Tente -> Nº + o tipo desejado , S ou M");
               Console.ReadKey(); FormatoValido = false; break;
              
            
            }
            if (!FormatoValido)
                Menu();


           



            // Show in Display  -> time
            
            while(CurrentTime < time){
                Console.Clear();
                Console.WriteLine("Horas : Minutos : Segundos");
                CurrentTime ++;
                 //  tratar tempo  para 00:00:00
                string Full_Time =  Trata_tempo(CurrentTime);
                
                Console.WriteLine(Full_Time);
                Thread.Sleep(1000);  
            }


            Console.WriteLine("Deseja continuar na paricação ?");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 1 = Sim   2 = Não");
            string res = Console.ReadLine();
            if (res == "2")
                System.Environment.Exit(0);
            else
                Menu();

        }

        static string Trata_tempo(int timeSec){

            int Minutos = (int) timeSec/60 ;
            int Horas = (int) timeSec/3600 ;
            int Dias = (int) timeSec/86400 ;
            int Real_Seconds = timeSec - (60*Minutos);
            int Real_Minutos = Minutos - (60*Horas) ;
            int Real_Horas = Horas - (24*Dias) ;

            string Time_Treaty = (Real_Horas + " : " + Real_Minutos + " : " + Real_Seconds).ToString();

            if(Dias >= 30){
                
                Console.WriteLine("Você atingil o tempo maximo estimado do Contador por favor reinicie a aplicação");
            }

            return Time_Treaty;
        }

            static int TestInt( string input){
        
            if(input.All(char.IsDigit) & input != null & input != "") {             
               
                IntCurrent = int.Parse(input);    }
            else {
                Console.WriteLine($"O formato {input}  é um fomato invalido, Tente -> Nº + o tipo desejado , S ou M"); Console.ReadKey(); Menu();  }
            
            return IntCurrent ;

        }
    }
    
}
