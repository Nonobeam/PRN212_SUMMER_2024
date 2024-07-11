using Data.Entities;
using Data.Repository;


namespace Service
{
    public class DentistService
    {
        private DentistRepository dentistRepository;
        private static DentistService instance;

        public DentistService()
        {
            dentistRepository = DentistRepository.GetInstance();
        }


        public static DentistService GetInstance()
        {
            if (instance == null)
            {
                instance = new DentistService();
            }
            return instance;
        }

        public IEnumerable<Dentist> GetAllDentists()
        {
            return dentistRepository.GetAllDentists();
        }

        public IEnumerable<Dentist> GetAllDentistsByClinic(int clinicId)
        {
            return dentistRepository.GetAllDentistsByClinic(clinicId);
        }

        public void AddDentist(Dentist dentist)
        {
            dentistRepository.save(dentist);
        }

        public void UpdateDentist(Dentist dentist)
        {
            dentistRepository.update(dentist);
        }

    }
}
