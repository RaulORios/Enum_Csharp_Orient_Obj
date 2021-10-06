using System;
using Enum_Csharp_Orient_Obj.Entities.Enums;

namespace Enum_Csharp_Orient_Obj.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return ($"{Id}, {Moment}, {Status}");
        }

    }
}
