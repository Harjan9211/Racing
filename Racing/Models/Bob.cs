using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Models
{
   public class Bob:Punter
    {
        //Initialize the Bob class paramater
        public Bob()
        {
            ClassName = "Bob";
            Money = 45;
            Type = CommonClass.Punter_Type.Bob;
        }
        //Reset the money to initial value
        public override void Reset()
        {
            Money = 45;
        }
        //Retrieve money in hand
        public int GetMoney()
        {
            return Money;
        }
    }
}
