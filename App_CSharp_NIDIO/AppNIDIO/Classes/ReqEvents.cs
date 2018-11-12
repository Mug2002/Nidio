using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNIDIO.Classes
{
    public class ReqEv
    {
        private int id;
        private User user;
        private Select status;
        private DateTime date;
        private string acao;

        public int Id { get; set; }
        public User User { get; set; }
        public Select Status { get; set; }
        public DateTime Date { get; set; }
        public string Acao { get; set; }
    }
}
