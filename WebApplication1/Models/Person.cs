namespace WebApplication1.Models
{
    public class Person
    {
        public int _age;
        public string QQ;

        public string Qq
        {
            get => QQ;
            set => QQ = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }
    }
}