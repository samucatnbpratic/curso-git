using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleParte2.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        shipped = 2,
        Delivered = 3
    }
}
