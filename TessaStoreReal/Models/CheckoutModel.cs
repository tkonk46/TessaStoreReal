using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TessaStoreReal.Models
{
    public class CheckoutModel
    {   //TODO: add remaining fields to model and bind to view
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
        [Required]
        [CreditCard]
        [Display(Name = "Credit Card Number")]
        public string CreditCardNumber { get; set; }
        [Required]
        [RegularExpression("/^[0-9]{3,4}$/", ErrorMessage ="Your CVV is invalid.")]
        [Display(Name = "CVV")]
        public string CreditCardVerificationValue { get; set; }
        [Required]
        [Display(Name = "Name On Card")]
        public string CreditCardName { get; set; }
        [Required]
        [Range(1,12)]
        [Display(Name = "Month")]
        public int CreditCardExpirationMonth { get; set; }
        [Required]
        [Range(2000,3000)]
        [Display(Name = "Year")]
        public int CreditCardExpirationYear { get; set; }

    }
}