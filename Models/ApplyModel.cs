using System.ComponentModel.DataAnnotations.Schema;

namespace IWork.Models {
    public class ApplyModel {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Prename { get; set; }
        public string Email { get; set; }
        public string Experience { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
    }
}