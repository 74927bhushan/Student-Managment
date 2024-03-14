namespace Student.Models
{
    public class Students
    {
       public int Id {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
