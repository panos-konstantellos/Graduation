namespace Graduation.Core
{
    public sealed record PostalCode
    {
        public string Code { get; set; }

        public string Area { get; set; }

        public string Prefecture { get; set; }
    }
}