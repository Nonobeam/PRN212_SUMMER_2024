using Data.Entities;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ClinicService
    {
        private ClinicRepository clinicRepository;
        private static ClinicService instance;

        public ClinicService()
        {
            clinicRepository = ClinicRepository.GetInstance();
        }


        public static ClinicService GetInstance()
        {
            if (instance == null)
            {
                instance = new ClinicService();
            }
            return instance;
        }


        public IEnumerable<Clinic> GetAllClinics()
        {
            return clinicRepository.GetAllClinics();
        }


        public int ChangeClinicAvailable(int id, int available)
        {
            return clinicRepository.ChangeClinicAvailable(id, available);
        }


        public void AddClinic(Clinic clinic)
        {
            clinicRepository.AddClinic(clinic);
        }

        public Clinic GetClinicById(int clinicId)
        {
            return clinicRepository.GetClinicById(clinicId);
        }
    }
}
