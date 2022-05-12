using System;

namespace rpgAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight joao = new Knight("Joao", 23, 400, 40);
            WhiteWizard cida = new WhiteWizard("Cida", 23, 270, 95);
            BlackWizard inacio = new BlackWizard("Inacio", 26, 295, 105);
            Ninja cremilda = new Ninja("Cremilda", 25, 320, 60);

            Console.WriteLine(joao.Taunt());
            Console.WriteLine(cida.Attack());
            Console.WriteLine(joao.Attack());
            Console.WriteLine(cremilda.Attack());
            cremilda.setCMP(12);
            cremilda.setCHP(258);
            Console.WriteLine(cremilda.Steal());
            Console.WriteLine(cremilda.Steal());
            Console.WriteLine(inacio.Attack());
            Console.WriteLine(inacio.Attack(3));
            Console.WriteLine(inacio.Attack(20));
            Console.WriteLine(cida.Cure(cremilda));
            Console.WriteLine(cida.Cure(cremilda));
            Console.WriteLine(cida.Cure(cremilda));
        }
    }
}
