// Models/Product.cs
using System.ComponentModel.DataAnnotations;
namespace ObjectCrudApp.Models
{
    public class Product
    {
        public int Id { get; set;}

        [Display(Name="NepaliNaam")]
        public string Name { get; set;} = string.Empty;

        [Display(Name="Price(Rs.)")]
        public int Price {get;set;} = 0;
    }
}