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
    public class ContactsControllercs : Controller
    {
        protected string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlFundamentals"].ConnectionString;
        public IActionResult Index()
        {
            IEnumerable<ContactsModel> contacts = GetAllContacts();
            return View(contacts);
        }

        public IEnumerable<ContactsModel> GetAllContacts()
        {
            List<ContactsModel> contactsList = new();

            string querySql = "SELECT * FROM CONTACTS ORDER BY CONTACTID DESC";

            using(SqlConnection sqlConnection = new SqlConnection(sqlConnectionString))
            {
                using(SqlCommand sqlCommand = new SqlCommand(querySql, sqlConnection))
                {
                    using(SqlDataAdapter adapter = new(sqlCommand))
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
                                contactsList.Add(contactsModel);
                            }
                        }
                    }
                }
            }
            return contactsList;
        }
    }
}
