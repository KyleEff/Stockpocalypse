using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.Interfaces
{
    /*
     * This interface had more of a use, but it got scaled back as less was needed.
     * SetCash should typically sets the cash display for the user.
     * WriteCash should typically write to a file.
     */
    public interface ICashManagement
    {
        void SetCash();
        void WriteCash();
    }
}
