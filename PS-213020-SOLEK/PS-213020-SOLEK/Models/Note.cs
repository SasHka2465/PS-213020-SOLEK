using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS_213020_SOLEK.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
