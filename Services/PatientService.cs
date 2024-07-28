using PatientRecordManagement.Models;

namespace PatientRecordManagement.Services
{
    
    public class PatientService : IPatientService
    {
        private readonly IPatientService _patientService;
        public PatientService(IPatientService service)
        {
            _patientService = service;
        }

        public async Task AddPatientAsync(Patient patient)
        {
            await _patientService.AddPatientAsync(patient); 
        }

        public async Task DeletePatientAsync(string id)
        {
            await _patientService.DeletePatientAsync(id);
        }

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
        {
            return await _patientService.GetAllPatientsAsync();
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            await _patientService.UpdatePatientAsync(patient);
        }
    }
}
