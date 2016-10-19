using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLibrary
{
    public class Sale
    {
        [Required]
        [Display(Name = "Forhandlernavn")]
        public string DealerName { get; set; }

        [Display(Name = "Kundenavn")]
        public string CustomerName { get; set; }

        public CompactDisk Cd { get; set; }

        [Display(Name = "Pris")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
