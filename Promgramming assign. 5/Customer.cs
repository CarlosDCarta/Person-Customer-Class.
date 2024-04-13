using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promgramming_assign._5
{
    public class Customer : Person
    {
       public DateTime JoinDate { get; set; }

       public  Customer(DateTime joindate)
        :base()
        
        {
            JoinDate = joindate;
        }
         public virtual int GetJoinDate()
        {
            DateTime today = DateTime.Today;
            int years = today.Year - JoinDate.Year;
            return years;
        }
    }
}
