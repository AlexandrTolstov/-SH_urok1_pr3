using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSH_urok1_pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(char.IsControl('\t'));
            Console.WriteLine(char.IsDigit('5'));
            Console.WriteLine(char.IsLetter('x'));
            Console.WriteLine(char.IsLower('m'));
            Console.WriteLine(char.IsUpper('P')); //True
                                                  //определяет является ли символ числом
            Console.WriteLine(char.IsNumber('2')); //True
                                                   //определяет является ли символ
                                                   //разделителем
            Console.WriteLine(char.IsSeparator('.')); //False
                                                      //определяет является ли символ
                                                      //специальным символом
            Console.WriteLine(char.IsSymbol('<')); //True
                                                   //определяет является ли символ пробелом
            Console.WriteLine(char.IsWhiteSpace(' ')); //True
                                                       //переводит символ в нижний регистр
            Console.WriteLine(char.ToLower('T')); //t
                                                  //переводит символ в верхний регистр
            Console.WriteLine(char.ToUpper('t'));
        }
    }
}
