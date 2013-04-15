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

namespace Jupiter.Repository.ExceptionHandle
{
    /// <summary>
    /// 예외
    /// </summary>
    [Serializable]
    public class ExceptionModel
    {
        /// <summary>
        /// 예외 식별키
        /// </summary>
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "예외 식별키")]
        public Int64 Id { get; set; }

        /// <summary>
        /// 예외를 설명하는 메시지
        /// </summary>
        [StringLength(8000, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "예외를 설명하는 메시지")]
        public string Message { get; set; }

        /// <summary>
        /// 오류를 발생시키는 응용 프로그램 또는 개체의 이름
        /// </summary>
        [StringLength(8000, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "오류를 발생시키는 응용 프로그램 또는 개체의 이름")]
        public string Source { get; set; }

        /// <summary>
        /// 호출 스택의 직접 실행 프레임에 대한 문자열 표현
        /// </summary>
        [StringLength(16, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "호출 스택의 직접 실행 프레임에 대한 문자열 표현")]
        public string StackTrace { get; set; }

        /// <summary>
        /// 사용자아이디
        /// </summary>
        [StringLength(8000, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "사용자아이디")]
        public string UserName { get; set; }

        /// <summary>
        /// 요청URL
        /// </summary>
        [StringLength(8000, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "요청URL")]
        public string Url { get; set; }

        /// <summary>
        /// 이전URL
        /// </summary>
        [StringLength(8000, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "이전URL")]
        public string UrlReferrer { get; set; }

        /// <summary>
        /// 사용자PC 이름
        /// </summary>
        [StringLength(8000, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "사용자PC 이름")]
        public string UserHostName { get; set; }

        /// <summary>
        /// 사용자PC IP
        /// </summary>
        [StringLength(8000, ErrorMessage = "\"{0}\"필드는 {2}자 이상 {1}자 이하로 작성해 주십시오.", MinimumLength = 1)]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "사용자PC IP")]
        public string UserHostAddress { get; set; }

        /// <summary>
        /// 예외 발생일자
        /// </summary>
        [DisplayFormat(DataFormatString = "yyyy-MM-dd")]
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "예외 발생일자")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 예외 상태 키
        /// </summary>
        [Required(ErrorMessage = "필수 입력 값입니다.")]
        [Display(Name = "예외 상태 키")]
        public Byte Exceptions_StateId { get; set; }
    }
}
