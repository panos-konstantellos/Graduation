using System.Collections.Generic;

namespace Graduation.Core.Data
{
    public sealed record PcInputOutputDevice
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string DefaultTitle { get; set; }
        
        public string DefaultDescription { get; set; }
        
        public ICollection<PcInputOutputDeviceLocalization> PcInputOutputDeviceLocalizations { get; set; }

        public PcInputOutputDevice()
        {
            this.PcInputOutputDeviceLocalizations = new List<PcInputOutputDeviceLocalization>();
        }
    }
}