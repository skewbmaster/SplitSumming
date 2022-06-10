using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.UI;

namespace SplitSumming
{
    public partial class SummingSettings : UserControl
    {
        public SummingSettings()
        {
            InitializeComponent();
        }
        
        private Dictionary<string, bool> state;

        #region XML Settings Code
        public void SetSettings(XmlNode node)
        {
            XmlElement element = (XmlElement) node;

            if (element.IsEmpty) return;
            
            //startOption = SettingsHelper.ParseBool(element["startOption"]);

            ParseSettingsFromXml(element);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            XmlElement node = document.CreateElement("Settings");

            AppendSettingsToXml(document, node);
            //SettingsHelper.CreateSetting(document, node, "startOption", startOption);

            return node;
        }
        
        private void AppendSettingsToXml(XmlDocument document, XmlNode parent)
        {
            XmlElement aslParent = document.CreateElement("CustomSettings");

            /*foreach (var setting in state)
            {
                XmlElement element = SettingsHelper.ToElement(document, "Setting", setting.Value);
                XmlAttribute id = SettingsHelper.ToAttribute(document, "id", setting.Key);
                // In case there are other setting types in the future
                XmlAttribute type = SettingsHelper.ToAttribute(document, "type", "bool");

                element.Attributes.Append(id);
                element.Attributes.Append(type);
                aslParent.AppendChild(element);
            }*/

            parent.AppendChild(aslParent);
        }
        
        private void ParseSettingsFromXml(XmlElement data)
        {
            XmlElement customSettingsNode = data["CustomSettings"];

            /*if (customSettingsNode != null && customSettingsNode.HasChildNodes)
            {
                foreach (XmlElement element in customSettingsNode.ChildNodes)
                {
                    if (element.Name != "Setting")
                        continue;

                    string id = element.Attributes["id"].Value;
                    string type = element.Attributes["type"].Value;

                    if (id == null || type != "bool") continue;
                    bool value = SettingsHelper.ParseBool(element);
                    state[id] = value;
                }
            }*/
        }
        #endregion
    }
}