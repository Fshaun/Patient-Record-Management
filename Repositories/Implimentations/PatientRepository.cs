using Microsoft.EntityFrameworkCore;
using PatientRecordManagement.Models;

namespace PatientRecordManagement.Repositories.Implimentations
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext _context;
        public PatientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddPatientAsync(Patient patient)
        {
            await _context.AddAsync(patient);
            Commit();
        }

        public async Task DeletePatientAsync(string id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                Commit();
            }
        }

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<Patient> GetPatientByIdAsync(string id)
        {
            return await _context.Patients.FindAsync(id);
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            _context.Patients.Update(patient);
            Commit();
        }

        private async void Commit() => await _context.SaveChangesAsync();
    }

}
