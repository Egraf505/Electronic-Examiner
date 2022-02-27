using System;
using System.Collections.Generic;

namespace Electronic_Examiner
{
    public partial class Score
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public int UserId { get; set; }

        public virtual Test Test { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
