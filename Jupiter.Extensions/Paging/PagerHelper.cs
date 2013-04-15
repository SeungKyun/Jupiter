using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;
using System.Web.Mvc;

namespace Jupiter
{
    /// <summary>
    /// 화면에 페이징 처리를 출력
    /// </summary>
    public static class PagerHelper
    {
        /// <summary>
        /// 주어진 PagedList 객체를 기준으로 페이징 링크를 자동 출력
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="pageOfList"></param>
        /// <returns></returns>
        public static IList<PagerItem> PagerList<T>(this HtmlHelper helper, PagedList<T> pageOfList)
        {
            return PagerList<T>(helper, pageOfList.TotalPageCount, pageOfList.PageIndex, pageOfList.SortExpression, null, null, null, null);
        }

        /// <summary>
        /// 주어진 PagedList 객체를 기준으로 페이징 링크를 자동 출력
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="pageOfList"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IList<PagerItem> PagerList<T>(this HtmlHelper helper, PagedList<T> pageOfList, object values)
        {
            return PagerList<T>(helper, pageOfList.TotalPageCount, pageOfList.PageIndex, pageOfList.SortExpression, null, null, null, values);
        }

        /// <summary>
        /// 주어진 PagedList 객체를 기준으로 페이징 링크를 자동 출력
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="pageOfList"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IList<PagerItem> PagerList<T>(this HtmlHelper helper, PagedList<T> pageOfList, PagerOptions options)
        {
            return PagerList<T>(helper, pageOfList.TotalPageCount, pageOfList.PageIndex, pageOfList.SortExpression, null, null, options, null);
        }

        /// <summary>
        /// 주어진 PagedList 객체를 기준으로 페이징 링크를 자동 출력
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="pageOfList"></param>
        /// <param name="options"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IList<PagerItem> PagerList<T>(this HtmlHelper helper, PagedList<T> pageOfList, PagerOptions options, object values)
        {
            return PagerList<T>(helper, pageOfList.TotalPageCount, pageOfList.PageIndex, pageOfList.SortExpression, null, null, options, values);
        }

        /// <summary>
        /// 주어진 PagedList 객체를 기준으로 페이징 링크를 자동 출력
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="totalPageCount"></param>
        /// <param name="pageIndex"></param>
        /// <param name="sortExp"></param>
        /// <param name="actionName"></param>
        /// <param name="controllerName"></param>
        /// <param name="options"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IList<PagerItem> PagerList<T>(this HtmlHelper helper, int totalPageCount, int pageIndex, string sortExp, string actionName, string controllerName, PagerOptions options, object values)
        {
            var builder = new PagerBuilder
                (
                    helper,
                    actionName,
                    controllerName,
                    totalPageCount,
                    pageIndex,
                    sortExp,
                    options,
                    values
                );
            return builder.ToList();
        }

        /// <summary>
        /// 주어진 PagedList 객체를 기준으로 페이징 링크를 자동 출력
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="pageOfList"></param>
        /// <returns></returns>
        public static MvcHtmlString Pager<T>(this HtmlHelper helper, PagedList<T> pageOfList)
        {
            return Pager(helper, pageOfList.TotalPageCount, pageOfList.PageIndex, pageOfList.SortExpression, null, null, null, null);
        }

        /// <summary>
        /// 주어진 PagedList 객체를 기준으로 페이징 링크를 자동 출력
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="pageOfList"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static MvcHtmlString Pager<T>(this HtmlHelper helper, PagedList<T> pageOfList, object values)
        {
            return Pager(helper, pageOfList.TotalPageCount, pageOfList.PageIndex, pageOfList.SortExpression, null, null, null, values);
        }

        /// <summary>
        /// 주어진 PagedList 객체를 기준으로 페이징 링크를 자동 출력
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="pageOfList"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static MvcHtmlString Pager<T>(this HtmlHelper helper, PagedList<T> pageOfList, PagerOptions options)
        {
            return Pager(helper, pageOfList.TotalPageCount, pageOfList.PageIndex, pageOfList.SortExpression, null, null, options, null);
        }

        /// <summary>
        /// 주어진 PagedList 객체를 기준으로 페이징 링크를 자동 출력
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="pageOfList"></param>
        /// <param name="options"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static MvcHtmlString Pager<T>(this HtmlHelper helper, PagedList<T> pageOfList, PagerOptions options, object values)
        {
            return Pager(helper, pageOfList.TotalPageCount, pageOfList.PageIndex, pageOfList.SortExpression, null, null, options, values);
        }

