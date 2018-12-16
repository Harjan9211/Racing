using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Models
{
   public class Joe:Punter
    {
        // Initialize the Joe class
        public Joe()
        {
            ClassName = "Joe";
            Money = 40;
            Type = CommonClass.Punter_Type.Joe;
        }
        //Reset the money and initialize to original value
        public override void Reset()
        {
            Money = 40;
        }
        //Retrive the money in hand
        public int GetMoney()
        {
            return Money;
        }
    }
}
