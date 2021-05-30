using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManagerAPI.Models
{
    public class Systems
    {
        [Key]
        public int Id { get; set; }
        public string SystemName { get; set; }

        //public Roles roles { get; set; }
    }
}
