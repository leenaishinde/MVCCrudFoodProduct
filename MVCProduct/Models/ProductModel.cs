using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProduct.Models
{
    public class ProductModel
    {
        [Display(Name = "Id")]

        public int Prdid { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Category Name is required.")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Product_Description is required.")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Additional Info is required.")]
        public string AdditionalInfo { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public int Price { get; set; }
    }
}