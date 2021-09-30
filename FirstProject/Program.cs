using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FirstProject
{
    class Program
    {
        // trabalhando com ENUM
        enum corEnum { azul, verde, amarelo };
        // como o primeiro vale o 1, os outros vao seguir a  ordem: 2,3,4...
        enum opcao { criar=1, deletar, editar };

        static void Main(string[] args)
        {
            // trabalhando com tipos
            float velocidade = 5.2f; // colocar f no final para variaveis em float
            bool testeBooleano = true; // teste boleano

            // tipo var nao se pode alterar o tipo
            var testeVar = "on no c#!";
            testeVar = "off no c#!";

            // tipo dynamic pode alterar o tipo dela
            dynamic variavelDinamica = "teste";
            variavelDinamica = 123;
            
            
            // operadores lógicos:
            // && (e ou and) || (ou o or)
            // int.Parse(Console.ReadLine()) converte valor pra inteiro

            // capturando entrada do teclado
            Console.WriteLine("teste input do teclado: ");
            String teste = Console.ReadLine();
            Console.WriteLine(teste);

            //chamando função
            testeFuncao(10, "monitor");

            // pegando valores absolutos
            int valorAbs = Math.Abs(-20);

            // Array 
            // Nao pode mudar mais o tamanho dele depois de colocar o tamanho
            string[] testeArray = new string[3] {"a", "b", "c" } ;
            testeArray[0] = "d";
            Console.WriteLine(testeArray[0]);
            int[] valores = { 1, 2, 3, 4, 5 };

            // chamando Enum
            corEnum testeCor = corEnum.amarelo;
            //convertendo enum pra um numero (index dele)
            Console.WriteLine((int)testeCor);
            Console.WriteLine((corEnum)2);

            // trabalhando com switch
            string cor = "azul";
            switch (cor)
            {
                case "azul":
                    Console.WriteLine(cor);
                    break;
                default:
                    Console.WriteLine("nehum caso");
                    break;
            }

            //switch e Enum
            int index = int.Parse(Console.ReadLine());
            opcao opcaoSelecionada = (opcao)index;
            switch (opcaoSelecionada)
            {
                case opcao.criar:
                    break;
                case opcao.deletar:
                    break;
                case opcao.editar:
                    break;
                default:
                    break;
            }
            

            Console.ReadLine();
        }


        static void testeFuncao(int valor, string nome)
        {
            Console.WriteLine("nome: " + nome);
            Console.WriteLine(valor);
        }
    }
}
