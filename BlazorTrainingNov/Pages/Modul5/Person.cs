using System.ComponentModel.DataAnnotations;

namespace BlazorTrainingNov.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="da muss was rein")]
        [StringLength(10,ErrorMessage ="max 10")]
        public string Name { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        public DateTime GebDat { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        [Range(140,190,ErrorMessage ="zwischne 140 und 190")]
        public int Gross { get; set; }

    }
}
