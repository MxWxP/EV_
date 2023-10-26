using System.ComponentModel.DataAnnotations;

namespace EV.Models
{
    public class Ivent
    {
        [Key]
        public int Id { get; set; }
        [Required] // валидация  - обязательное заполнение
        //[Range] ToDo проверка корректности ввода по усмотрению 
        // если да то сделать в отображении валидацию и в контроллере
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Тема")]
        public string Topic { get; set; }

        [Required]
        [Display(Name = "Подтема")]
        public string Subtopic { get; set; }

        [Required]
        [Display(Name = "Описание")]
        public string Details { get; set; }

        [Required]
        [Display(Name = "Дата")]
        // TODO сделать > Today datae
        public string DataIvent { get; set; }
        [Required]
        [Display(Name = "Время")]
        // TODO сделать > At that time 
        public string TimeIvent { get; set; }

    }
}
