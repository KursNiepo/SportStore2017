using System;

namespace SportStore_2017.Models {
    public class PagingInfo {
        public int Totalitems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages {
            get { return (int) Math.Ceiling((decimal) Totalitems / ItemsPerPage); }
        }
    }
}