using System;

namespace TesteFormulario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem Vindo!");
            string nome, cidade, numero, sexo;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua cidade: ");
            cidade = Console.ReadLine();

          Console.Write("Digite seu numero de Telefone: ");
           numero = Console.ReadLine();

            Console.Write("Digite M para Masculino e F para Feminino: ");
            sexo = Console.ReadLine();
            
            Console.WriteLine("Ola {0} , você esta morando em  {1} , e seu numero de telefone para contato é  esse {2} , e você e do sexo {3}",nome,cidade,numero,sexo);
            
            Console.ReadKey(); 
        }
    }
}
