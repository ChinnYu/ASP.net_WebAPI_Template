using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Person1
    {
        public int Id;
        public string Name;

        [Required(ErrorMessage = "編號不能為空")]
        [Range(10,100,ErrorMessage = "必須是10~100")]
        public int Id1
        {
            get => Id;
            set => Id = value;
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }
    }
}