using System;
using System.Collections.Generic;

namespace ConsoleDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "991919191";
            cookies["phone"] = "991919190"; //observação valor da chave anterior sera substituida pelo novo valor

            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no email key");
            }

            //testando o tamanho do nosso dictionary
            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES: ");

            //aqui podemos definir o tipo de par chave e valor queremos
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //ou simplesmente usar a tipo var
            foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
