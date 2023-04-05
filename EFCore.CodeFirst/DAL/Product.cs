using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.DAL
{

    //[Table("ProductTb",Schema ="products")]
    public class Product
    {
        //[Key]
        public int Id { get; set; }
        //[Column("name2", TypeName = "nvarchar(10)",Order =3)]
        public string Name { get; set; }
        //[Required]
        [Precision(18,2)]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateDate { get; set; }
        //[MaxLength(10)]
        //[StringLength(10,MinimumLength =5)]
        public string Barcode { get; set; }
        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}
