using System;
using System.ComponentModel.DataAnnotations;

namespace AlphaFarha.Entities.Models
{
  
    public class MRF
    {
       
        [Key]
        public string Id { get; set; } = "0";
        public string MRFNo { get; set; } ="";

        [Required]
        [StringLength(50)]
        public string Type { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string ProjCode { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string EmpCode { get; set; } = string.Empty;

        [Required]
        public DateTime GeneratedOn { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime MRFDate { get; set; } = DateTime.UtcNow;

        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        public string DeliverTo { get; set; } = string.Empty;

        public string DeliveryLoc { get; set; } = string.Empty;

        public DateTime? ClosedOn { get; set; }

        public string GeneratedFrom { get; set; } = string.Empty;

        // Navigation Property for related BOMRFItems
        public ICollection<MRFItem> Items { get; set; } = new List<MRFItem>();
    }

  

}
