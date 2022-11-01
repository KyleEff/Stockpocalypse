using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.Interfaces
{
    interface ITransaction
    {
        void SetTotal();
        void Transact();
    }
}
