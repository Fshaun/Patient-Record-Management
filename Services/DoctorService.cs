using PatientRecordManagement.Models;
using PatientRecordManagement.Repositories;

namespace PatientRecordManagement.Services
{
    public class DoctorService(IDoctorRepository _repository) : IDoctorService
    {

        public async Task AddDoctorAsync(Doctor doctor)
        {
            await _repository.AddDoctorAsync(doctor);
        }

        public async Task DeleteDoctorAsync(string doctorId)
        {
            await _repository.DeleteDoctorAsync(doctorId);
        }

        public async Task<IEnumerable<Doctor>> GetAllDoctorsAsync()
        {
            return await _repository.GetAllDoctorsAsync();
        }

        public async Task UpdateDoctorAsync(Doctor doctor)
        {
            await _repository.UpdateDoctorAsync(doctor);
        }
    }
}
