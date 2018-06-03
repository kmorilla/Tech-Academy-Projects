using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarAndConstructors
{
    public class Income
    {
        public Income(int grossIncome) : this(grossIncome, 0)
        {
        }
        public Income(int grossIncome, int taxes)
        {
            NetIncome = grossIncome - taxes;
        }

        public int NetIncome { get; set; }
    }
}
