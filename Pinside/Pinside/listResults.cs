using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinside
{
    public class listResults
    {

        public string Title { get; set; }
        public string Game { get; set; }
        //public string Time { get; set; }
        //public string Posts { get; set; }
        public string Link { get; set; }

        public listResults() { }

        //public listResults(string title, string game, string time,
        //    string posts, string link)
        public listResults(string title, string game,
            string link)
        {
            this.Title = title;
            this.Game = game;
            //this.Time = time;
            //this.Posts = posts;
            this.Link = link;
        }

    }
}
