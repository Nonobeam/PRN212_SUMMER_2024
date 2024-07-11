using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.CLinicOwner
{
    internal class AppoinmentDto
    {
        public int Id { get; set; }

        public DateTime? Date { get; set; }

        public int? TimeSlotId { get; set; }

        public String? CustomerName { get; set; }

        public String? DentistName { get; set; }

        public String? ServiceName { get; set; }

        public String? ClinicName { get; set; }

        public String Status { get; set; }
    }
}
