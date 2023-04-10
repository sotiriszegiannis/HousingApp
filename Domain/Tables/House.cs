using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("House")]
    public class House:ITable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [TableColumnAttr]
        public int Id { get; set; }
        [TableColumnAttr]
        public int AreaInSquareMeters { get; set; }
        [TableColumnAttr]
        public string FriendlyName { get; set; }
        [TableColumnAttr]
        public string Description { get; set; }        
        public List<User> Users { get; set; }
        public Address Address { get; set; }
        [TableColumnAttr]
        public ListingType ListingType { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        [TableColumnAttr]
        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}