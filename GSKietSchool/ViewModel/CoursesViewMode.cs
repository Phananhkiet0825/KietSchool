using GSKietSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSKietSchool.ViewModel
{
    public class CoursesViewMode
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

      public IEnumerable<Attendance> GetAttendances { get; set; }
        public IEnumerable<Following> GetFollowings { get; set; }

    }
}