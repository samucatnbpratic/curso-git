using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCurso_Nelio_Alves
{
    class Calculadora
    {
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
        public static void Triple_Ref(ref int origin)
        {
            origin = origin * 3;
        }
    }
}
