using System;
using System.Xml.XPath;

namespace XPath
{
    class Program
    {
        static void Main(string[] args)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            String query;

            // Load the XML.
            docNav = new XPathDocument(@"C:\Users\Administrator\Source\Repos\XPathDemo\XPath\Flights.xml");

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            query = "/Flights/Flight/Origin[text()='LHR']";
            NodeIter = nav.Select(query);

            //Iterate through the results showing the element value.
            while (NodeIter.MoveNext())
            {
                Console.WriteLine(NodeIter.Current.OuterXml);
                // Console.WriteLine("Airline: {0}", NodeIter.Current.Value);
            };

            Console.ReadLine();
        }
    }
}
