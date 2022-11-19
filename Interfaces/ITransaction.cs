using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.Interfaces
{
    /*
     * This interface is used on the buy and sell forms to set the totals of the orders
     *  and to transact (i.e. buying and selling).
     */
    interface ITransaction
    {
        void SetTotal();
        void Transact();
    }
}
