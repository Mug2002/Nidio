using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNIDIO.Classes
{
    public class Select
    {
        private int id;
        private string desc;

        public Select(int id, string desc)
        {
            this.id = id;
            this.desc = desc;
        }

        public int Id { get; set; }
        public string Desc { get; set; }
    }
}
