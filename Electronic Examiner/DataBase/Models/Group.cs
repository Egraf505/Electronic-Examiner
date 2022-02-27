using System;
using System.Collections.Generic;

namespace Electronic_Examiner
{
    public partial class Group
    {
        public Group()
        {
            Tests = new HashSet<Test>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Test> Tests { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
