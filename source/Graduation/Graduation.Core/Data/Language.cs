namespace Graduation.Core
{
    public sealed record Language
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string Name { get; set; }
    }
}