using Microsoft.AspNetCore.Mvc;
using MVCWebApplication.Controllers;
using MVCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MVCWebApplication.Controllers
{
    public class MoviesController : Controller
    {
        protected string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlFundamentals"].ConnectionString;
        public IActionResult Index()
        {
           
           IEnumerable<MoviesModel> movies = GetAllMovies();
            return View(movies);
        }

        private IEnumerable<MoviesModel> GetAllMovies()
        {
            List<MoviesModel> moviesList = new();
            string sqlQuery = "SELECT * FROM MOVIES ORDER BY MOVIEID DESC";

            using(SqlConnection sqlConnection = new SqlConnection(sqlConnectionString))
            {
                using(SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    using(SqlDataAdapter adapter = new(sqlCommand))
                    {
                        using(DataTable dataTable = new())
                        {
                            MoviesModel moviesModel;
                            adapter.Fill(dataTable);


                            foreach(DataRow dataRow in dataTable.Rows)
                            {
                                moviesModel = new()
                                {
                                    MovieID = Convert.ToInt32(dataRow["MOVIEID"]),
                                    MovieTitle = dataRow["MOVIETITLE"].ToString(),
                                    MyRating = Convert.ToInt32(dataRow["MYRATING"]),
                                    Director = dataRow["DIRECTOR"].ToString(),
                                    LeadActor = dataRow["LEADACTOR"].ToString(),
                                    Year = Convert.ToInt32(dataRow["YEAR"])
                                };
                                moviesList.Add(moviesModel);


                            }

                        }
                       
                    }
                }
            }
            return moviesList;
           
          
        }
       
    }
}
