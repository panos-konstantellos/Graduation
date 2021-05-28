using System.Collections.Generic;

namespace Graduation.Core
{
    public sealed record Department
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public ICollection<DepartmentLocalization> DepartmentLocalizations { get; set; }

        public Department()
        {
            this.DepartmentLocalizations = new List<DepartmentLocalization>();
        }
    }
}