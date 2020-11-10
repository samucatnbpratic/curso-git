using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCurso_Nelio_Alves
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vetor_aula_70();

            // Modificador_Parametros_params_aula_72();

            //Modificador_Ref_Out_aula_73();

            // List_aula_77();

            //Matrizes_aula_79();

            //Inferencia_de_tipos_var_aula_85();

            //Switch_Case_aula_86();

            //Condicao_Ternaria_aula_87();

            //Funcoes_Interessantes_para_String_aula_88();

            // Datetime_aula_89();

            //TimeSpan_aula_90();

            //Datetime_Propriedades_aula_91();

            TimeSpan_propriedades_aula_92();


            Console.ReadLine();
        }

        private static void TimeSpan_propriedades_aula_92()
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 6, 11);
            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);

            Console.WriteLine("-----------------------");
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);


            var tick_t2 = t2.Ticks;
            TimeSpan mult = TimeSpan.FromTicks(tick_t2 * 2);
            Console.WriteLine(mult);
        }

        private static void Datetime_Propriedades_aula_91()
        {
            DateTime d = DateTime.Now;

            DateTime d2 = d.AddDays(30); //ex: como definir uma data de vencimento para  boleto

            Console.WriteLine(d);
            Console.WriteLine(d2);

            Console.WriteLine("--------------------------");
            //diferença entre datas
            TimeSpan t = d2.Subtract(d); //aqui calcula a diferença entre datas
            Console.WriteLine(t);

        }

        private static void TimeSpan_aula_90()
        {
            //tipos de contrutores do timeSpan
            //util para calcular multa e juros..etc;
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(1, 30, 59);
            TimeSpan t4 = new TimeSpan(10, 5, 30, 10);
            TimeSpan t5 = new TimeSpan(10, 5, 30, 10, 100);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine("--------------------");
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t7);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t8);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t9);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t10);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t11);

        }

        private static void Datetime_aula_89()
        {
            //utilizando sobrecarga, pasando ano, mes, dia
            DateTime d1 = new DateTime(2008, 11, 25);
            Console.WriteLine(d1);
            //utilizando sobrecarga, pasando ano, mes, dia, hora minuto, segundo
            DateTime d2 = new DateTime(2008, 11, 25, 10, 40, 11);
            Console.WriteLine(d2);
            //utilizando sobrecarga, pasando ano, mes, dia, hora minuto, segundo, milesegundo
            //obs: nao aparece na impressao os milesegundo por padrao teria que fazer outro procedimento
            DateTime d3 = new DateTime(2008, 11, 25, 10, 40, 11);
            Console.WriteLine(d3);

            Console.WriteLine(DateTime.Now); //local
            Console.WriteLine(DateTime.Today); //local
            Console.WriteLine(DateTime.UtcNow);  //hora mundial

            //utilizando conversao para datetime com o parse, muito util
            Console.WriteLine(DateTime.Parse("2020-11-10"));
            Console.WriteLine(DateTime.Parse("2020-11-10 13:05:58"));
            Console.WriteLine(DateTime.Parse("10/11/2020 13:05:58"));

            //podemos também determinar o formato da nossa data
            DateTime d4 = DateTime.ParseExact("2020-11-10", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.ParseExact("09/11/2020 11:31:01", "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d5);
        }

        private static void Funcoes_Interessantes_para_String_aula_88()
        {
            string original = "abcde FGHIJ ACB abc DEFG     ";
            //converte tudo para maiusculo
            string s1 = original.ToUpper();

            Console.WriteLine("ToUpper: " + s1 + "-");
            Console.WriteLine("----------------------");

            string s2 = original.ToLower();
            Console.WriteLine("ToLower: " + s2 + "-");
            Console.WriteLine("----------------------");

            string s3 = original.Trim();
            Console.WriteLine("Trim: " + s3 + "-");
            Console.WriteLine("----------------------");

            //devolve a posição que encontrou a string
            int n1 = original.IndexOf("bc");
            Console.WriteLine("IndexOf(bc): " + n1 );
            Console.WriteLine("----------------------");

            //devolve a posição que encontrou a string começando pelo final
            int n2 = original.LastIndexOf("bc");
            Console.WriteLine("LastIndexOf(bc): " + n2 );
            Console.WriteLine("----------------------");

            //replace, split sao outras funções importantes que podem ser usadas.
        }

        private static void Condicao_Ternaria_aula_87()
        {
            //estrutura opcional ao if-else
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;
            desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine($"Desconto R$ {desconto}");

        }

        private static void Switch_Case_aula_86()
        {
            int x = int.Parse(Console.ReadLine());
            string s = null;
            switch (x)
            {
                case 1:
                    s = "dom";
                    break;
                case 2:
                    s = "seg";
                    break;
                default:
                    break;
            }
            Console.WriteLine($"dia da semana: {s} ");
        }

        private static void Inferencia_de_tipos_var_aula_85()
        {
            //emboara muito util utilizar a palavra var, é bom ter cuidado porque pode gerar uma brecha no seu codigo
            //ja que o compilador irá aceitar qualquer tidpo de declaração.
            
            //tipo é inferido conforme iniciar a variavel
            //neste exemplo iniciamos com 10 e compilador entende como inteiro
            var x = 10;

            var y = 20.0; // aqui o compilador entende como double

            var s = "Maria"; // aqui o compilador entende como string;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(s);

        }

        private static void Matrizes_aula_79()
        {
            //como criar matriz e usar suas funções
            //neste exemplo estamos criando uma matriz de 2 linhas e 3 colunas
            double[,] mat = new double[2, 3];

            //propriedade length  - mostra quantos elementos tem no total
            Console.WriteLine(mat.Length);

            //mostra quantidade de linhas da matriz
            Console.WriteLine(mat.Rank);

            //mostra o tamanho da primeira dimensão (linha)
            Console.WriteLine(mat.GetLength(0));

            //mostra o tamanho da segunda dimensão (coluna)
            Console.WriteLine(mat.GetLength(1));
        }

        private static void List_aula_77()
        {
            //utilizando as funções de um list -utilizando os predicados (lambdas) e generics

            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            //a declaração abaixo cria uma referencia ao objeto list, com isso o que fizermos com list irá refletir em list3
            //pois os dois apontam para o mesmo endereço da memoria heap.
            List<string> list3 = list;

            //na declaração abaixo criamos um objeto na memoria apontando para uma nova referencia, com isso não perdemos
            //a informação de list4, quando alteramos list.
            List<string> list4 = new List<string>(list);

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------");
            //insert podemos definir a posição onde queremo inserir nosso registro
            list.Insert(2, "Marco");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------------------");

            //utilizando o count
            Console.WriteLine(list.Count);
            Console.WriteLine("----------------------------");

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            Console.WriteLine("----------------------------");
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            Console.WriteLine("----------------------------");
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos1);

            Console.WriteLine("----------------------------");
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos2);

             //fazer filtro na lista preciso criar uma nova lista
            Console.WriteLine("----------------------------");
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string obj in list2)
            {
                Console.WriteLine("Filtro itens com 5 caracteres: " + obj);

            }

            //removendo um item específico da lista
            Console.WriteLine("----------------------------");
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);

            }

            //removendo todos os  item da lista que começam com 'M'
            Console.WriteLine("----------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);

            }

            //removendo todos os  item da lista que começam com 'M'
            Console.WriteLine("----------------------------");
            list.RemoveAt(1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);

            }

            //removendo elementos de uma faixa ex: 
            //posição inicial, e a quantidade de elementos a serem removidos a partir daquela posição
            Console.WriteLine("----------------------------");
            list4.RemoveRange(1, 2);
            foreach (string obj in list4)
            {
                Console.WriteLine(obj);

            }




        }

        private static void Modificador_Ref_Out_aula_73()
        {
            //ATENÇÃO: este codigo é considerado CODE SMELLS (design ruim) devem ser evitados.
            // aqui estamos explorando os modificadores REF and OUT 
            //ref - conseguimos usar tipos structs como referencia ( aqui a variavel é obrigada ser iniciada)
            //out - recuperamos o resultado devolvido de um metodo. (aqui a variavel não precisa ser iniciada)
            int a = 10;
            int result;
            Calculadora.Triple(a, out result);
            Console.WriteLine(result);
            Console.ReadLine();

            Calculadora.Triple_Ref(ref a);
            Console.WriteLine(a);
            Console.ReadLine();
           
        }

        private static void Modificador_Parametros_params_aula_72()
        {
            //obs: veja como fica simples a chamada do metodo e dinamica com o uso do vetor e o modificador params
            Parametro_Params.Soma(10, 20);
            Parametro_Params.Soma(10, 20, 30, 40);
        }

        private static void Vetor_aula_70()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];
            for (int i = 0; i < n; i++)
            {
                Produto p = new Produto();
                p.Nome = Console.ReadLine();
                p.Preco = double.Parse(Console.ReadLine());
                vect[i] = p;
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Preco;
            }

            Console.WriteLine($"Media : {(sum / n).ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");

            Console.ReadLine();

        }
    }
}
