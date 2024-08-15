using System;
using System.ComponentModel;
using System.Data;
using Aula03Colecoes.Models;

namespace Aula03Colecoes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static List<Funcionario> lista = new List<Funcionario>();
        static void Main(string[] args)
        {
            ExemplosListasColecoes();
        }

        public static void CriarLista()
        {
            Funcionario f1 = new Funcionario();

            f1.Id = 1;
            f1.Nome = "FEFE";
            f1.Cpf = "12345678989";
            f1.DataAdmissao = DateTime.Parse("01/04/2006");
            f1.Salario = 10000.0M;
            f1.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;
            lista.Add(f1);


            Funcionario f2 = new Funcionario();
            f2.Id = 2;
            f2.Nome = "Cristiano Ronaldo";
            f2.Cpf = "01987654321";
            f2.DataAdmissao = DateTime.Parse("30/06/2002");
            f2.Salario = 150.000M;
            f2.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.Aprendiz;
            lista.Add(f2);

            Funcionario f3 = new Funcionario();
            f3.Id = 3;
            f3.Nome = "Messi";
            f3.Cpf = "135792468";
            f3.DataAdmissao = DateTime.Parse("01/11/2003");
            f3.Salario = 70.000M;
            f3.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;
            lista.Add(f3);

            Funcionario f4 = new Funcionario();
            f4.Id = 4;
            f4.Nome = "Mbappe";
            f4.Cpf = "246813579";
            f4.DataAdmissao = DateTime.Parse("15/09/2005");
            f4.Salario = 80.000M;
            f4.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.Aprendiz;
            lista.Add(f4);

            Funcionario f5 = new Funcionario();
            f5.Id = 5;
            f5.Nome = "Lewa";
            f5.Cpf = "246813579";
            f5.DataAdmissao = DateTime.Parse("20/10/1998");
            f5.Salario = 90.000M;
            f5.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.Aprendiz;
            lista.Add(f5);

            Funcionario f6 = new Funcionario();
            f6.Id = 6;
            f6.Nome = "Rodrigo Garro";
            f6.Cpf = "246813579";
            f6.DataAdmissao = DateTime.Parse("13/12/1997");
            f6.Salario = 300.000M;
            f6.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;
            lista.Add(f6);
        }

        public static void ExibirLista()
        {

            string dados = "";

            for (int i = 0; i < lista.Count; i++)
            {
                dados += "=======================================================\n";
                dados += string.Format("Id: {0}\n", lista[i].Id);
                dados += string.Format("Nome: {0}\n", lista[i].Nome);
                dados += string.Format("CPF: {0}\n", lista[i].Cpf);
                dados += string.Format("Data admissão: {0}: {0:dd/MM/yyyy}\n", lista[i].DataAdmissao);
                dados += string.Format("Salário: {0}\n", lista[i].Salario);
                dados += string.Format("Tipo: {0}\n", lista[i].TipoFuncionario);
                dados += "=======================================================\n";

            }
            Console.WriteLine(dados);
        }
        
                public static void ObterPorId()
                {
                    lista = lista.FindAll(x => x.Id >= 1); //FindAll encontra tudo que está dentro da lista, e retorna a condição que no caso, aqui retornará o ID que é igual a 1
                    ExibirLista();
                }
                
        public static void ObterPorId(int Id)
        {

            Funcionario fBusca = lista.Find(x => x.Id == Id); //Find encontra apenas um atributo que está dentro da lista, e retorna a condição que no caso, aqui retornará o ID que é igual a 1

            Console.WriteLine($"Personagem encontrado {fBusca.Id}");


        }

        public static void ObterSalario(decimal valor){
            lista = lista.FindAll(x => x.Salario >= valor);
            ExibirLista();

        }
        public static void ExemplosListasColecoes()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("****** Exemplos - Aula 03 Listas e Coleções ******");
            Console.WriteLine("==================================================");
            CriarLista();
            int opcaoEscolhida = 0;
            do
            {
                Console.WriteLine("==================================================");
                Console.WriteLine("---Digite o número referente a opção desejada: ---");
                Console.WriteLine("1-- Obter por Id");
                Console.WriteLine("2-- Adiconar Funcionario");
                Console.WriteLine("3-- Obter por Id digitado");
                Console.WriteLine("4-- Obter por salário digitado");
                Console.WriteLine("==================================================");
                Console.WriteLine("-----Ou tecle qualquer outro número para sair-----");
                Console.WriteLine("==================================================");
                opcaoEscolhida = int.Parse(Console.ReadLine());
                string mensagem = string.Empty;
                switch (opcaoEscolhida)
                {
                    case 1:
                        ObterPorId();
                        break;
                    case 2:
                    Console.WriteLine("opa");
                    break;
                    case 3:
                        Console.WriteLine("Digite o Id do funcionário que você deseja buscar");
                        int id = int.Parse(Console.ReadLine());
                        ObterPorId(id);
                        break;
                    case 4:
                    Console.WriteLine("Digite o salário para obter todos acima do valor indicado");
                    decimal salário = decimal.Parse(Console.ReadLine());
                    ObterSalario(salário);
                    break;
                    default:
                        Console.WriteLine("Saindo do sistema....");
                        break;
                }
            } while (opcaoEscolhida >= 1 && opcaoEscolhida <= 10);
            Console.WriteLine("==================================================");
            Console.WriteLine("* Obrigado por utilizar o sistema e volte sempre *");
            Console.WriteLine("==================================================");
        }

    }


}