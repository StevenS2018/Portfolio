using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

    public class ContactsController : Controller
    {

        public IActionResult Index()
        {
            IEnumerable<ContactsModel> contacts = GetAllContacts();
            return View(contacts);
        }
  
        public IEnumerable<ContactsModel> GetAllContacts()
        {
          string sqlConnectionString = ConfigurationManager.ConnectionStrings["SQLFundamentals"].ConnectionString;

            List<ContactsModel> contactList = new();

            string querySql = "SELECT * FROM CONTACTS ORDER BY CONTACTID DESC";

            using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(querySql, sqlConnection))
                {
                    using (SqlDataAdapter adapter = new(sqlCommand))
                    {
                        using (DataTable dataTable = new())
                        {
                            adapter.Fill(dataTable);

                            ContactsModel contactsModel;
                            foreach(DataRow dataRow in dataTable.Rows)
                            {
                                contactsModel = new()
                                {
                                    ContactID = Convert.ToInt32(dataRow["CONTACTID"]),
                                    FirstName = dataRow["FIRSTNAME"].ToString(),
                                    LastName = dataRow["LASTNAME"].ToString(),
                                    PhoneNumber = dataRow["PHONENUMBER"].ToString(),
                                    EmailAddress = dataRow["EMAILADDRESS"].ToString()

                                };
                                contactList.Add(contactsModel);
                            }
                           

                        }

                    }


        
                }
            }

            return contactList;
        }
    }




                
}
