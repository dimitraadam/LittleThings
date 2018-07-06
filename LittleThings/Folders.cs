/*
Function FolderNames accepts a string containing an XML file that specifies folder structure and returns all folder names that start with startingLetter. 
The XML format is given in the example below.

For example, for the letter 'u' and XML file:

<?xml version="1.0" encoding="UTF-8"?>
<folder name="c">
    <folder name="program files">
        <folder name="uninstall information" />
    </folder>
    <folder name="users" />
</folder>

the function should return "uninstall information" and "users" (in any order).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LittleThings
{
    class Folders
    {

        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {

            XDocument doc = XDocument.Parse(xml);

            var q = from element in doc.Descendants("folder")
                    where element.Attribute("name").Value.StartsWith(startingLetter.ToString())
                    select (string)element.Attribute("name").Value;

            return q;

        }

    }
}
