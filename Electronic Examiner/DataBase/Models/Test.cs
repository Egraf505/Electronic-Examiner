using System;
using System.Collections.Generic;

namespace Electronic_Examiner
{
    public partial class Test
    {
        public Test()
        {
            Questions = new HashSet<Question>();
            Scores = new HashSet<Score>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; } = null!;

        public virtual Group Group { get; set; } = null!;
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
