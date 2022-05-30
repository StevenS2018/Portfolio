using System.Data.SqlClient;

namespace MVCWebApplication.Models
{
    public class MoviesModel
    {


        public int MovieID { get; set; }
        public string MovieTitle { get; set; } = string.Empty;
        public int Year { get; set; }

        public string Director { get; set; } = string.Empty;

        public string LeadActor { set; get; } = string.Empty;

        public int MyRating { get; set; }



    }
}



