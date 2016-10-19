using System.ComponentModel.DataAnnotations;

namespace CollectionsLibrary
{
    public interface ICustomer
    {
        [Display(Name = "Kundenr")]
        double CustomerNo { get; set; }

        [Display(Name = "Firmanavn")]
        string CompanyName { get; set; }

        [Display(Name = "Adresse")]
        string Address { get; set; }

        [Display(Name = "Poststed")]
        string City { get; set; }

        [Display(Name = "Kontakt")]
        string Contact { get; set; }

        [Display(Name = "Telefon")]
        string Phone { get; set; }

        [Display(Name = "Postnr")]
        string Zipcode { get; set; }
    }
}