using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class TimeslotRepository : ITimeslotService
    {
        private PrnProjectContext prnProjectContext;

        public TimeslotRepository(PrnProjectContext context)
        {
            prnProjectContext = context;
        }
        public TimeslotRepository()
        {
        }
        private static TimeslotRepository instance;
        public static TimeslotRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new TimeslotRepository();
            }
            return instance;
        }

        public IEnumerable<TimeSlot> GetSlots()
        {
            prnProjectContext = new();
            return prnProjectContext.TimeSlots.ToList();
        }


    }
}
