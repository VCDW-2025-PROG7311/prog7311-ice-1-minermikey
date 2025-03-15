using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Interface
{
    public interface IOrderRepository
    {
            void SaveOrder(Order order);

    }
}