        /// <summary>
        /// 주어진 PagedList 객체를 기준으로 페이징 링크를 자동 출력
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="totalPageCount"></param>
        /// <param name="pageIndex"></param>
        /// <param name="sortExp"></param>
        /// <param name="actionName"></param>
        /// <param name="controllerName"></param>
        /// <param name="options"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static MvcHtmlString Pager(this HtmlHelper helper, int totalPageCount, int pageIndex, string sortExp, string actionName, string controllerName, PagerOptions options, object values)
        {
            var builder = new PagerBuilder
                (
                    helper,
                    actionName,
                    controllerName,
                    totalPageCount,
                    pageIndex,
                    sortExp,
                    options,
                    values
                );
            return new MvcHtmlString(builder.RenderList());

        }
    }

    internal class PagerBuilder
    {
        private HtmlHelper _helper;
        private string _actionName;
        private string _controllerName;
        private int _totalPageCount;
        private int _pageIndex;
        private string _sortExp;
        private PagerOptions _options;
        private object _values;

        private int _startPageIndex;
        private int _endPageIndex;


        internal PagerBuilder(HtmlHelper helper, string actionName, string controllerName, int totalPageCount, int pageIndex, string sortExp, PagerOptions options, object values)
        {
            // Set defaults
            if (String.IsNullOrEmpty(actionName))
                actionName = (string)helper.ViewContext.RouteData.Values["action"];
            if (String.IsNullOrEmpty(controllerName))
                controllerName = (string)helper.ViewContext.RouteData.Values["controller"];
            if (options == null)
                options = new PagerOptions();

            // Assign to fields
            _helper = helper;
            _actionName = actionName;
            _controllerName = controllerName;
            _totalPageCount = totalPageCount;
            _pageIndex = pageIndex;
            _options = options;
            _values = values;
            _sortExp = sortExp;

            // Calculate start page index
            _startPageIndex = pageIndex - (options.MaximumPageNumbers / 2);
            if (_startPageIndex + options.MaximumPageNumbers > _totalPageCount)
                _startPageIndex = _totalPageCount - options.MaximumPageNumbers;
            if (_startPageIndex < 0)
                _startPageIndex = 0;

            // Calculate end page index
            _endPageIndex = _startPageIndex + _options.MaximumPageNumbers;
            if (_endPageIndex > _totalPageCount)
                _endPageIndex = _totalPageCount;

        }


        internal IList<PagerItem> ToList()
        {
            var results = new List<PagerItem>();

            // Add First link
            if (_options.ShowFirst)
                AddFirst(results);

            // Add previous link
            if (_options.ShowPrevious)
                AddPrevious(results);

            if (_options.ShowNumbers)
            {
                // Add range ellipsis
                //AddPreRange(results);

                // Add page numbers
                AddPageNumbers(results);

                // Add range ellipsis
                //AddPostRange(results);
            }

            // Add next link
            if (_options.ShowNext)
                AddNext(results);

            // Add last link
            if (_options.ShowLast)
                AddLast(results);

            return results;
        }

        private void AddFirst(List<PagerItem> results)
        {
            if (this._pageIndex != 0)
            {
                string firstText = this._options.FirstText;
                string url = this.GenerateUrl(0);
                PagerItem item = new PagerItem(firstText, url, false);
                results.Add(item);
            }
        }

        private void AddLast(List<PagerItem> results)
        {
            if ((this._pageIndex != (this._totalPageCount - 1)) && (this._pageIndex < (this._totalPageCount - 1)))
            {
                string lastText = this._options.LastText;
                string url = this.GenerateUrl(this._totalPageCount - 1);
                PagerItem item = new PagerItem(lastText, url, false);
                results.Add(item);
            }
        }

        private void AddPrevious(List<PagerItem> results)
        {
            if (this._pageIndex > 0)
            {
                string previousText = this._options.PreviousText;
                string url = this.GenerateUrl(this._pageIndex - 1);
                PagerItem item = new PagerItem(previousText, url, false);
                results.Add(item);
            }
        }


