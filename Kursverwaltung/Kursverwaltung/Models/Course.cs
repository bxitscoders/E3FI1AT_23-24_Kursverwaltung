using System;

namespace Kursverwaltung.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxUsers { get; set; }
        public int CurrentUsers { get; set; }
        public DateTime StartDateTime { get; set; }
        public int Duration { get; set; }
        public DateTime RegistrDeadline { get; set; }
        public int AdminId { get; set; }

        public string TeilnehmerInfo
        {
            get { return $"{CurrentUsers}/{MaxUsers}"; }
        }
    }
}
