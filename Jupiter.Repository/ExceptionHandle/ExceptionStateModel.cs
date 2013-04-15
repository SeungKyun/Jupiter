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
    /// 예외 상태
    /// </summary>
    [Serializable]
    public class ExceptionStateModel
    {
        /// <summary>
        /// 예외 상태 키
        /// </summary>
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "예외 상태 키")]
        public Byte Id { get; set; }

        /// <summary>
        /// 문구
        /// </summary>
        [StringLength(8000, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "문구")]
        public string Name { get; set; }

        /// <summary>
        /// 설명
        /// </summary>
        [StringLength(8000, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "설명")]
        public string Description { get; set; }
    }
}
