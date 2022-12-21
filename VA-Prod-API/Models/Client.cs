using System.ComponentModel.DataAnnotations;

namespace VA_Prod_API.Models
{
    public class Client
    {

        #region Fields

        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        #endregion


        #region Constructor
        public Client(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        #endregion
    }
}
