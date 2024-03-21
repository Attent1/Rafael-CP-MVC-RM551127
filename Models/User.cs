using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Xml.Linq;

namespace Rafael_CP_MVC_RM551127.Models
{
    public class User
    {
        public User()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int GetId
        {
            get { return Id; }
            set { Id= value; }
        }

        public string GetName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string GetEmail
        {
            get { return Email; }
            set { Email = value; }
        }

        public string GetPassword
        {
            get { return Password; }
            set { Password = value; }
        }

    }
}
