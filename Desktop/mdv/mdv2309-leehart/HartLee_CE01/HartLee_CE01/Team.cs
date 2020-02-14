using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added to help with transfer
using System.Windows.Forms;

using System.Xml;

namespace HartLee_CE01
{
    class Team 
    {//Creating Team Class to hold teams information

        //Teams Name
        string name = "";

        //Teams Location
        string location = "";

        //Team Division
        int division = -1;
        string[] divisions = { "North", "South", "East", "West" };
        
            
        //Team conference
        bool conference;

        //allows the instance to be instantiated with out conditions basically blank TEAM
        public Team() { }

        // Makes Current Team a ListViewItem
        public ListViewItem AsListViewItem()
        {
            
            ListViewItem team = new ListViewItem();
            team.Name = ToString();
            team.Tag = this;

            return team;
        }
        public Team(object x) { Team newteam = x as Team; name = newteam.Name; location = newteam.Location; division = newteam.Division; conference = newteam.Conference; }
        public Team(XmlNode t)
        {

            foreach(XmlNode n in t)
            {
                if(n.NamespaceURI == "Conference")
                {
                    if (n.Name == "AFC")
                    { conference = true; }
                    else { conference = false; }
                }

                if (n.NamespaceURI == "Division")
                {
                    int div = -1;
                    int i = 0;
                   foreach(string s in divisions)
                    {

                        if(s == n.Name) { div = i; }
                        i++;
                    }
                    division = div;
                }

                if (n.NamespaceURI == "Location")
                {
                    Location = n.Name;
                }

                if (n.NamespaceURI == "Name")
                {
                    Name = n.Name;

                }


            }


        }
        //Changes or Retrieves Name
        public string Name { get{ return name; }set{ name = value; } }

        //retrieves or changes location
        public string Location { get { return location; } set { location = value; } }

        //retrieves or changes Division
        public int Division{ get { return division; } set { division = value; } }

        //retrieves or changes Conference
        public bool Conference { get { return conference; } set {conference = value; } }
        public string ConferenceString
        {
            get
            {
                string con;
                if(conference == true) { con = "AFC"; }
                else { con = "NFC"; }

                return con;
            }
        }
        public override string ToString()
        {
            return Location + " " + Name;
        }
        public string ToPrint()
        {
            string print = $"Location  : {Location}\r\n" +
                           $"Team      : {Name}\r\n" +
                           $"Division  : {divisions[Division]}\r\n" +
                           $"Conference: {ConferenceString}\r\n\r\n\r\n";



                return print;
        }
        public XmlNode Node()
        {
            
            XmlDocument doc = new XmlDocument();
            
            
            XmlNode node = doc.CreateNode(XmlNodeType.Element, $"{Location}{Name}","Team");
            
            XmlNode nodename = doc.CreateNode(XmlNodeType.Element, $"{Name}", "Name");

            XmlNode locname = doc.CreateNode(XmlNodeType.Element, $"{Location}", "Location");

            XmlNode divNode = doc.CreateNode(XmlNodeType.Element, $"{divisions[division]}", "Division");

            XmlNode connode = doc.CreateNode(XmlNodeType.Element, $"{ConferenceString}", "Conference");
            XmlElement root = doc.DocumentElement;
            node.AppendChild(nodename);
            node.AppendChild(locname);
            node.AppendChild(divNode);
            node.AppendChild(connode);

            

            
            return node;
        }

    }
}
