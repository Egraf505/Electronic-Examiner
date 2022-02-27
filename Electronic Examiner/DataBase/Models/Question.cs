using System;
using System.Collections.Generic;

namespace Electronic_Examiner
{
    public partial class Question
    {
        public Question()
        {
            Asnwers = new HashSet<Asnwer>();
        }

        public int Id { get; set; }
        public int TestId { get; set; }
        public string Question1 { get; set; } = null!;

        public virtual Test Test { get; set; } = null!;
        public virtual ICollection<Asnwer> Asnwers { get; set; }
    }
}
