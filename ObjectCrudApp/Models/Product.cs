// Models/Product.cs
using System.ComponentModel.DataAnnotations;
namespace ObjectCrudApp.Models
{
    public class Product
    {
        public int Id { get; set;}
        public string Name { get; set;} = string.Empty;

    }
}