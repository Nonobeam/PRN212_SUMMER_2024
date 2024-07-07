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
        private static TimeslotRepository instance;

        public TimeslotRepository(PrnProjectContext context)
        {
            prnProjectContext = context;
        }

        public TimeslotRepository()
        {
        }
        
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

        public TimeOnly GetTime(int id)
        {
            prnProjectContext = new();
            return (TimeOnly)prnProjectContext.TimeSlots.FirstOrDefault(t => t.Id == id).Time;
        }
    }
}
