using System;
namespace Jupiter
{
    interface IPagedList
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
        string SortExpression { get; set; }
        int TotalItemCount { get; set; }
        int TotalPageCount { get; }
        int CurrentTotal { get; }
        int CurrentOrder { get; }
    }
}
