using System.Data.SqlClient;


namespace MVCWebApplication.Models
{
    public class ContactsModel
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;


        public ContactsModel()
        {

        }

    }
}
