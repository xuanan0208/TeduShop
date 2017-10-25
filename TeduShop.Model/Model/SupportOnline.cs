﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("SupportOnlines")]
   public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Department { get; set; }

        [MaxLength(50)]
        public string Skype { set; get; }

        [MaxLength(50)]
        public string Mobile { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Yahoo { get; set; }

        [MaxLength(50)] 
        public string Facebook { get; set; }

        [MaxLength(50)]
        public bool Status { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
