using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "用户名不能为空")]
        [DisplayName("用户名")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="密码不能为空")]
        [DisplayName("密码")]
        public string Pwd { get; set; }
    }
}
