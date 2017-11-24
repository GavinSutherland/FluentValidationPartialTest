using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationPartialTest.Web.Models
{
    public class TestViewModel
    {
        [Display(Name="Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
    }
}
