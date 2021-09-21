using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Agenda3
{
    public struct Agenda
    {

        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Logradouro { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string DataNiver { get; set; }
        public string Obs { get; set; }
        

        //Construtor
        public Agenda(string _primeiro_nome, string _ultimo_nome, string _endereco, string _celular, string _email, string _data_niver, string _obs )
        {
            this.PrimeiroNome = _primeiro_nome;
            this.UltimoNome = _ultimo_nome;
            this.Logradouro = _endereco;
            this.Celular = _celular;
            this.Email = _email;
            this.DataNiver = _data_niver;
            this.Obs = _obs;
        }
    }

    public struct Metodos
    {

        //Inserção de uma nova pessoa na agenda
        public static void InserirPessoaAgenda(List<Agenda> _agendaTelefonicaList, Agenda agenda)
        {
            //recuperando agenda que foi passada como parametro
            List<Agenda> _list = _agendaTelefonicaList;

            //Adiconando nova pessoa à agenda
            _list.Add(agenda);

            //Vizualizando agenda preenchida
            Metodos.VizualizarAgenda(_list);

            //Carregando menu principal
            Metodos.CarregarMenuPrincipal();

            //Guarda o valor digitado pelo usuario
            string _menu = Console.ReadLine().ToString();

            //Realiza ação de acorodo com a opção escolhida pelo usuario
            Metodos.MenuOpcoes(_agendaTelefonicaList, _menu);
        }

        //Vizualizar agenda
        public static void VizualizarAgenda(List<Agenda> _agendaTelefonicaList)
        {
            Console.WriteLine();
            Console.WriteLine("ID\tNome\t\tEndereço\tCelular\t\tE-mail\t\t\tData de Aniversário\tObs:");
            Console.WriteLine();

            for (int i = 0; i < _agendaTelefonicaList.Count; i++)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", i,
                _agendaTelefonicaList[i].PrimeiroNome,
                _agendaTelefonicaList[i].UltimoNome,
                _agendaTelefonicaList[i].Logradouro,
                _agendaTelefonicaList[i].Celular,
                _agendaTelefonicaList[i].Email,
                _agendaTelefonicaList[i].DataNiver,
                _agendaTelefonicaList[i].Obs);



        }

            //Carregando menu principal
            Metodos.CarregarMenuPrincipal();

            //Recuperando menu digitado pela pessoa
            string _menu = Console.ReadLine().ToString();

            //Carregando menu correspodente
            Metodos.MenuOpcoes(_agendaTelefonicaList, _menu);
        }

        //Método que monta menu para o usuario
        public static void MenuOpcoes(List<Agenda> _agendaTelefonicaList, string _menu)
        {
            switch (_menu)
            {
                case "1":
                    //Vizualizando agenda
                    Metodos.VizualizarAgenda(_agendaTelefonicaList);
                    break;

                case "2":
                    Console.WriteLine("Digite o primeiro nome da pessoa.");
                    string _primeiro_nome = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Digite o sobrenome da pessoa.");
                    string _ultimo_nome = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Digite o celular da pessoa.");
                    string _celular = Console.ReadLine();
                    Console.WriteLine("Digite o endereço da pessoa.");
                    string _endereço = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Digite agora o E-mail da pessoa: ");
                    string _email = Console.ReadLine();
                    Console.WriteLine("Digite agora a data de animersário da pessoa: ");
                    string _data_niver = Console.ReadLine();
                    Console.WriteLine("OBS: ");
                    string _obs = Console.ReadLine();


                    Metodos.InserirPessoaAgenda(_agendaTelefonicaList, new Agenda(_primeiro_nome, _ultimo_nome,_endereço,  _celular, _email, _data_niver, _obs));

                    break;

                default:
                    Console.WriteLine("Por favor, atenha-se apenas as opções acima.");
                    break;
            }
        }

        //Carregar MenuPrincipal
        public static void CarregarMenuPrincipal()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Escolha a operação a ser realizada\n" +
                              "1 - Vizualizar agenda\n" +
                              "2 - Inserir registro na agenda\n" +
                              "3 - Alterar registro da agendar\n" +
                              "4 - Excluir registro da agendar\n" +
                              "5 - Fechar aplicão\n" +
                              "6 - Pesquisar");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Criamos um arrayList para guarda Nome, Endereco e Telefone
            List<Agenda> _agendaTelefonicaList = new List<Agenda>();

            //Preenchendo arrayList
            _agendaTelefonicaList.Add(new Agenda("Carlos", "Cadido", "Rua da Amélia", "8989-8989", "hjagsdh@kansldkna", "21-12-1967", "Nenhuma"));
            _agendaTelefonicaList.Add(new Agenda("José", "Cadido", "Rua da Amélia", "8989-8989", "hjagsdh@kansldkna", "21-12-1967", "Nenhuma"));
            _agendaTelefonicaList.Add(new Agenda("Rodrigo", "Cadido", "Rua da Amélia", "8989-8989", "hjagsdh@kansldkna", "21-12-1967", "Nenhuma"));

            //Carregando menu principal
            Metodos.CarregarMenuPrincipal();

            //Guarda o valor digitado pelo usuario
            string _menu = Console.ReadLine().ToString();

            //Realiza ação de acorodo com a opção escolhida pelo usuario
            Metodos.MenuOpcoes(_agendaTelefonicaList, _menu);
        }
    }
}