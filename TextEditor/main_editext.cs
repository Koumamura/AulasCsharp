using System;   
namespace TextEditor{
    class main_editext
        {
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Text Editor");
            Console.WriteLine(" Selecione uma das Opção");
            Console.WriteLine("0 - Sair do programa ");
            Console.WriteLine("1 - Criar Texto ");
            Console.WriteLine("2 - Abrir Texto");
            Console.WriteLine("3 - Editar Texto Existente");
            string Data = Console.ReadLine();

            switch (Data){
                case "0": System.Environment.Exit(-1); break;
                case "1":  Editar(); break;
                case "2":  Abrir(); break;
                case "3":  Abrir(true); break;
                default :Menu(); break;
            }

            
        }

        private static void Abrir(bool edit = false)
        {
            Console.Clear();
            Console.WriteLine(" Digite o Caminho do Arquivo ");
            
            var path= Console.ReadLine();
            string Texto ="";

            using (var texto = new StreamReader(path))
            {
                Texto = texto.ReadToEnd();
                Console.WriteLine(Texto);
            }
            if(edit){
                Editar(Texto);
            }
            Console.ReadKey();
            Menu();
        }

        private static void Editar(string texto = "")
        {
            string Texto = texto;
            Console.Clear();
            Console.WriteLine("Modo Criação ativado (pressione ESC pra sair do editor)");
        
            do
            {   Console.Write(Texto);
                Texto += Console.ReadLine();
                Texto += Environment.NewLine;
                
            } while (Console.ReadKey().Key != ConsoleKey.Escape );

            Console.WriteLine(" Desejsa salvar o texto ?");
            Console.WriteLine("1  - Salvar o texto  ");
            Console.WriteLine("2  - Sair sem Salvar ");
            string Resp = Console.ReadLine();

            if (Resp == "2" ){
              Menu();
            }
            else 
            {
                Salvar(Texto);
            }


        }
        
        private static void Salvar (string texto)
        {
            Console.Clear();
            Console.WriteLine("Caminho que deseja salvar o arquivo");
            var path= Console.ReadLine();

            using (var arquivo = new StreamWriter(path)) 
            {
                arquivo.Write(texto);
            }

            Console.WriteLine($"Arquvio foi salvo em {path}");
        }
    }
  
}