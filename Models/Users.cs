using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManagerAPI.Models
{
    public class Users
    {   
        [Key]
        public int UserId { get; set; }

        public string EmployeeID { get; set; }

        public string DisplayName { get; set; }

        public string AccountName { get; set; }

        public char EmployeeStatus { get; set; }

        public DateTime EmployeeStartDate { get; set; }

        public DateTime? EmployeeEndDate { get; set; }

        public int ManagerID { get; set; }

        public string Company { get; set; }

        public string Department { get; set; }

        public string JobTitle { get; set; }

    }
}