        private void AddPreRange(List<PagerItem> results)
        {
            if (_startPageIndex > 0)
            {
                var text = "...";
                var index = _startPageIndex - _options.MaximumPageNumbers;
                if (index < 0) index = 0;
                var url = GenerateUrl(index);
                var item = new PagerItem(text, url, false);
                results.Add(item);
            }
        }

        private void AddPageNumbers(List<PagerItem> results)
        {
            for (var pageIndex = _startPageIndex; pageIndex < _endPageIndex; pageIndex++)
            {
                var text = (pageIndex + 1).ToString();
                var url = GenerateUrl(pageIndex);
                var isSelected = pageIndex == _pageIndex;
                if (isSelected)
                    text = String.Format(_options.SelectedPageNumberFormatString, text);
                else
                    text = String.Format(_options.PageNumberFormatString, text);
                var item = new PagerItem(text, url, isSelected);
                results.Add(item);
            }
        }

        private void AddPostRange(List<PagerItem> results)
        {
            if (_endPageIndex < _totalPageCount)
            {
                var text = "...";
                var index = _startPageIndex + _options.MaximumPageNumbers;
                if (index > _totalPageCount) index = _totalPageCount;
                var url = GenerateUrl(index);
                var item = new PagerItem(text, url, false);
                results.Add(item);
            }
        }

        private void AddNext(List<PagerItem> results)
        {
            if (this._pageIndex < (this._totalPageCount - 1))
            {
                string nextText = this._options.NextText;
                string url = this.GenerateUrl(this._pageIndex + 1);
                PagerItem item = new PagerItem(nextText, url, false);
                results.Add(item);
            }
        }

        private string GenerateUrl(int pageIndex)
        {
            RouteValueDictionary routeValues;
            if (_values is RouteValueDictionary)
            {
                routeValues = (RouteValueDictionary)_values;
            }
            else
            {
                routeValues = new RouteValueDictionary(_values);
            }

            // Add page index
            routeValues[_options.IndexParameterName] = pageIndex;

            // Add sort index
            if (_sortExp != null) routeValues[_options.SortParameterName] = _sortExp;

            // Add action
            routeValues["action"] = _actionName;

            // Add controller
            routeValues["controller"] = _controllerName;

            // Return link
            var urlHelper = new UrlHelper(_helper.ViewContext.RequestContext);
            return urlHelper.RouteUrl(routeValues);
        }


        internal string RenderList()
        {
            var results = this.ToList();
            var sb = new StringBuilder();

            foreach (PagerItem item in results)
            {
                if (item.IsSelected)
                    sb.AppendFormat("<strong>{0}</strong>&nbsp;", item.Text);
                else
                    sb.AppendFormat("{0}&nbsp;", GenerateLink(item));
            }

            return sb.ToString();
        }

        private string GenerateLink(PagerItem item)
        {
            return String.Format("<a href='{0}'>[{1}]</a>", item.Url, _helper.Encode(item.Text));
        }
    }

    public class PagerItem
    {
        public PagerItem(string text, string url, bool isSelected)
        {
            this.Text = text;
            this.Url = url;
            this.IsSelected = isSelected;
        }

        public string Text { get; set; }
        public string Url { get; set; }
        public bool IsSelected { get; set; }
    }

    public class PagerOptions
    {
        public PagerOptions()
        {
            this.IndexParameterName = "page";
            this.SortParameterName = "sort";
            this.MaximumPageNumbers = 10;
            this.PageNumberFormatString = "{0}";
            this.SelectedPageNumberFormatString = "{0}";
            this.ShowPrevious = true;
            this.PreviousText = "이전";
            this.ShowNext = true;
            this.NextText = "다음";
            this.ShowFirst = true;
            this.FirstText = "처음";
            this.ShowLast = true;
            this.LastText = "마지막";
            this.ShowNumbers = true;
        }

        public string IndexParameterName { get; set; }
        public string SortParameterName { get; set; }
        public string PageNumberFormatString { get; set; }
        public string SelectedPageNumberFormatString { get; set; }
        public object LinkAttributes { get; set; }
        public int MaximumPageNumbers { get; set; }
        public bool ShowPrevious { get; set; }
        public string PreviousText { get; set; }
        public bool ShowNext { get; set; }
        public string NextText { get; set; }
        public bool ShowFirst { get; set; }
        public string FirstText { get; set; }
        public bool ShowLast { get; set; }
        public string LastText { get; set; }
        public bool ShowNumbers { get; set; }

    }
}
