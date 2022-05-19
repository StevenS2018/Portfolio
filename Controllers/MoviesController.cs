using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Generic;
using ExerciseWebApp.Models;
using System;
using ExerciseWebApp.Controllers;
using System.Data;


namespace ExerciseWebApp.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
          IEnumerable<MoviesModel> movies = GetAllMovies();
          return View();
        }

        public IEnumerable<MoviesModel> GetAllMovies()
        {
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlFun"].ConnectionString;
            List<MoviesModel> moviesList = new();
            string querySql = "Select * FROM MOVIES ORDER BY MOVIEID DESC";

            using(SqlConnection sqlConnection = new SqlConnection(sqlConnectionString))
            {
                using(SqlCommand sqlCommand = new SqlCommand(querySql, sqlConnection))
                {
                    using(SqlDataAdapter adapter = new(sqlCommand))
                    {
                        using (DataTable dataTable = new())
                        {
                            adapter.Fill(dataTable);

                            MoviesModel moviesModel;
                            foreach(DataRow dataRow in dataTable.Rows)
                            {
                                moviesModel = new()
                                {
                                    MovieID = Convert.ToInt32(dataRow["MOVIEID"]),
                                    MovieTitle = dataRow["MOVIETITLE"].ToString(),
                                    Year = Convert.ToInt32(dataRow["YEAR"]),
                                    LeadActor = dataRow["LEADACTOR"].ToString(),
                                    Director = dataRow["DIRECTOR"].ToString(),
                                    MyRating = Convert.ToInt32(dataRow["MYRATING"]),


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
