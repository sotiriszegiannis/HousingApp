using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Address")]
    public class Address : ITable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [TableColumnAttr]
        public int Id { get; set; }
        [TableColumnAttr]
        public string StreetName { get; set; }
        [TableColumnAttr]
        public string StreetNumber { get; set; }
        [TableColumnAttr]
        public string City { get; set; }
        [TableColumnAttr]
        public string Country { get; set; }
        [TableColumnAttr]
        public string ZipCode { get; set; }
    }
}