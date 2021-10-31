using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{

 
    public class Purchase
    {
        public Purchase()
        {
        }

        public Purchase(int purchaseId, string fname, string lname, string email, string phone, string address, string pCode, string cardNo, string cardExpDate, int cvcNo, string cardHolderName)
        {
            PurchaseId = purchaseId;
            Fname = fname;
            Lname = lname;
            Email = email;
            Phone = phone;
            Address = address;
            PCode = pCode;
            CardNo = cardNo;
            CardExpDate = cardExpDate;
            CvcNo = cvcNo;
            CardHolderName = cardHolderName;
        }

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
