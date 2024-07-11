using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.CLinicOwner
{
    public class DentistDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? UserType { get; set; }
        public string? Email { get; set; }
        public string Status { get; set; }
        public string ClicnicName { get; set; }

    }
}
