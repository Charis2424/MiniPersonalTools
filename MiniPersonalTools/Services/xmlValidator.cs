using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MiniPersonalTools.Services
{
    public class xmlValidator
    {
        public xmlValidator(string[] xmlStringArray)
        {

            // Input XML string
            //string xmlString = "";
            //string xmlString = "<p>At 21/2/2021 7:43:53 μμ, liz.gallivan@tiscali.co.uk wrote : Script [U.K. accent]: Have you got any idea how much printer paper’s left?</p><p>At 24/5/2021 4:56:58 μμ, David.Rogan@peoplecert.org wrote : Do you know how much paper there is in the printer? [Female, UK]</p>";

            var idx = 1;
            foreach (string xmlString in xmlStringArray)
            {
                // Validate the XML against an XML Schema
                bool isValid = ValidateXmlSyntax(xmlString,idx);

                if (isValid)
                {
                    Console.WriteLine("\r\n");
                    Console.WriteLine(idx);
                    Console.WriteLine("The XML is valid.");
                }
                else
                {
                    Console.WriteLine("The XML is not valid.");
                }
                idx++;
            }
            Console.ReadLine();


        }
        private bool ValidateXmlSyntax(string xmlString,int idx)
        {
            try
            {
                // Load the XML string into an XmlDocument without validation
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.XmlResolver = null; // Disable external entity resolution
                xmlDoc.LoadXml(xmlString);
                return true; // XML syntax is valid
            }
            catch (XmlException ex)
            {
                Console.WriteLine("\r\n");
                Console.WriteLine($"{idx} \r\nXML Syntax Error: {ex.Message}");
                return false; // XML syntax is not valid
            }
        }
    }
}
