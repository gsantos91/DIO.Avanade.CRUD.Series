using System;

namespace DIO.Avanade.CRUD.Series{

    class Program{

        static void Main(string[] args){

            string opcaoUsuario;

            do{

                opcaoUsuario = InterfaceUsuario.ObterOpcaoUsuario();

                switch (opcaoUsuario){
                    
                    case "1":
                        InterfaceUsuario.ListarSeries();
                        break;
                    case "2":
                        InterfaceUsuario.VisualizarSerie();
                        break;
                    case "3":
                        InterfaceUsuario.InserirSerie();
                        break;
                    case "4":
                        InterfaceUsuario.AtualizarSerie();
                        break;
                    case "5":
                        InterfaceUsuario.ExcluirSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        break;
                }
            }while(opcaoUsuario != "X");

            Console.WriteLine("Encerrando sistema. Tecle Enter para sair.");
            Console.ReadLine();
        }
    }
}