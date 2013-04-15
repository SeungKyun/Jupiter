using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Jupiter.Repository.Account
{
    public class LogOnModel
    {
        [Required(ErrorMessage = "아이디를 입력해 주십시오.")]
        [Display(Name = "사용자 이름")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "비밀번호를 입력해 주십시오.")]
        [DataType(DataType.Password)]
        [Display(Name = "암호")]
        public string Password { get; set; }

        [Display(Name = "사용자 이름 및 암호 저장")]
        public bool RememberMe { get; set; }
    }
}
