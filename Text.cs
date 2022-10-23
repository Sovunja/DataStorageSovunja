using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorageSovunja
{
    public class Text {
        public System.DateTime Date { get; set; }
        public Text()
        {
            Date = DateTime.Now;
        }
        public virtual string Add()
        {
            return($"[{Date}]");
        }
    }
}
