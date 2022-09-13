using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_homework_12._09._2022.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string MainTitle { get; set; }
        public string SubTitle { get; set; }
        public string HeaderTitle { get; set; }
        public string ImageUrl { get; set; }
        public string ReadMoreLink { get; set; }
        public string ShowNowLink { get; set; }
        public int Order { get; set; }
    }
}
