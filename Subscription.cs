using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Projeto_IS_202324.Models
{
    public class Subscription
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime creation_dt { get; set; }
        public int parent { get; set; }
        public string @event { get; set; }
        public string endpoint { get; set; }
    }
}
