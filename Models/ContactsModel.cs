using System.Data.SqlClient;


namespace ExerciseWebApp.Models
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
