using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlphaFarha.Entities.Models
{
    public class MRFItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("BOMRF")]
        public string MRFNo { get; set; } = string.Empty;

        [Required]
        public string ItemCode { get; set; } = string.Empty;

        public string? ItemDesc { get; set; }

        [Range(0, double.MaxValue)]
        public double ReqQtyInitial { get; set; }

        [Range(0, double.MaxValue)]
        public double ReqQty { get; set; }

        public string? Unit { get; set; }

        public string? Status { get; set; }

        public string? Remarks { get; set; }

        public DateTime ReqDate { get; set; } = DateTime.UtcNow;

        [Range(0, double.MaxValue)]
        public double QtyIssued { get; set; }

        // Additional properties
        public DateTime? IssuedOnStore { get; set; }
        public DateTime? ArrivedIssuedOnStore { get; set; }

        public string? LPO { get; set; }
        public DateTime? LPODate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public double Amount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public double VATAmount { get; set; }

        public string? Supplier { get; set; }

        public string? Comments { get; set; }

        // Relationships
        public MRF BOMRF { get; set; }
    }
}
