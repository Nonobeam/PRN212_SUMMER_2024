using Data.Entities;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TimeSlotService
    {
        private TimeslotRepository timeslotRepository;
        private static TimeSlotService instance;

        public TimeSlotService()
        {
            timeslotRepository = TimeslotRepository.GetInstance();
        }


        public static TimeSlotService GetInstance()
        {
            if (instance == null)
            {
                instance = new TimeSlotService();
            }
            return instance;
        }

        public TimeOnly GetTime(int id)
        {
            return timeslotRepository.GetTime(id);
        }

        public IEnumerable<TimeSlot> GetAllTimeSlots()
        {
            return timeslotRepository.GetSlots();
        }
    }
}
