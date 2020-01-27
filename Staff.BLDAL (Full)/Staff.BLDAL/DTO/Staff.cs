using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff.BLDAL.DTO
{
    public class Staff
    {
        [Key]
        public int? StaffID { get; set; }


        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Position")]
        public string Position { get; set; }


        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Hired Date")]

        public string HiredDate { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Salary")]
        public string Salary { get; set; }
        //public string EditSupplier
        //{
        //    get
        //    {
        //        string url = "~/Suppliers/Update.aspx?supplierID=" + StaffID.ToString();
        //        return url;

        //    }

        //}
    }
}
