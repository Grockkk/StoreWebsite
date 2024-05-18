using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.Dtos
{
    public class UserToChangePasswordDto
    {
        public int Id { get; set; }

        public string Password { get; set; }
    }
}
