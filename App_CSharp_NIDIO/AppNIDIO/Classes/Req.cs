using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNIDIO.Classes
{
    public class Req
    {
        private int id;
        private User user;
        private Select service;
        private DateTime date;
        private string descricao;
        private List<ReqEv> events;

        public int Id { get; set; }
        public User User { get; set; }
        public Select Service;
        public DateTime Date { get; set; }
        public string Descricao { get; set; }
        public List<ReqEv> Events { get; set; }
    }
}
