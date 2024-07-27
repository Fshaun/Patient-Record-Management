namespace PatientRecordManagement.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public int Content { get; set; }
        public DateTime SentDate { get; set; }
    }

}
