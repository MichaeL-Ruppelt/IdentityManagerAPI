using IdentityManagerAPI.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManagerAPI.Models
{
    public class Roles
    {
        //[Table("Roles")
        [Key]
        public int Id { get; set; }
        public int Role { get; set; }
        public int UserID { get; set; }
        //public virtual Users listaUsers { get; set; }
        //public List<Users> listaUsers { get; set; }
        public int SystemID { get; set; }
        //public virtual Systems listaSystemas { get; set; }
        //public List<Systems> listaSystemas{ get; set; }

    }
}
