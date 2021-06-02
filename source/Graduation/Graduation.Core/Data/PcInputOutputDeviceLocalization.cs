namespace Graduation.Core.Data
{
    public sealed record PcInputOutputDeviceLocalization
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }

        public int PcInputOutputDeviceId { get; set; }

        public PcInputOutputDevice PcInputOutputDevice { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}