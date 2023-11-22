using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileExercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            Console.Write("Digite a senha correta: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida");
                Console.Write("Digite a senha novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!");

        }
    }
}
