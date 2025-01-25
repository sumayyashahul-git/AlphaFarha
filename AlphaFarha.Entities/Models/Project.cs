using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaFarha.Core.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        [Required]
       [MaxLength()]
        public string Code { get; set; } = "0";
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Active { get; set; } = "Y";
    }
}
