namespace Graduation.Core
{
    public sealed record DepartmentLocalization
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public  int DepartmentId { get; set; }
        
        public Department Department { get; set; }

        public  int LanguageId { get; set; }

        public Language Language { get; set; }
    }
}