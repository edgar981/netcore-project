using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BulkyWeb.Models
{
	public class Category
	{
		public int Id { get; set; }
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public required string Name { get; set; }
        [Range(1,100)]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}

