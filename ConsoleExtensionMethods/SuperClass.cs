using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleExtensionMethods
{
    #region COMENTARIOS IMPORTANTES:
       /*classe estatica criada com o objetivo de ter aqui metodos e propriedades que podemos usar em todo sistema
         como exemplo: CultureInfo - podemos definir no inicio do sistema qual desejamos usar e depois o resto 
                                     do sistema vai utilizar a propriedade desta classe.

       */
    #endregion
    static class SuperClass
    {
        private static CultureInfo culturureInfoSis;
        public static CultureInfo CultureInfoSis 
        { 
            get => culturureInfoSis; 
            set => culturureInfoSis = value; 
        }
    }
}
