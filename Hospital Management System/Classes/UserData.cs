using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Classes
{
    internal class UserData
    {
        // Basic Fields
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        // Audit Fields
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        // Computed Properties
        public bool IsModified => UpdatedAt > CreatedAt;
        public string RecordStatus => IsDeleted ? "Deleted" : "Active";

        // Constructor
        public UserData()
        {
            Role = "Admin";
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsDeleted = false;
        }
    }
}
