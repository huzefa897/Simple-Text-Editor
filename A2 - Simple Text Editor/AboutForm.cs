using A2___Simple_Text_Editor.Model;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace A2___Simple_Text_Editor
{
    /// <summary>
    /// Represents the About Form of the Simple Text Editor that displays product information.
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();

            // Try-catch block to handle About Form exceptions
            try
            {
                // AssemblyInformation object to get all assembly information
                AssemblyInformation assemblyInformation = new AssemblyInformation(Assembly.GetExecutingAssembly());

                // Set all the required fields of the about form with the assembly information
                Text = $"About {assemblyInformation.ProductTitle}";
                lblProductName.Text = assemblyInformation.Product;
                lblVersion.Text = $"Version {assemblyInformation.Version}";
                lblCopyright.Text = assemblyInformation.Copyright;
                lblCompanyName.Text = assemblyInformation.Company;
                gbAboutDescription.Text = $"Description about {assemblyInformation.ProductTitle}";
                txtDescription.Text = assemblyInformation.Description;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "About Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region OK button's event handlers

        /// <summary>
        /// Handles OK button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {
            // Close the About Form when the OK button is clicked
            Close();
        }
        #endregion
    }
}
