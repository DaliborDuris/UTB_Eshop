﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UTB.Eshop.Web.Models.Entity
{
    [Table(nameof(Complain))]
    public class Complain
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public string OrderNumber { get; set; }

        [StringLength(50)]
        [Required]
        public string Describe { get; set; }

        public string ComplaintStatus { get; set; }

    }
}



