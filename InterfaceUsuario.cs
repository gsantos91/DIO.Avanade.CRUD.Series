using System;

namespace DIO.Avanade.CRUD.Series{

    public class InterfaceUsuario{

        static SerieRepositorio repositorio = new SerieRepositorio();
        
        public static string ObterOpcaoUsuario(){

            Console.WriteLine();
            Console.WriteLine("Bem vindo ao sistema de cadastro de séries.");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1. Listar todas as séries");
            Console.WriteLine("2. Visualizar série");
            Console.WriteLine("3. Inserir série");
            Console.WriteLine("4. Atualizar série");
            Console.WriteLine("5. Excluir série");
            Console.WriteLine("C. Limpar tela");
            Console.WriteLine("X. Sair do sistema");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcaoUsuario;
        }

        public static void ListarSeries(){

            Console.WriteLine("Lista de Séries");

            var lista = repositorio.lista();

            if(lista.Count == 0){
                
                Console.WriteLine("Nenhuma série cadastrada.");
                
                return;
            }

            foreach(var serie in lista){

                var excluido = serie.RetornaExcluido();

                Console.WriteLine("#ID {0}: {1} {2}",
                    serie.RetornaID(), serie.RetornaTitulo(), (excluido ? "Excluído" : ""));
            }
        }

        public static void VisualizarSerie(){

            var lista = repositorio.lista();

            if(lista.Count == 0){

                Console.WriteLine("Nenhuma série cadastrada.");

                return;
            }

            Console.Write("Digite o ID da série: ");

            int indiceSerie = int.Parse(Console.ReadLine());
            if(lista.Count <= indiceSerie){
                Console.WriteLine("Nenhuma série cadastrada com esse ID.");
                
                return;
            }

            var serie = repositorio.RetornaPorID(indiceSerie);

            Console.WriteLine(serie);
        }

        public static void InserirSerie(){

            foreach(int i in Enum.GetValues(typeof(Genero))){

                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoID(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Insere(novaSerie);
        }

        
        public static void AtualizarSerie(){

            var lista = repositorio.lista();

            if(lista.Count == 0){

                Console.WriteLine("Nenhuma série cadastrada.");

                return;
            }

            Console.Write("Digite o ID da série: ");

            int indiceSerie = int.Parse(Console.ReadLine());
            if(lista.Count <= indiceSerie){
                Console.WriteLine("Nenhuma série cadastrada com esse ID.");
                
                return;
            }

            foreach(int i in Enum.GetValues(typeof(Genero))){

                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Inserir nova série");

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: repositorio.ProximoID(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
        
        public static void ExcluirSerie(){

            var lista = repositorio.lista();

            if(lista.Count == 0){

                Console.WriteLine("Nenhuma série cadastrada.");

                return;
            }

            Console.Write("Digite o ID da série: ");

            int indiceSerie = int.Parse(Console.ReadLine());
            if(lista.Count <= indiceSerie){
                Console.WriteLine("Nenhuma série cadastrada com esse ID.");
                
                return;
            }

            repositorio.Exclui(indiceSerie);
        }
    }
}