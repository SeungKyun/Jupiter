using System;
using System.Collections.Generic;

namespace Jupiter
{
    /// <summary>
    /// 페이징 정보를 저장하는 데이터 클래스
    /// </summary>
    /// <typeparam name="T">데이터유형</typeparam>
    public class PagedList<T> : List<T>, IPagedList
    {
        private int _orderCursor;

        /// <summary>
        /// 페이징 정보를 저장하는 데이터 클래스
        /// </summary>
        /// <param name="items">대상 컬렉션</param>
        /// <param name="pageIndex">페이지 번호</param>
        /// <param name="pageSize">페이지 크기</param>
        /// <param name="totalItemCount">총 아이템 개수</param>
        /// <param name="sortExpression">정렬식</param>
        public PagedList(IEnumerable<T> items, int pageIndex, int pageSize, int totalItemCount, string sortExpression)
        {
            this.AddRange(items);
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.SortExpression = sortExpression;
            this.TotalItemCount = totalItemCount;
            this.TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)pageSize);
            this.CurrentTotal = this.TotalItemCount - (this.PageSize * this.PageIndex);
            _orderCursor = CurrentTotal +1;
        }
        /// <summary>
        /// 페이지 번호
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 페이지 크기
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 정렬식
        /// </summary>
        public string SortExpression { get; set; }
        /// <summary>
        /// 총 아이템 개수
        /// </summary>
        public int TotalItemCount { get; set; }
        /// <summary>
        /// 총 페이지 개수
        /// </summary>
        public int TotalPageCount { get; private set; }
        /// <summary>
        /// 현재 페이지의 총 개수
        /// </summary>
        public int CurrentTotal { get; private set; }
        /// <summary>
        /// 현재 페이지의 순서
        /// </summary>
        public int CurrentOrder
        {
            get { return --_orderCursor; }
        }
    }
}