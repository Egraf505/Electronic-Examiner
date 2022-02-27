using System;
using System.Collections.Generic;

namespace Electronic_Examiner
{
    public partial class Asnwer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Description { get; set; } = null!;
        public bool TrueFalse { get; set; }

        public virtual Question Question { get; set; } = null!;
    }
}
