using GSKietSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GSKietSchool.ViewModel
{
    public class CourseViewModel
    {
        public int id { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        [FurtureDate]
        public string Date { get; set; }
        [Required]
        [VaildTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            string D = Date;
            string S = Time;
            return DateTime.ParseExact(D, "dd/M/yyyy", CultureInfo.InvariantCulture);
        }
    }
}