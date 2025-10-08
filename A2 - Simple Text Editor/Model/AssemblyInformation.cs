using System;
using System.IO;
using System.Reflection;

namespace A2___Simple_Text_Editor.Model
{
    /// <summary>
    /// Handels assembly information and access it.
    /// </summary>
    public class AssemblyInformation
    {
        // Private fields
        // Accessible only within the body of the class
        private readonly Assembly assembly;

        /// <summary>
        /// Overload constructor to get assembly object.
        /// </summary>
        /// <param name="assembly"></param>
        public AssemblyInformation(Assembly assembly)
        {
            this.assembly = assembly ?? throw new ArgumentNullException("assembly");
        }

        /// <summary>
        /// Gets the title property
        /// </summary>
        public string ProductTitle
        {
            get { return GetAttributeValue<AssemblyTitleAttribute>(a => a.Title, Path.GetFileNameWithoutExtension(assembly.CodeBase)); }
        }

        /// <summary>
        /// Gets the application's version
        /// </summary>
        public string Version
        {
            get
            {
                Version version = assembly.GetName().Version;
                return version != null ? version.ToString() : "1.0.0.0";
            }
        }

        /// <summary>
        /// Gets the description about the application.
        /// </summary>
        public string Description
        {
            get { return GetAttributeValue<AssemblyDescriptionAttribute>(a => a.Description); }
        }

        /// <summary>
        ///  Gets the product's full name.
        /// </summary>
        public string Product
        {
            get { return GetAttributeValue<AssemblyProductAttribute>(a => a.Product); }
        }

        /// <summary>
        /// Gets the copyright information for the product.
        /// </summary>
        public string Copyright
        {
            get { return GetAttributeValue<AssemblyCopyrightAttribute>(a => a.Copyright); }
        }

        /// <summary>
        /// Gets the company information for the product.
        /// </summary>
        public string Company
        {
            get { return GetAttributeValue<AssemblyCompanyAttribute>(a => a.Company); }
        }

        /// <summary>
        /// Gets the specific property of assembly information (generic method).
        /// </summary>
        /// <typeparam name="TAttr"></typeparam>
        /// <param name="resolveFunc"></param>
        /// <param name="defaultResult"></param>
        /// <returns></returns>
        protected string GetAttributeValue<TAttr>(Func<TAttr, string> resolveFunc, string defaultResult = null) where TAttr : Attribute
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(TAttr), false);
            if (attributes.Length > 0)
                return resolveFunc((TAttr)attributes[0]);
            else
                return defaultResult;
        }
    }
}
