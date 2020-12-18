using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerApi.Data.Enitities
{    
    public class Customer
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<Address> CustomerAddress { get; set; }
                    = new List<Address>();
    }
}


public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public string Skill { get; set; }
    public string Email { get; set; }

    public ICollection<Address> EmployeeAddress { get; set; }
                = new List<Address>();
}