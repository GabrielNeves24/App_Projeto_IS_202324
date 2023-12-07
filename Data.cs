using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Projeto_IS_202324.Models
{
    public class Data
    {
        public int id { get; set; }
        public string content { get; set; }
        public DateTime creation_dt { get; set; }
        public int parent { get; set; }
    }
}
