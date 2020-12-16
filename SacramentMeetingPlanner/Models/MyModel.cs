using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class MyModel
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string artist { get; set; }
        public string book { get; set; }
        public string bookFilter { get; set; }
        public string collectionFilter { get; set; }
        public string url { get; set; }
        public string alturl { get; set; }
        public string mp3 { get; set; }
        public string playerlink { get; set; }
        public string pdf { get; set; }
        public string video1 { get; set; }
        public string video2 { get; set; }
        public bool showAsterisk { get; set; }
        public bool hasDownload { get; set; }
        public string midi { get; set; }
        public string songid { get; set; }
        public string songNumber { get; set; }
        public string detailColumn { get; set; }
    }
}
