namespace Graduation.Core
{
    public enum Gender
    {
        Unspecified = 0,
        Male = 1,
        Female = 2
    }

    public record Student
    {
        public int Id { get; set; }

        public Gender Gender { get; set; }

        public int DepartmentId { get; set; }
        
        public string Name { get; set; } // maybe move to localization table

        public string Surname { get; set; } // maybe move to localization table
        
        public string RegistrationId { get; set; }
        
        public string Email { get; set; }
        
        public string Mobile { get; set; }
        
        public string Phone { get; set; }
        
        public string PostalCode { get; set; }
        
        public string Address { get; set; }
        
        public string City { get; set; }
        
        public string Prefecture { get; set; }
        
        public int CountryId { get; set; }
        
        public Country Country { get; set; }
    }
}