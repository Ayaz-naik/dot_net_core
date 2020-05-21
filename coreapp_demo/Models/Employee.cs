using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace coreapp_demo.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long employeeId { get; set; }

        [Column("FirstName")]
        [StringLength(30)]
        public string firstName { get; set; }

        [Column("LastName")]
        [StringLength(30)]
        public string lastName { get; set; }

        [Column("Gender")]
        [StringLength(10)]
        public string gender { get; set; }

        [Column("Designation")]
        [StringLength(200)]
        public string designation { get; set; }

        [Column("Department")]
        [StringLength(100)]
        public string department { get; set; }
    }
}
