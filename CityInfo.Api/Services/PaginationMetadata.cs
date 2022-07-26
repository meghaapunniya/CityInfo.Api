namespace CityInfo.Api.Services
{
    public class PaginationMetadata
    {
        public int PageItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public PaginationMetadata(int totalItemCount, int pageSize,int cuurentPage)
        {
            totalItemCount = totalItemCount;
            pageSize = pageSize;
            cuurentPage = cuurentPage;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)pageSize);
        }


    }
}
