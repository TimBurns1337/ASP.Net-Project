using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }   
        [Required]        
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [RegularExpression("/^[A-Za-z]\\d[A-Za-z][ -]?\\d[A-Za-z]\\d$/")]
        public string PCode { get; set; }
        [CreditCard]
        public string CardNo { get; set; }
        [Required]
        public string CardExpDate { get; set; }
        [Required]
        public int CvcNo { get; set; }
        [Required]
        public string CardHolderName { get; set; }
    }
}
