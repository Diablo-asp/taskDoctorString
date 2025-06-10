using System.ComponentModel.DataAnnotations.Schema;

namespace Doctor_String.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string Name { get; set; } = null!;
        [Column(TypeName ="varchar(50)")]
        public string Specialization { get; set; } = string.Empty;
        public TimeOnly StartWork { get; set; }
        public TimeOnly EndWork { get; set; }
        public string? Img { get; set; }

        public ICollection<DoctorForm> DoctorForms { get; set; } = new List<DoctorForm>();
    }
}
