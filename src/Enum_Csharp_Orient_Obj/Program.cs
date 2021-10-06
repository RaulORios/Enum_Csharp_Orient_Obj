using Enum_Csharp_Orient_Obj.Entities;
using Enum_Csharp_Orient_Obj.Entities.Enums;
using System;


namespace Enum_Csharp_Orient_Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();                       

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt); //Enum para string

            Console.WriteLine(os); //String para Enum

            Console.ReadKey();

        }
    }
}
