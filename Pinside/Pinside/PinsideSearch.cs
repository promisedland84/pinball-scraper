using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HAP = HtmlAgilityPack;
using HtmlAgilityPack;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Pinside
{
    public partial class PinsideSearch : Form
    {
        public BindingList<listResults> Results = new BindingList<listResults>();
        public List<PictureBox> Enablers = new List<PictureBox>();
        public List<gameURL> URLs = new List<gameURL>();

        public PinsideSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (radioForum.Checked == true) {dataGrabber();}
            if (radioMarket.Checked == true)
            {
                MessageBox.Show("Market Search is under construction", 
                    "My Apologies", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            dvGameResults.DataSource = Results;
        }

        public void dataGrabber()
        {
            //If a search has already been run, and the user decides to 'add' a game to the search without hitting the 
            //'Clear' button, and they only click on an additional game image to search, the datagridview would display 
            //the previously searched games in addition to the new search (which also contains the previously searched
            //games. The following 'if' statement clears the datagridview if it already has the Results list bound to it.
            if (dvGameResults.DataSource != null)
                Results.Clear();

            foreach (gameURL url in URLs)
            {
                using (var client = new System.Net.WebClient())
                {
                    var filename = System.IO.Path.GetTempFileName();
                        client.DownloadFile(url.URL, filename);

                    var doc = new HAP.HtmlDocument();
                        doc.Load(filename);

                    var root = doc.DocumentNode;

                    var titleNodes = root.SelectNodes("//*[@id=\"top\"]/div[3]/div[9]/div[2]/div/ul//li//h3//a");
                    var gameNodes = root.SelectNodes("//*[@id=\"top\"]/div[3]/div[1]/div[1]/div[3]/div[1]/h1");
                    //var a_nodes = root.Descendants("a").ToList();
                    //var titleNodes = root.SelectNodes("//*[@id=\"top\"]/div[3]/div[9]/div[2]/div/ul");
                    //var linkNodes = root.SelectNodes("//*[@id=\"top\"]/div[3]/div[9]/div[2]/div/ul//li//h3//a[@href]");
                    //var postNodes = root.SelectNodes("//*[@id=\"top\"]/div[3]/div[9]/div[2]/div/ul//li//div//a");
                    //var timeNodes = root.SelectNodes("//*[@id=\"top\"]/div[3]/div[9]/div[2]/div/ul/li[1]/div[1]/a[2]/text()");

                    foreach (HtmlNode title in titleNodes)
                    {
                        listResults results2 = new listResults();
                        foreach (HtmlNode game in gameNodes)
                        {
                                results2.Game = game.InnerText.Trim();
                                results2.Title = title.InnerText.Trim();
                                results2.Link = (("https://pinside.com") + (title.GetAttributeValue("href", ""))); 
                        }
                        Results.Add(results2);
                    }

                    //https://stackoverflow.com/questions/15003409/htmlagilitypack-and-selecting-nodes-and-subnodes?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
                }
            }
        }

//The following lines all add the selected game (on picturebox click) to the list of games to be searched (URLs)
//Then the selected game is removed if the game is clicked again (i.e. if you click on the green checkbox).
        private void picEATPM_Click(object sender, EventArgs e)
        {
            selectEATPM.Location = new Point(20, 0);
            picEATPM.Controls.Add(selectEATPM);
            selectEATPM.Enabled = true;
            selectEATPM.Visible = true;
            Enablers.Add((PictureBox)Controls.Find("selectEATPM", true)[0]);
            var addURL = new gameURL("https://pinside.com/pinball/archive/elvira-and-the-party-monsters");
            URLs.Add(addURL);
        }

        private void selectEATPM_Click(object sender, EventArgs e)
        {
            selectEATPM.Enabled = false;
            selectEATPM.Visible = false;
            Enablers.Remove((PictureBox)Controls.Find("selectEATPM", true)[0]);
            var toRemove = URLs.SingleOrDefault(r => r.URL == "https://pinside.com/pinball/archive/elvira-and-the-party-monsters");
            URLs.Remove(toRemove);
        }

        private void picTSPP_Click(object sender, EventArgs e)
        {
            picTSPP.Controls.Add(selectTSPP);
            selectTSPP.Location = new Point(20, 0);
            selectTSPP.Enabled = true;
            selectTSPP.Visible = true;
            Enablers.Add((PictureBox)Controls.Find("selectTSPP", true)[0]);
            var addURL = new gameURL("https://pinside.com/pinball/archive/simpsons-pinball-party");
            URLs.Add(addURL);
        }

        private void selectTSPP_Click(object sender, EventArgs e)
        {
            selectTSPP.Enabled = false;
            selectTSPP.Visible = false;
            Enablers.Remove((PictureBox)Controls.Find("selectTSPP", true)[0]);
            var toRemove = URLs.SingleOrDefault(r => r.URL == "https://pinside.com/pinball/archive/simpsons-pinball-party");
            URLs.Remove(toRemove);
        }

        private void picBW_Click(object sender, EventArgs e)
        {
            picBW.Controls.Add(selectBW);
            selectBW.Location = new Point(20, 0);
            selectBW.Enabled = true;
            selectBW.Visible = true;
            Enablers.Add((PictureBox)Controls.Find("selectBW", true)[0]);
            var addURL = new gameURL("https://pinside.com/pinball/archive/baywatch");
            URLs.Add(addURL);
        }

        private void selectBW_Click(object sender, EventArgs e)
        {
            selectBW.Enabled = false;
            selectBW.Visible = false;
            Enablers.Remove((PictureBox)Controls.Find("selectBW", true)[0]);
            var toRemove = URLs.SingleOrDefault(r => r.URL == "https://pinside.com/pinball/archive/baywatch");
            URLs.Remove(toRemove);
        }

        private void picRB_Click(object sender, EventArgs e)
        {
            picRB.Controls.Add(selectRB);
            selectRB.Location = new Point(20, 0);
            selectRB.Enabled = true;
            selectRB.Visible = true;
            Enablers.Add((PictureBox)Controls.Find("selectRB", true)[0]);
            var addURL = new gameURL("https://pinside.com/pinball/archive/adventures-of-rocky-and-bullwinkle-and-friends");
            URLs.Add(addURL);
        }

        private void selectRB_Click(object sender, EventArgs e)
        {
            selectRB.Enabled = false;
            selectRB.Visible = false;
            Enablers.Remove((PictureBox)Controls.Find("selectRB", true)[0]);
            var toRemove = URLs.SingleOrDefault(r => r.URL == "https://pinside.com/pinball/archive/adventures-of-rocky-and-bullwinkle-and-friends");
            URLs.Remove(toRemove);
        }

        private void picPB_Click(object sender, EventArgs e)
        {
            picPB.Controls.Add(selectPB);
            selectPB.Location = new Point(20, 0);
            selectPB.Enabled = true;
            selectPB.Visible = true;
            Enablers.Add((PictureBox)Controls.Find("selectPB", true)[0]);
            var addURL = new gameURL("https://pinside.com/pinball/archive/pinbot");
            URLs.Add(addURL);
        }

        private void selectPB_Click(object sender, EventArgs e)
        {
            selectPB.Enabled = false;
            selectPB.Visible = false;
            Enablers.Remove((PictureBox)Controls.Find("selectPB", true)[0]);
            var toRemove = URLs.SingleOrDefault(r => r.URL == "https://pinside.com/pinball/archive/pinbot");
            URLs.Remove(toRemove);
        }

        private void picSS_Click(object sender, EventArgs e)
        {
            picSS.Controls.Add(selectSS);
            selectSS.Location = new Point(20, 0);
            selectSS.Enabled = true;
            selectSS.Visible = true;
            Enablers.Add((PictureBox)Controls.Find("selectSS", true)[0]);
            var addURL = new gameURL("https://pinside.com/pinball/archive/secret-service");
            URLs.Add(addURL);
        }

        private void selectSS_Click(object sender, EventArgs e)
        {
            selectSS.Enabled = false;
            selectSS.Visible = false;
            Enablers.Remove((PictureBox)Controls.Find("selectSS", true)[0]);
            var toRemove = URLs.SingleOrDefault(r => r.URL == "https://pinside.com/pinball/archive/secret-service");
            URLs.Remove(toRemove);
        }

        private void picF14_Click(object sender, EventArgs e)
        {
            picF14.Controls.Add(selectF14);
            selectF14.Location = new Point(20, 0);
            selectF14.Enabled = true;
            selectF14.Visible = true;
            Enablers.Add((PictureBox)Controls.Find("selectF14", true)[0]);
            var addURL = new gameURL("https://pinside.com/pinball/archive/f-14-tomcat");
            URLs.Add(addURL);
        }

        private void selectF14_Click(object sender, EventArgs e)
        {
            selectF14.Enabled = false;
            selectF14.Visible = false;
            Enablers.Remove((PictureBox)Controls.Find("selectF14", true)[0]);
            var toRemove = URLs.SingleOrDefault(r => r.URL == "https://pinside.com/pinball/archive/f-14-tomcat");
            URLs.Remove(toRemove);
        }

        private void btnClear_Click(object sender, EventArgs e)
            //the Clear button needs to clear the Results list, set the datasource for dvGameResults to null,
            //hide/disable the enabler pictureboxes, clear the Enablers list, and clear the URLs list.
        {
            Results.Clear();
            dvGameResults.DataSource = null;

            foreach (PictureBox x in Enablers)
                //resets every green checkbox back to disabled and invisible
            {

                x.Visible = false;
                x.Enabled = false;
            }

            //Following lines remove all game URLs to be searched and 
            //removes all Green checkbox pictuerboxes from the Enablers list
            Wildcard removeURL = new Wildcard("https://pinside.com/pinball/archive/*");
            List<gameURL> urlsToRemove = new List<gameURL>();
            foreach (gameURL item in URLs)
            {

                if (removeURL.IsMatch(item.URL))
                    urlsToRemove.Add(item);
                    
            }
            foreach (var item in urlsToRemove)
            {
                URLs.Remove(item);
            }

            Wildcard removeEnabler = new Wildcard("select*");
            List<PictureBox> enablersToRemove = new List<PictureBox>();
            foreach (PictureBox item in Enablers)
            {
                if (removeEnabler.IsMatch(item.Name))
                    enablersToRemove.Add(item);
            }

            foreach (var item in enablersToRemove)
            {
                Enablers.Remove(item);
            }
        }

        private void dvGameResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
            //opens the clickable link in the third cell (index 2) column in the system's default browser
        {
            string sUrl = dvGameResults.Rows[e.RowIndex].
                Cells[2].Value.ToString(); 

            Process.Start(sUrl);                         
        }
    }

    public class Wildcard : Regex
    //the following lines create a Regex Wildcard converter for the purposes
    //of finding ALL urls/pictureboxes/etc. that start or end with 
    //specific characters. This method was obtained from:
    //https://www.codeproject.com/Articles/11556/Converting-Wildcards-to-Regexes
    {
        /// <summary>
        /// Initializes a wildcard with the given search pattern.
        /// </summary>
        /// <param name="pattern">The wildcard pattern to match.</param>
        public Wildcard(string pattern)
         : base(WildcardToRegex(pattern))
        {
        }

        /// <summary>
        /// Initializes a wildcard with the given search pattern and options.
        /// </summary>
        /// <param name="pattern">The wildcard pattern to match.</param>
        /// <param name="options">A combination of one or more
        /// <see cref="System.Text.RegexOptions"/>.</param>
        public Wildcard(string pattern, RegexOptions options)
         : base(WildcardToRegex(pattern), options)
        {
        }

        /// <summary>
        /// Converts a wildcard to a regex.
        /// </summary>
        /// <param name="pattern">The wildcard pattern to convert.</param>
        /// <returns>A regex equivalent of the given wildcard.</returns>
        public static string WildcardToRegex(string pattern)
        {
            return "^" + Regex.Escape(pattern).
             Replace("\\*", ".*").
             Replace("\\?", ".") + "$";
        }
    }
}
