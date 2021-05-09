using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestMandatory2Task1
{
    public static class XMLParser
    {
        public static string DepotStorageParser(XmlDocument doc)
        {
            string text = "";

            if (doc.DocumentElement != null)
            {
                text += doc.DocumentElement.Name + ":\n  ";
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    text += NodeRunner(text, node);
                }
            }
            return text;
        }


        /// <summary>
        /// Run through every XML.Element node in an xml doc, writes the name of each.
        /// Writes the text found inside elements with no element children of their own.
        /// </summary>
        /// <param name="s">The string</param>
        /// <param name="node">The first node, assumed to be an XML.Element</param>
        /// <returns>string</returns>
        private static string NodeRunner(string s, XmlNode node)
        {
            // Writes the name of the current node, this ensures every node run through gets written
            s += node.Name + " : " + "\n";
            //write the text in a node, if it has no children of XMLElement
            if (node.FirstChild.NodeType != XmlNodeType.Element)
            {
                s += "  " + node.InnerText + "." + "\n";
            }

            //With exempt of the first node, check every node to see if it is an element,
            //other wise lesser nodes with no useable content will be run through.
            if (node.FirstChild.NodeType == XmlNodeType.Element)
            {
                foreach (XmlNode innerNode in node)
                {
                    s = NodeRunner(s, innerNode);
                }
            }
            
            return s;
        }


        #region NodeRunner Alpha


        //foreach (XmlNode CNode in node.ChildNodes)
        //{
        //    if (CNode.NodeType != XmlNodeType.Element)
        //    {
        //        return "";
        //    }
        //}
        //for each node
        //go through all childeNodes
        //call the method for each node
        ////
        //s += node.Name + " : ";
        //foreach (XmlNode innerNode in node)
        //{
        //    if (innerNode.InnerText == "") 
        //    {
        //        continue;
        //    }
        //    if (innerNode.HasChildNodes)
        //    {
        //        s += NodeRunner(s, innerNode);
        //    }
        //    else if(!innerNode.HasChildNodes)
        //    {
        //        s += innerNode.InnerText;
        //    }
        //}



        //if (node.NodeType != XmlNodeType.Element)
        //{
        //    return "";
        //}
        //foreach (XmlNode innerNode in node)
        //{
        //    if (innerNode.NodeType != XmlNodeType.Element)
        //    {
        //        return "";
        //    }
        //    s += innerNode.Name + " ";
        //    s += NodeRunner(s, innerNode);
        //}
        //s += node.Name + ": " + node.InnerText + "\n";
        #endregion


    }
}
