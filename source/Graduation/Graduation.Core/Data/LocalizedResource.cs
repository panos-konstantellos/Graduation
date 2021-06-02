using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation.Core
{
    public sealed record LocalizedResource
    {
        public int Id { get; set; }
        
        public int LanguageId { get; set; }
        
        public Language Language { get; set; }
        
        public string Key { get; set; }
        
        public string Value { get; set; }
    }
}