using RLevel2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLevel1
{
    public class Level1
    {
        public string GetValue(bool returnHere)
        {
            if (!returnHere)
            {
                return new Level2().GetValue();
            }
            else
            {
                return null;
            }
        }
    }
}
