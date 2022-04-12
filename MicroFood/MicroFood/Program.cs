using System;
using MicroFood.Entidades;

namespace MicroFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido ped = new Pedido();

            double total = 0.00;

            Console.WriteLine("Informe os dados do prato / bebida: ");

            Console.Write("Preço: R$");
            ped.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            ped.Qunatidade = int.Parse(Console.ReadLine());

            total = total + ped.Preco * ped.Qunatidade;
            Console.WriteLine();
            Console.Write("Deseja adicionar mais um prato / bebida? 1- SIM / 2- NÃO: ");
            int resp = int.Parse(Console.ReadLine());

            while (resp == 1)
            {
                Console.WriteLine("Informe os dados do prato / bebida: ");

                Console.Write("Preço: R$");
                ped.Preco = double.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                ped.Qunatidade = int.Parse(Console.ReadLine());
                total = total + ped.Preco * ped.Qunatidade;
                Console.WriteLine();
                Console.Write("Deseja adicionar mais um prato / bebida? 1- SIM / 2- NÃO: ");
                resp = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            Console.Write("Esse pedido será entregue em domicílio? 1- SIM / 2- NÃO: ");
            int resp2 = int.Parse(Console.ReadLine());
          
            if (resp2 == 1)
            {
                Console.Write("Informe a taxa de entrega: R$");
                ped.Entrega = double.Parse(Console.ReadLine());
            }

            total = total + ped.Entrega;
            Console.WriteLine("Valor total do pedido: R$" + total.ToString("F2"));

        }
    }
}
