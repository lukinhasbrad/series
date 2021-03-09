using System;

namespace series
{
    class Program
    {
     
     
     static RepositorioSerie repositorio = new RepositorioSerie();
     
     
        static void Main(string[] args)
        {
            string opcaodesejada = MenuComeco();
            while (opcaodesejada.ToUpper() != "X")
            {
                switch (opcaodesejada)
                {
                
                case "1":

                ListarSerie();        

                break;

                case "2":

                InserirSerie();

                break;

                case "3":

                AtualizaSerie();

                break;

                case "4":

                ExcluirSerie();

                break;

                case "5":

                VisualizarSerie();

                break;

                case "6":

                Console.Clear();

                break;

                default:

                throw new ArgumentOutOfRangeException();


                }



            
            }
            
            

        }









        
        private static void ListarSerie()
            {
                //listar series
                
                Console.WriteLine("Listagem de séries");

                var lista = repositorio.lista();
                if (lista.Count == 0)
                {
                    Console.WriteLine("Nenhuma série cadastrada!!");
                    return;
                }
                foreach ( var serie in lista)
                {
                    var excluido = serie.retornaExcluido();

                    
                    Console.WriteLine("ID {0}: {1}", serie.retornaId(), serie.retornaTitulo());
                }
            }


          
            private static void InserirSerie()
            {
                
                //inserir nova serie

                Console.WriteLine("Vamos inserir uma série!!");
                foreach( int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}: {1}", Enum.GetName(typeof(Genero), i));
                    
                }

                Console.WriteLine("Digite os gênero mostrado nas opções: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o título da série ");
                string entradaTitulo = Console.ReadLine();

                Console.WriteLine("Digite o ano da série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a descrição da série ");
                string entradaDescricao = Console.ReadLine();

                Series novaSerie = new Series(id: repositorio.ProximoId(),
                                              genero: (Genero)entradaGenero,
                                              Titulo: entradaTitulo,
                                              Descricao: entradaDescricao,
                                              Ano: entradaAno);

                repositorio.Insere(novaSerie);                               

            }

            private static void AtualizaSerie()
            {
                    //atualizar serie

                Console.WriteLine("Informe o ID da série: ");
                int indiceSerie = int.Parse(Console.ReadLine());

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                   Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
                }

                Console.WriteLine("Digite o gênero:  ");
                int entradaGenero = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o título da série: ");
                string entradaTitulo = Console.ReadLine();

                Console.WriteLine("Digite o ano da série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a descrição da série ");
                string entradaDescricao = Console.ReadLine();

                Series atualizaserie = new Series(id: indiceSerie,
                                              genero: (Genero)entradaGenero,
                                              Titulo: entradaTitulo,
                                              Descricao: entradaDescricao,
                                              Ano: entradaAno);

                repositorio.Atualiza(indiceSerie, atualizaserie);


            }

            private static void ExcluirSerie()
            {
                //excluir series

            Console.WriteLine("Informe o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);

            }

            private static void VisualizarSerie()
            {
                    //visualização de series

            Console.WriteLine("Informe o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            
            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);


            }






        private static string MenuComeco()
        {
        Console.WriteLine();
        Console.WriteLine("Series Minhas");
        Console.WriteLine("Informe a opção que deseja:");
        Console.WriteLine();
        Console.WriteLine("1 - Listar séries");
        Console.WriteLine("2 - Inserir nova série");
        Console.WriteLine("3 - Atualizar séries");
        Console.WriteLine("4 - Excluir séries");
        Console.WriteLine("5 - Visualizar séries");
        Console.WriteLine("6 - Limpar tela  ");
        Console.WriteLine("X - Sair");

        string opcaodesejada = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaodesejada;

        }

    }
    
    
}
