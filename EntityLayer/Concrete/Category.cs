using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        /// <summary>
        /// Heading Sınıfı ile ilişkili olması için aşağıdak
        /// kısmı yazdık
        /// </summary>
        public ICollection<Heading> Headings { get; set; }
    }
}
