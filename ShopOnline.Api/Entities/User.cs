using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Api.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_name")]
        public string? UserName { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("password")]
        public string? Password { get; set; }

        [Column("autentykacja")]
        public bool Autentykacja { get; set; }

        [Column("adres_miasto")]
        public string? Miasto { get; set; }
        [Column("adres_ulica")]
        public string? Ulica { get; set; }

        [Column("adres_dom")]
        public string? NumerDomu { get; set; }


    }
}
