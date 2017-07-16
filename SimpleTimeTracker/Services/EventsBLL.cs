using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Collections.Generic;
using System.Linq;  
using SimpleTimeTracker.Models;
using System.Xml; 

namespace SimpleTimeTracker.Services
{
    public class EventsBLL
    {
        private static string filePath = @"AppData/Events.xml";

        public static void AddEvent(EventEntry eventVar)
        {
            var doc = new XmlDocument();
            doc.Load(filePath);
            
            XmlNode xmlEvents = doc.SelectSingleNode("root");
            XmlNode newEvent = doc.CreateNode(XmlNodeType.Element, "Event", null);
            XmlNode eventDescription = doc.CreateNode(XmlNodeType.Element, "Description", null);
            XmlNode eventId = doc.CreateNode(XmlNodeType.Element, "EventId", null);
            XmlNode projectId = doc.CreateNode(XmlNodeType.Element, "ProjectId", null);
            XmlNode startTime = doc.CreateNode(XmlNodeType.Element, "StartTime", null);
            XmlNode endTime = doc.CreateNode(XmlNodeType.Element, "EndTime", null);
            XmlNode elapsedTime = doc.CreateNode(XmlNodeType.Element, "ElapsedTime", null); 

            eventId.InnerText = eventVar.Id.ToString();
            projectId.InnerText = eventVar.ProjectId.ToString();
            eventDescription.InnerText = eventVar.Description;
            startTime.InnerText = eventVar.StartTime.ToString();
            endTime.InnerText = eventVar.EndTime.ToString();
            elapsedTime.InnerText = eventVar.ElapsedTime.ToString();

            newEvent.AppendChild(eventId);
            newEvent.AppendChild(projectId);
            newEvent.AppendChild(eventDescription);
            newEvent.AppendChild(startTime);
            newEvent.AppendChild(endTime);
            newEvent.AppendChild(elapsedTime);

            xmlEvents.AppendChild(newEvent);

            doc.Save(filePath);
        }
        public static List<EventEntry> GetEvents(Guid mainProjectId)
        {
            var retVal = new List<EventEntry>();

            var doc = new XmlDocument();
            doc.Load(filePath);


            XmlNode xmlEvents = doc.SelectSingleNode("root");
            foreach (XmlNode xmlEvent in xmlEvents.ChildNodes)
            {
                string eventId = xmlEvent.SelectSingleNode("EventId").InnerText;
                string projectId = xmlEvent.SelectSingleNode("ProjectId").InnerText;
                string eventDescription = xmlEvent.SelectSingleNode("Description").InnerText;
                DateTime startTime = DateTime.Parse(xmlEvent.SelectSingleNode("StartTime").InnerText);
                DateTime endTime = DateTime.Parse(xmlEvent.SelectSingleNode("EndTime").InnerText);
                string elapsedTime = xmlEvent.SelectSingleNode("ElapsedTime").InnerText;

                retVal.Add(new EventEntry
                {
                    Id = Guid.Parse(eventId),
                    ProjectId = Guid.Parse(projectId),
                    Description = eventDescription,
                    StartTime = startTime,
                    EndTime = endTime,
                    ElapsedTime = elapsedTime
               
                });
            }

            return retVal.Where(x => x.ProjectId == mainProjectId).ToList();
        }
        public static void DeleteEvent(Guid eventId)
        {
            var doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode xmlEvents = doc.SelectSingleNode("root");
            foreach (XmlNode xmlEvent in xmlEvents.ChildNodes)
            {
                if (xmlEvent.SelectSingleNode("EventId").InnerText == eventId.ToString())
                {
                    xmlEvents.RemoveChild(xmlEvent);
                }
            }
            doc.Save(filePath);
        }
    } 
}
