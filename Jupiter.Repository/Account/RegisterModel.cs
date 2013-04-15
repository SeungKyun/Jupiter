using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Jupiter.Repository.Account
{
    public class RegisterModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0}은(는) {2}자 이상이어야 합니다.", MinimumLength = 4)]
        [Display(Name = "아이디")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0}은(는) {2}자 이상이어야 합니다.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "암호")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "암호 확인")]
        [Compare("Password", ErrorMessage = "암호와 확인 암호가 일치하지 않습니다.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "분반아이디")]
        public byte? ClassId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "{0}은(는) {2}자 이상이어야 합니다.", MinimumLength = 1)]
        [Display(Name = "이름")]
        public string RealName { get; set; }

        [Display(Name = "성별")]
        [StringLength(1)]
        public string Gender { get; set; }

        [Display(Name = "전화")]
        [StringLength(16)]
        public string HomePhone { get; set; }

        [StringLength(16)]
        [Display(Name = "핸드폰")]
        public string MobilePIN { get; set; }

        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "전자 메일 주소")]
        public string Email { get; set; }

        [StringLength(7)]
        [Display(Name = "우편번호")]
        public string Post { get; set; }

        [StringLength(200)]
        [Display(Name = "주소")]
        public string Address { get; set; }

        [StringLength(50)]
        [Display(Name = "학교명")]
        public string SchoolName { get; set; }

        [StringLength(1)]
        [Display(Name = "학년")]
        public string SchoolGrade { get; set; }

        [StringLength(500)]
        [Display(Name = "비고")]
        public string Comment { get; set; }

        [StringLength(30)]
        [Display(Name = "교회명")]
        public string ChurchName { get; set; }

        [StringLength(30)]
        [Display(Name = "교회직분")]
        public string ChurchRole { get; set; }

        [Display(Name = "회원가입일자")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "관리자 여부")]
        public bool IsAdmin { get; set; }
    }
}
