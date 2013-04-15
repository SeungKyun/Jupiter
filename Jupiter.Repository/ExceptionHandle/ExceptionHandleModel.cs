/****************************************************************************************
 * Copyright(c) Seungkyun,Park/박승균 (qkrtmdrbs@gmail.com)
 * 본 소스는 저작자의 개인소유자산입니다.
 * 본 소스를 원저작자의 허락없이 무단으로 변형,판매,가공시에는 저작권법에 위반됩니다.
 ****************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Jupiter.Repository.ExceptionHandle
{
    /// <summary>
    /// 예외 처리
    /// </summary>
    [Serializable]
    public class ExceptionHandleModel
    {
        /// <summary>
        /// 예외 처리 식별키
        /// </summary>
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "예외 처리 식별키")]
        public Int64 Id { get; set; }

        /// <summary>
        /// 예외 식별키
        /// </summary>
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "예외 식별키")]
        public Int64 ExceptionId { get; set; }

        /// <summary>
        /// 처리한 사용자아이디
        /// </summary>
        [StringLength(8000, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "처리한 사용자아이디")]
        public string UserName { get; set; }

        /// <summary>
        /// 처리 소견
        /// </summary>
        [StringLength(8000, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "처리 소견")]
        public string Comment { get; set; }

        /// <summary>
        /// 처리 일자
        /// </summary>
        [DisplayFormat(DataFormatString = "yyyy-MM-dd")]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "처리 일자")]
        public DateTime CreateDate { get; set; }
    }
}
