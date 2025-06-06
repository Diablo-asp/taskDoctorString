using System.ComponentModel.DataAnnotations.Schema;

namespace Doctor_String.Models
{
    public class DoctorForm
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateTime Date { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
