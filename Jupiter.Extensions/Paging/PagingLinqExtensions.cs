using System;
using System.Linq;

namespace Jupiter
{
    public static class PageLinqExtensions
    {
        /// <summary>
        /// IQueryable 객체를 페이징 리스트로 변환
        /// </summary>
        /// <typeparam name="T">데이터 타입</typeparam>
        /// <param name="allItems">변환대상 컬렉션</param>
        /// <param name="pageIndex">페이지 번호</param>
        /// <param name="pageSize">페이지 사이즈</param>
        /// <returns></returns>
        public static PagedList<T> ToPagedList<T>
            (
                this IQueryable<T> allItems,
                int? pageIndex,
                int pageSize
            )
        {
            return ToPagedList<T>(allItems, pageIndex, pageSize, String.Empty);

        }

        /// <summary>
        /// IQueryable 객체를 페이징 리스트로 변환
        /// </summary>
        /// <typeparam name="T">데이터 타입</typeparam>
        /// <param name="allItems">변환대상 컬렉션</param>
        /// <param name="pageIndex">페이지 번호</param>
        /// <param name="sort">정렬식</param>
        /// <returns></returns>
        public static PagedList<T> ToPagedList<T>
            (
                this IQueryable<T> allItems,
                int? pageIndex,
                int pageSize,
                string sort
            )
        {
            var truePageIndex = pageIndex ?? 0;
            var itemIndex = truePageIndex * pageSize;
            var pageOfItems = allItems.Skip(itemIndex).Take(pageSize);
            var totalItemCount = allItems.Count();
            return new PagedList<T>(pageOfItems, truePageIndex, pageSize, totalItemCount, sort);
        }
    } 
}
