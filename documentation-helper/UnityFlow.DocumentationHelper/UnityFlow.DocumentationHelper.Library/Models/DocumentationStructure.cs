using System.Collections.Generic;

namespace UnityFlow.DocumentationHelper.Library.Models
{
    public class DocumentationStructure
    {
        public string AssemblyName;
        public string Namespace;
        public string ClassName;
        public List<DocumentationDescription> Descriptions;

        public DocumentationStructure(string assemblyName, string nameSpace, string className)
        {
            AssemblyName = assemblyName;
            Namespace = nameSpace;
            ClassName = className;
            Descriptions = new List<DocumentationDescription>();
        }

        public void AddDescription(DocumentationDescription description)
        {
            Descriptions.Add(description);
        }
    }

    public class DocumentationDescription
    {
        public string Title;
        public string Description;
        public string[] Args;
        
        public DocumentationDescription(string title, string description, string[] args = null)
        {
            Title = title;
            Description = description;
            Args = args;
        }
    }
}