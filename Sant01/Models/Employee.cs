using Sant01.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sant01.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [StringLength(32, ErrorMessage = "{0} lenght must be between {2} and {1}", MinimumLength = 1)]
        public string Name { get; set; }

        [StringLength(32, ErrorMessage = "{0} lenght must be between {2} and {1}", MinimumLength = 1)]
        public string Surename { get; set; }

        [Display(Name = "Person Identification Code")]
        [RegularExpression(@"[3-6][0-9]{2}[0,1][0-9][0-9]{2}[0-9]{4}", ErrorMessage = "Characters are not allowed.")]
        public long PersonIdentificationCode { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [StringLength(100, ErrorMessage = "{0} lenght must be between {2} and {1}", MinimumLength = 1)]
        public string Address { get; set; }

        public EmployeeStatus Status { get; set; }
    }
}