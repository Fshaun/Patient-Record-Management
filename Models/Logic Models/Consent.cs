namespace PatientRecordManagement.Models.Logic_Models
{
    public class Consent
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int GrantedToUserId { get; set; }
        public DateTime ConsentDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }

}
