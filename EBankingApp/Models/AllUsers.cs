using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EBankingApp.Models
{
    public class AllUsers
    {
        [Key]
        public int Id { get; set; }



        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        public string Name { get; set; }



        [Required(ErrorMessage = "Required")]
        [RegularExpression("^[A-Z]{4}[0-9A-Z]{7}", ErrorMessage = "Please Enter Valid Account No")]
        public string AccountNo { get; set; }



        [StringLength(50)]
        public string BankName { get; set; }
        public double? Balance { get; set; }
    }
}
