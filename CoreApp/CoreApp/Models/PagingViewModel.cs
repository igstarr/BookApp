using Biz.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class PagingViewModel
    {
        public SortFilterPageOptions SortFilterPageData { get; set; }
        public int TotalCount { get; set; }

        public int GetShowingNumberFirst()
        {
            if (SortFilterPageData.PageNum == 1)
                return 1;
            return ((SortFilterPageData.PageNum - 1) * SortFilterPageData.PageSize) + 1;
        }
        public int GetShowingNumberLast()
        {
            int size = SortFilterPageData.PageNum * SortFilterPageData.PageSize;

            return size > TotalCount ? TotalCount : size;
        }
    }
}
