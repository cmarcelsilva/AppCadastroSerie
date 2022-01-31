using System;

namespace AppCadastroSerie
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();


        static void Main(string[] args)
        {
            
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X");

            switch (opcaoUsuario)
            {
                case "1":
                    Listar();               
                    break;

                case "2":
                    Inserir();
                    break;

                case "3":
                    Atualizar();
                    break;

                case "4":
                    Excluir();
                    break;

                case "5":
                    Visualizar();
                    break;

                case "C":
                    Console.Clear();
                    break;

                
                                       
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a Opção Desejada:");
            Console.WriteLine("1- Listar "); //ok
            Console.WriteLine("2- Inserir");//ok
            Console.WriteLine("3- Atualizar");//ok
            Console.WriteLine("4- Excluir");//ok
            Console.WriteLine("5- Visualizar");//ok
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        private static void Listar()
        {
            Console.WriteLine("Listar Séries");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Série Cadastrada");
            }
            foreach(var serie in lista)
            {
                Console.WriteLine("#ID{0}: - {1}" + serie.RetornaId(), serie.RetornaTitulo()); 
            }
        }
        private static void Inserir()
        {
            Console.WriteLine("Inserir uma nova Série:");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i,Enum.GetName(typeof(Genero),i));
            }

            Console.WriteLine("Digite o Gênero entre as opção acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da Série:");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da Série:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição de Série:");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Inserir(novaSerie);
        }
        private static void Atualizar()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Atualizar(indiceSerie, atualizaSerie);
        }
        public static void Excluir()
        {
            Console.WriteLine("Digite o Id da Série:");
            int numbSerie = int.Parse(Console.ReadLine());

            repositorio.Excluir(numbSerie);

        }

        public static void Visualizar()
        {
            Console.WriteLine("Digite o Id da Série:");
            int numbSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornaPorId(numbSerie);
            Console.WriteLine(serie);
        }      


        
    }
}
