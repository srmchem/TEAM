﻿using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TEAM
{
    public partial class FormManageValidation : FormBase
    {
        private readonly FormManageMetadata _myParent;

        public FormManageValidation(FormManageMetadata parent)
        {            
            _myParent = parent;
            InitializeComponent();

            // Make sure the validation information is available in this form.
            try
            {
                var validationFile = GlobalParameters.ConfigurationPath + GlobalParameters.ValidationFileName + '_' + GlobalParameters.WorkingEnvironment + GlobalParameters.FileExtension;

                // If the config file does not exist yet, create it by calling the EnvironmentConfiguration Class
                if (!File.Exists(validationFile))
                {
                    ValidationSetting.CreateDummyValidationFile(validationFile);
                }

                // Load the validation settings file using the paths retrieved from the application root contents (configuration path)
                ValidationSetting.LoadValidationFile(validationFile);

                richTextBoxInformation.Text += $@"The validation file {validationFile} has been loaded.";

                // Apply the values to the form
                LocalInitialiseValidationSettings();
            }
            catch (Exception)
            {
                // Do nothing
            }

        }

        /// <summary>
        /// This method will update the validation values on the form.
        /// </summary>
        private void LocalInitialiseValidationSettings()
        {
            // Source object existence
            switch (ValidationSetting.DataObjectExistence)
            {
                case "True":
                    checkBoxDataObjectExistence.Checked = true;
                    break;
                case "False":
                    checkBoxDataObjectExistence.Checked = false;
                    break;
                default:
                    MessageBox.Show("There is something wrong with the source object validation values, only true and false are allowed but this was encountered: " + ValidationSetting.DataObjectExistence + ". Please check the validation file (TEAM_<environment>_validation.txt)", "An issue has been encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            // Source attribute existence
            switch (ValidationSetting.DataItemExistence)
            {
                case "True":
                    checkBoxDataItemExistence.Checked = true;
                    break;
                case "False":
                    checkBoxDataItemExistence.Checked = false;
                    break;
                default:
                    MessageBox.Show("There is something wrong with the source attribute validation values, only true and false are allowed but this was encountered: " + ValidationSetting.DataItemExistence + ". Please check the validation file (TEAM_<environment>_validation.txt)", "An issue has been encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            if (ValidationSetting.SourceBusinessKeyExistence == "True")
            {
                checkBoxSourceBusinessKeyExistence.Checked = true;
            }
            else if (ValidationSetting.SourceBusinessKeyExistence == "False")
            {
                checkBoxSourceBusinessKeyExistence.Checked = false;
            }
            else
            {
                // Raise exception
                MessageBox.Show("There is something wrong with the business key validation values, only true and false are allowed but this was encountered: " +
                                ValidationSetting.SourceBusinessKeyExistence + ". Please check the validation file (TEAM_<environment>_validation.txt)", "An issue has been encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (ValidationSetting.LogicalGroup == "True")
            {
                checkBoxLogicalGroup.Checked = true;
            }
            else if (ValidationSetting.LogicalGroup == "False")
            {
                checkBoxLogicalGroup.Checked = false;
            }
            else
            {
                // Raise exception
                MessageBox.Show("There is something wrong with the logical group validation values, only true and false are allowed but this was encountered: " + ValidationSetting.LogicalGroup + ". Please check the validation file (TEAM_<environment>_validation.txt)", "An issue has been encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Link Key order
            if (ValidationSetting.LinkKeyOrder == "True")
            {
                checkBoxLinkKeyOrder.Checked = true;
            }
            else if (ValidationSetting.LinkKeyOrder == "False")
            {
                checkBoxLinkKeyOrder.Checked = false;
            }
            else
            {
                // Raise exception
                MessageBox.Show("There is something wrong with the Link key order validation values, only true and false are allowed but this was encountered: " + ValidationSetting.LinkKeyOrder + ". Please check the validation file (TEAM_<environment>_validation.txt)", "An issue has been encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Business Key Syntax
            if (ValidationSetting.BusinessKeySyntax == "True")
            {
                checkBoxBusinessKeySyntaxValidation.Checked = true;
            }
            else if (ValidationSetting.BusinessKeySyntax == "False")
            {
                checkBoxBusinessKeySyntaxValidation.Checked = false;
            }
            else
            {
                // Raise exception
                MessageBox.Show("There is something wrong with the business key syntax validation values, only true and false are allowed but this was encountered: " + ValidationSetting.BusinessKeySyntax + ". Please check the validation file (TEAM_<environment>_validation.txt)", "An issue has been encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Data Vault checks
            if (ValidationSetting.BasicDataVaultValidation == "True")
            {
                checkBoxBasicDataVaultValidation.Checked = true;
            }
            else if (ValidationSetting.BasicDataVaultValidation == "False")
            {
                checkBoxBasicDataVaultValidation.Checked = false;
            }
            else
            {
                // Raise exception
                MessageBox.Show("There is something wrong with the business key syntax validation values, only true and false are allowed but this was encountered: " + ValidationSetting.BasicDataVaultValidation + ". Please check the validation file (TEAM_<environment>_validation.txt)", "An issue has been encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void openConfigurationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var theDialog = new OpenFileDialog
            {
                Title = @"Open Validation File",
                Filter = @"Text files|*.txt",
                InitialDirectory = @"" + GlobalParameters.ConfigurationPath + ""
            };

            if (theDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                var myStream = theDialog.OpenFile();

                using (myStream)
                {
                    richTextBoxInformation.Clear();
                    var chosenFile = theDialog.FileName;

                    // Load from disk into memory
                    ValidationSetting.LoadValidationFile(chosenFile);

                    // Update values on form
                    LocalInitialiseValidationSettings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message, "An issues has been encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Save validation settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                // Source object existence check
                var dataObjectExistence = "";
                dataObjectExistence = checkBoxDataObjectExistence.Checked ? "True" : "False";
                ValidationSetting.DataObjectExistence = dataObjectExistence;


                // Source business key existence check
                var stringBusinessKeyExistence = "";
                stringBusinessKeyExistence = checkBoxSourceBusinessKeyExistence.Checked ? "True" : "False";
                ValidationSetting.SourceBusinessKeyExistence = stringBusinessKeyExistence;


                // Source attribute existence check
                var stringSourceAttributeExistence = "";
                stringSourceAttributeExistence = checkBoxDataItemExistence.Checked ? "True" : "False";
                ValidationSetting.DataItemExistence = stringSourceAttributeExistence;


                // Logical Group Validation
                var stringLogicalGroup = "";
                stringLogicalGroup = checkBoxLogicalGroup.Checked ? "True" : "False";
                ValidationSetting.LogicalGroup = stringLogicalGroup;


                // Link Key Order Validation
                var stringLinkKeyOrder = "";
                stringLinkKeyOrder = checkBoxLinkKeyOrder.Checked ? "True" : "False";
                ValidationSetting.LinkKeyOrder = stringLinkKeyOrder;


                // Business key syntax check
                var businessKeySyntax = "";
                businessKeySyntax = checkBoxBusinessKeySyntaxValidation.Checked ? "True" : "False";
                ValidationSetting.BusinessKeySyntax = businessKeySyntax;

                // Data Vault model syntax check
                var dataVaultBasicCheck = "";
                dataVaultBasicCheck = checkBoxBasicDataVaultValidation.Checked ? "True" : "False";
                ValidationSetting.BasicDataVaultValidation = dataVaultBasicCheck;


                // Write to disk
                ValidationSetting.SaveValidationFile();

                richTextBoxInformation.Text = @"The values have been successfully saved.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not write values to memory and disk. Original error: " + ex.Message, "An issues has been encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openConfigurationDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(GlobalParameters.ConfigurationPath);
            }
            catch (Exception ex)
            {
                richTextBoxInformation.Text = "An error has occurred while attempting to open the configuration directory. The error message is: " + ex;
            }
        }

        private void openOutputDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(GlobalParameters.OutputPath);
            }
            catch (Exception ex)
            {
                richTextBoxInformation.Text = "An error has occurred while attempting to open the configuration directory. The error message is: " + ex;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
