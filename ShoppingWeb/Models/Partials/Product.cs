using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ShoppingWeb.Models
{
    [MetadataType(typeof(ProductMD))]
    public partial class Product
    {
        public class ProductMD
        {
            [ScaffoldColumn(false)]
            public int Id { get; set; }

            [Display(Name="Product Name")]
            [Required]
            [StringLength(50)]         
            public string Name { get; set; }
             [Display(Name = "Description")]
             [Required]
             [DataType(DataType.MultilineText)]
            public string Description { get; set; }
             [Display(Name = "Category")]
             [Required]
            public int CategoryId { get; set; }           
             [Display(Name = "Price")]
             [Required]
             [Range(0, 1000000, ErrorMessage = "{0} must be between {1} and {2} characters")]
             [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#######}")]
            public decimal Price { get; set; }
             [Display(Name = "Upload date")]
             [Required]
             [DataType(DataType.DateTime)]
             [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")] //日期格式化
            public System.DateTime PublishDate { get; set; }
             [Display(Name = "Status")]
             [Required]
            public bool Status { get; set; }
             [Display(Name = "Default photo number")]
             [Required]
            public Nullable<long> DefaultImageId { get; set; }
             [Display(Name = "Qty")]
             [Required]
             [Range(0, 10000, ErrorMessage = "{0} must be between {1} and {2} characters")]
            public int Quantity { get; set; }

            


        }
        public virtual Category Category { get; set; }


    }
}