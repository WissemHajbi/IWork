using System.ComponentModel.DataAnnotations.Schema;

namespace IWork.Models {
    public class EmployerModel {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Field { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string CoverImage { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
    }
}