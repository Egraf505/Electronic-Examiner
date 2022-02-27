using System;
using System.Collections.Generic;

namespace Electronic_Examiner
{
    public partial class User
    {
        public User()
        {
            Scores = new HashSet<Score>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string SecondName { get; set; } = null!;
        public string? MiddleName { get; set; }

        public virtual Group Group { get; set; } = null!;
        public virtual ICollection<Score> Scores { get; set; }
    }
}
