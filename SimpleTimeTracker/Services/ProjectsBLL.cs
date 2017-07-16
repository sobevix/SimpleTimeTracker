using System;
using System.IO;
using System.Reflection;

using System.Collections.Generic; 
using SimpleTimeTracker.Models;
using System.Xml;


namespace SimpleTimeTracker.Services
{
    public class ProjectsBLL
    {
        private static string filePath = @"AppData/Projects.xml";
        public static void AddProject(Project project)
        {
            var doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode xmlProjects = doc.SelectSingleNode("root");
            XmlNode newProject = doc.CreateNode(XmlNodeType.Element, "Project", null);
            XmlNode projectName = doc.CreateNode(XmlNodeType.Element, "ProjectName", null);
            XmlNode projectId = doc.CreateNode(XmlNodeType.Element, "ProjectId", null);
            projectId.InnerText= project.Id.ToString();
            projectName.InnerText = project.ProjectName;

            newProject.AppendChild(projectId);
            newProject.AppendChild(projectName);

            xmlProjects.AppendChild(newProject);

            doc.Save(filePath);   
        }
        public static List<Project> GetProjects()
        {
            var retVal = new List<Project>();

            var doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode xmlProjects = doc.SelectSingleNode("root");
            foreach(XmlNode xmlProject in xmlProjects.ChildNodes)
            {
                string projectId = xmlProject.SelectSingleNode("ProjectId").InnerText;
                string projectName = xmlProject.SelectSingleNode("ProjectName").InnerText;
                retVal.Add(new Project { Id = Guid.Parse(projectId), ProjectName = projectName });
            }

            return retVal;
        }
        public static void DeleteProperty(Guid projectId)
        {
            var doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode xmlProjects = doc.SelectSingleNode("root");
            foreach (XmlNode xmlProject in xmlProjects.ChildNodes)
            {
                if (xmlProject.SelectSingleNode("ProjectId").InnerText == projectId.ToString())
                {
                    xmlProjects.RemoveChild(xmlProject);
                }
            }
            doc.Save(filePath);
        }
    }
}

