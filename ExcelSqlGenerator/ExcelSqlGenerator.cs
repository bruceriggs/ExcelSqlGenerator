using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelDocSQLGenerator
{
    public partial class ExcelSQLGenerator : Form
    {
        string fileName;
        string generatedSql;

        /// <summary>
        /// Constructor
        /// </summary>
        public ExcelSQLGenerator()
        {
            InitializeComponent();
            fileName = "UNINITIALIZED";

            // Debug test button. Purposefully hidden. Calls button1_Click() when clicked.
            button1.Hide();
        }

        /*
         URL for "documentation"
         https://github.com/ExcelDataReader/ExcelDataReader
         */
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    // Auto-detect format, supports:
                    //  - Binary Excel files (2.0-2003 format; *.xls)
                    //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        // Choose one of either 1 or 2:
                        // Jump to the correct sheet
                        int ii = 0;
                        int desired = Int32.Parse(NUDTab.Value.ToString());
                        for (; ii < desired; ++ii)
                        {
                            reader.NextResult();
                        }

                        // 1. Use the reader methods
                        object[] currentRow = new object[1];
                        //DataTable before = reader.GetSchemaTable();
                        reader.Read();
                        reader.GetValues(currentRow);
                        reader.Read();
                        reader.GetValues(currentRow);
                        reader.Close();

                        /*
                        do
                        {
                            while (reader.Read())
                            {
                                Double test = reader.GetDouble(0);


                            }
                        } while (reader.NextResult());*/

                        // The result of each spreadsheet is in result.Tables
                    }
                    stream.Close();
                }
            }
        }

        /// <summary>
        /// Verifies a textbox is not empty. Used in many places
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool t(TextBox text)
        {
            return text.Text != null && text.Text.Length > 0;
        }

        /// <summary>
        /// Adds Raw SQL to the List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddSQL_Click(object sender, EventArgs e)
        {
            if (t(TBoxSQL))
            {
                SQLComponent comp = new SQLComponent("S");
                comp.sql = TBoxSQL.Text;
                LBoxParts.Items.Add(comp);
                TBoxSQL.Clear();
                TBoxSQL.Focus();
            }
        }

        /// <summary>
        /// Removes a component from the List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            // Only bother if something is selected
            if (LBoxParts.Items.Count > 0 && LBoxParts.SelectedIndex != -1)
            {
                // Let's keep something selected afterwards
                int oldIndex = LBoxParts.SelectedIndex;
                // Remove that item
                LBoxParts.Items.RemoveAt(LBoxParts.SelectedIndex);
                if (LBoxParts.Items.Count == 0)
                {
                    LBoxParts.SelectedIndex = -1;
                    return;
                }
                else if (oldIndex < LBoxParts.Items.Count)
                {
                    LBoxParts.SelectedIndex = oldIndex;
                }
                else if (oldIndex == LBoxParts.Items.Count)
                {
                    LBoxParts.SelectedIndex = oldIndex - 1;
                }
            }
        }

        /// <summary>
        /// Moves an item up in the Parts list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUp_Click(object sender, EventArgs e)
        {
            if (LBoxParts.SelectedIndex != -1)
            {
                int selectedIndex = LBoxParts.SelectedIndex;
                if (selectedIndex > 0)
                {
                    // Swap the selected item with the one above it
                    var selectedItem = LBoxParts.Items[selectedIndex];
                    LBoxParts.Items[selectedIndex] = LBoxParts.Items[selectedIndex - 1];
                    LBoxParts.Items[selectedIndex - 1] = selectedItem;

                    // Update the selected index to reflect the new position
                    LBoxParts.SelectedIndex = selectedIndex - 1;
                }
            }
        }

        /// <summary>
        /// Moves an item down in the Parts list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDown_Click(object sender, EventArgs e)
        {
            if (LBoxParts.SelectedIndex != -1)
            {
                // Get the selected index
                int selectedIndex = LBoxParts.SelectedIndex;

                // Ensure there is an item selected and it's not the last item
                if (selectedIndex < LBoxParts.Items.Count - 1 && selectedIndex >= 0)
                {
                    // Swap the selected item with the one below it
                    var selectedItem = LBoxParts.Items[selectedIndex];
                    LBoxParts.Items[selectedIndex] = LBoxParts.Items[selectedIndex + 1];
                    LBoxParts.Items[selectedIndex + 1] = selectedItem;

                    // Update the selected index to reflect the new position
                    LBoxParts.SelectedIndex = selectedIndex + 1;
                }
            }
        }

        /// <summary>
        /// Converts an Excel Column to a Numeric 0-based Index
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static int ExcelColumnToNumber(string columnName)
        {
            int number = 0;

            for (int i = 0; i < columnName.Length; i++)
            {
                // Calculate the value of the current character and adjust for 0-based index
                number *= 26;
                number += (columnName[i] - 'A' + 1);
            }

            // Subtract 1 at the end to convert to 0-based indexing
            return number - 1;
        }

        /// <summary>
        /// Adds an Excel Column to the Part List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddColumn_Click(object sender, EventArgs e)
        {
            if (t(TBoxColumn))
            {
                int colIndex = -1;
                try
                {
                    colIndex = ExcelColumnToNumber(TBoxColumn.Text.ToUpper());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while attempting to parse the Column Letter. Did you type a correct Excel Column Letter?\n\n" + ex.Message, "Column Index Parse Error");
                }

                // Only proceed if a valid column is given
                if (colIndex != -1)
                {
                    // Create and add Column
                    SQLComponent newComp = new SQLComponent("C");
                    newComp.colIndex = colIndex;
                    newComp.includeTicks = CHBoxIncludeTicks.Checked;
                    newComp.allowNull = CHBoxAllowNullEntries.Checked;

                    LBoxParts.Items.Add(newComp);

                    TBoxColumn.Text = SQLComponent.NumberToExcelColumn(colIndex + 1);
                    CHBoxIncludeTicks.Checked = false;
                    CHBoxAllowNullEntries.Checked = false;
                    TBoxColumn.Focus();
                    TBoxColumn.SelectAll();
                }
                else
                {
                    MessageBox.Show("The Column Letter Given Does Not Seem Correct.", "Invalid Column Letter");
                }
            }
        }

        /// <summary>
        /// Chooses the Excel File for Parsing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Create and configure the OpenFileDialog
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Set the filter to only show Excel files
                openFileDialog.Filter = "Excel Files (*.xlsx; *.xls)|*.xlsx;*.xls|All Files (*.*)|*.*";

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    fileName = openFileDialog.FileName;
                    labelFile.Text = openFileDialog.SafeFileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the ButtonChooseFile_Click() method:\n\n" + ex.Message, "Error: ButtonChooseFile_Click()");
            }
        }

        /// <summary>
        /// Attempts to the Generate the SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            // Stop if no file chosen
            if (fileName == "UNINITIALIZED")
            {
                MessageBox.Show("You have not selected a File to Parse.", "No File Chosen");
                return;
            }

            // Stop if no Parts added
            if (LBoxParts.Items.Count == 0)
            {
                MessageBox.Show("You've added no SQL or Columns to Generate.", "Nothing to Generate");
                return;
            }

            try
            {
                StringBuilder builder = new StringBuilder();
                StringBuilder log = new StringBuilder();
                int rowCount = 1;
                using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        // Jump to the correct sheet
                        int ii = 0;
                        int desired = Int32.Parse(NUDTab.Value.ToString());
                        for(; ii < desired; ++ii) 
                        {
                            reader.NextResult();
                        }

                        // Determine the number of columns to care about
                        int NUM_INDEX = getHighestIndex();
                        ++NUM_INDEX;
                        object[] currentRow = new object[NUM_INDEX];

                        // If We're ignoring the First Row...
                        if (CHBoxHeader.Checked)
                        {
                            // Just read it real quick
                            reader.Read();
                            reader.GetValues(currentRow);
                            ++rowCount;
                        }

                        // For every row
                        while (reader.Read())
                        {
                            // Read the row
                            reader.GetValues(currentRow);

                            if (emptyRow(currentRow, NUM_INDEX))
                            {
                                // A row of nothing? Stop now.
                                break;
                            }

                            // Stringify everything
                            fixAllData(currentRow, NUM_INDEX, rowCount, log);

                            // Do any replaces now
                            replaceData(currentRow, NUM_INDEX, rowCount, log);

                            // Parse the data
                            buildRow(builder, currentRow, NUM_INDEX, rowCount, log);
                            ++rowCount;
                        }

                        // All done, close the reader
                        reader.Close();
                    }
                    stream.Close();
                }
                generatedSql = builder.ToString();
                TBoxFinishedSql.Text = generatedSql;
                TBoxLog.Text = log.ToString();
                Clipboard.SetText(generatedSql);
                if (log.Length > 0)
                {
                    MessageBox.Show("SQL Successfully Generated! It has been copied to your Clipboard.\n\nImproper null entries were found and logged. Check the Log tab for details.", "Success");
                }
                else
                {
                    MessageBox.Show("SQL Successfully Generated! It has been copied to your Clipboard.", "Success");
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("An error occurred trying to open the file. Is the file currently open? If so, close it!", "File Already Opened");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in ButtonGenerate_Click() while trying to generate the SQL.\n\n" + ex.Message, "Unknown Error Occurred");
            }
        }

        /// <summary>
        /// Converts all objects in the currentRow array to their string representations.
        /// </summary>
        private void fixAllData(object[] currentRow, int numCols, int rowCount, StringBuilder log)
        {
            try
            {
                for (int ii = 0; ii < numCols; ++ii)
                {
                    // Replace each element in currentRow with its string representation
                    currentRow[ii] = currentRow[ii]?.ToString();  // Safely convert to string
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the fixAllData() method:\n\n" + ex.Message, "Error: fixAllData()");
            }
        }

        /// <summary>
        /// Performs string find/replace on specified columns
        /// </summary>
        private void replaceData(object[] currentRow, int numCols, int rowCount, StringBuilder log)
        {
            try
            {
                // For every find/replace
                foreach (var item in LBoxFind.Items)
                {
                    SQLFind currItem = (SQLFind)item;
                    // Only try a replace if the column is within bounds, and the string exists
                    if (currItem.colIndex < numCols && currentRow[currItem.colIndex] != null && ((string)currentRow[currItem.colIndex]).Length > 0)
                    {
                        // Replace any instance
                        currentRow[currItem.colIndex] = ((string)currentRow[currItem.colIndex]).Replace(currItem.find, currItem.replace);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the replaceData() method:\n\n" + ex.Message, "Error: replaceData()");
            }
        }

        /// <summary>
        /// Determines if a row is empty or not
        /// </summary>
        private bool emptyRow(object[] currentRow, int numCols)
        {
            try
            {
                // For every column
                for (int ii = 0; ii < numCols; ++ii)
                {
                    // Stop at the first non-null column
                    if (currentRow[ii] != null && currentRow[ii].ToString().Length > 0)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the emptyRow() method:\n\n" + ex.Message, "Error: emptyRow()");
            }
            // We never stopped. This is an empty row
            return true;
        }

        /// <summary>
        /// Builds a row of SQL using the read in data and StringBuilder
        /// </summary>
        private void buildRow(StringBuilder builder, object[] currentRow, int numCols, int rowCount, StringBuilder log)
        {
            try
            {
                foreach (var item in LBoxParts.Items)
                {
                    SQLComponent currItem = (SQLComponent)item;
                    if (currItem.type == "S")
                    {
                        builder.Append(currItem.sql);
                    }
                    else
                    {
                        // Null entry?
                        if (currentRow[currItem.colIndex] == null || ((string)currentRow[currItem.colIndex]).Length <= 0)
                        {
                            // Do we allow nulls?
                            if (currItem.allowNull)
                            {
                                // Then it's fine
                                builder.Append("null");
                                continue;
                            }
                            else
                            {
                                // Put in a null, but log it and the line
                                builder.Append("null");
                                log.AppendLine("A null entry was found on row " + rowCount.ToString() + " for column " + SQLComponent.NumberToExcelColumn(currItem.colIndex));
                                continue;
                            }
                        }

                        // Include ticks?
                        if (currItem.includeTicks)
                        {
                            builder.Append("'");
                        }

                        builder.Append(currentRow[currItem.colIndex]);

                        // Include ticks?
                        if (currItem.includeTicks)
                        {
                            builder.Append("'");
                        }
                    }
                }
                builder.Append("\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the buildRow() method:\n\n" + ex.Message, "Error: buildRow()");
            }
        }

        /// <summary>
        /// Determines the highest column index in the Excel doc, for Object Array generation
        /// </summary>
        /// <returns></returns>
        private int getHighestIndex()
        {
            int highestIndex = -1;
            try
            {
                foreach (var item in LBoxParts.Items)
                {
                    SQLComponent currItem = (SQLComponent)item;
                    if (currItem.type == "C")
                    {
                        if (currItem.colIndex > highestIndex)
                        {
                            highestIndex = currItem.colIndex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the getHighestIndex() method:\n\n" + ex.Message, "Error: getHighestIndex()");
            }
            return highestIndex;
        }

        /// <summary>
        /// Removes a Find/Replace Entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveFind_Click(object sender, EventArgs e)
        {
            try
            {
                // Only bother if something is selected
                if (LBoxFind.Items.Count > 0 && LBoxFind.SelectedIndex != -1)
                {
                    // Let's keep something selected afterwards
                    int oldIndex = LBoxFind.SelectedIndex;
                    // Remove that item
                    LBoxFind.Items.RemoveAt(LBoxFind.SelectedIndex);
                    if (LBoxFind.Items.Count == 0)
                    {
                        LBoxFind.SelectedIndex = -1;
                        return;
                    }
                    else if (oldIndex < LBoxFind.Items.Count)
                    {
                        LBoxFind.SelectedIndex = oldIndex;
                    }
                    else if (oldIndex == LBoxFind.Items.Count)
                    {
                        LBoxFind.SelectedIndex = oldIndex - 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the buttonRemoveFind_Click() method:\n\n" + ex.Message, "Error: buttonRemoveFind_Click()");
            }
        }

        /// <summary>
        /// Moves a Find/Replace Entry Up in Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMoveFindUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (LBoxFind.SelectedIndex != -1)
                {
                    int selectedIndex = LBoxFind.SelectedIndex;
                    if (selectedIndex > 0)
                    {
                        // Swap the selected item with the one above it
                        var selectedItem = LBoxFind.Items[selectedIndex];
                        LBoxFind.Items[selectedIndex] = LBoxFind.Items[selectedIndex - 1];
                        LBoxFind.Items[selectedIndex - 1] = selectedItem;

                        // Update the selected index to reflect the new position
                        LBoxFind.SelectedIndex = selectedIndex - 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the buttonMoveFindUp_Click() method:\n\n" + ex.Message, "Error: buttonMoveFindUp_Click()");
            }
        }

        /// <summary>
        /// Moves a Find/Replace Entry Down in Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMoveFindDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (LBoxFind.SelectedIndex != -1)
                {
                    // Get the selected index
                    int selectedIndex = LBoxFind.SelectedIndex;

                    // Ensure there is an item selected and it's not the last item
                    if (selectedIndex < LBoxFind.Items.Count - 1 && selectedIndex >= 0)
                    {
                        // Swap the selected item with the one below it
                        var selectedItem = LBoxFind.Items[selectedIndex];
                        LBoxFind.Items[selectedIndex] = LBoxFind.Items[selectedIndex + 1];
                        LBoxFind.Items[selectedIndex + 1] = selectedItem;

                        // Update the selected index to reflect the new position
                        LBoxFind.SelectedIndex = selectedIndex + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the buttonMoveFindDown_Click() method:\n\n" + ex.Message, "Error: buttonMoveFindDown_Click()");
            }
        }

        /// <summary>
        /// Adds a Column Find/Replace Command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddFind_Click(object sender, EventArgs e)
        {
            try
            {
                // Only bother if Column and Find are specified
                if (t(TBoxFindCol) && t(TBoxFind))
                {
                    // If Replace is blank, warn them
                    if (!t(TBoxReplace))
                    {
                        DialogResult result = MessageBox.Show("You have specified a Find without a Replace. This means any matches will be replaced with nothing. Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }

                    // We're ready to go
                    SQLFind newFind = new SQLFind();
                    newFind.colIndex = ExcelColumnToNumber(TBoxFindCol.Text.ToUpper());
                    newFind.find = TBoxFind.Text;
                    newFind.replace = TBoxReplace.Text;
                    if (newFind.replace == null || newFind.replace.Length == 0)
                    {
                        newFind.replace = "";
                    }

                    LBoxFind.Items.Add(newFind);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the buttonAddFind_Click() method:\n\n" + ex.Message, "Error: buttonAddFind_Click()");
            }
        }

        /// <summary>
        /// Copies the Log to the Clipboard
        /// </summary>
        private void ButtonCopyLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBoxLog.Text != null && TBoxLog.Text.Length > 0)
                {
                    Clipboard.SetText(TBoxLog.Text);
                    MessageBox.Show("The Log has been copied to your Clipboard.", "Copied!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the ButtonCopyLog_Click() method:\n\n" + ex.Message, "Error: ButtonCopyLog_Click()");
            }
        }

        /// <summary>
        /// Copies the generated SQL to the Clipboard
        /// </summary>
        private void ButtonCopySql_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBoxFinishedSql.Text != null && TBoxFinishedSql.Text.Length > 0)
                {
                    Clipboard.SetText(TBoxFinishedSql.Text);
                    MessageBox.Show("The SQL has been copied to your Clipboard.", "Copied!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in the ButtonCopySql_Click() method:\n\n" + ex.Message, "Error: ButtonCopySql_Click()");
            }
        }

        /// <summary>
        /// Generates the SQL and creates a text file for it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenerateFile_Click(object sender, EventArgs e)
        {
            // Stop if no file chosen
            if (fileName == "UNINITIALIZED")
            {
                MessageBox.Show("You have not selected a File to Parse.", "No File Chosen");
                return;
            }

            // Stop if no Parts added
            if (LBoxParts.Items.Count == 0)
            {
                MessageBox.Show("You've added no SQL or Columns to Generate.", "Nothing to Generate");
                return;
            }

            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "SQL Files (*.sql)|*.sql|TXT Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    
                    StringBuilder builder = new StringBuilder();
                    StringBuilder log = new StringBuilder();
                    int rowCount = 1;
                    using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            // Jump to the correct sheet
                            int ii = 0;
                            int desired = Int32.Parse(NUDTab.Value.ToString());
                            for (; ii < desired; ++ii)
                            {
                                reader.NextResult();
                            }

                            // Determine the number of columns to care about
                            int NUM_INDEX = getHighestIndex();
                            ++NUM_INDEX;
                            object[] currentRow = new object[NUM_INDEX];

                            // If We're ignoring the First Row...
                            if (CHBoxHeader.Checked)
                            {
                                // Just read it real quick
                                reader.Read();
                                reader.GetValues(currentRow);
                                ++rowCount;
                            }

                            // For every row
                            while (reader.Read())
                            {
                                // Read the row
                                reader.GetValues(currentRow);

                                if (emptyRow(currentRow, NUM_INDEX))
                                {
                                    // A row of nothing? Stop now.
                                    break;
                                }

                                // Stringify everything
                                fixAllData(currentRow, NUM_INDEX, rowCount, log);

                                // Do any replaces now
                                replaceData(currentRow, NUM_INDEX, rowCount, log);

                                // Parse the data
                                buildRow(builder, currentRow, NUM_INDEX, rowCount, log);
                                ++rowCount;
                            }

                            // All done, close the reader
                            reader.Close();
                        }
                        stream.Close();
                    }
                    generatedSql = builder.ToString();
                    TBoxFinishedSql.Text = generatedSql;
                    TBoxLog.Text = log.ToString();

                    // Time to create the text file
                    using (StreamWriter writer = new StreamWriter(dialog.FileName)) 
                    {
                        writer.Write(generatedSql);
                    }

                    if (log.Length > 0)
                    {
                        MessageBox.Show("SQL Successfully Generated!\n\nImproper null entries were found and logged. Check the Log tab for details.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("SQL Successfully Generated!", "Success");
                    }
                    
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("An error occurred trying to open the file. Is the file currently open? If so, close it!", "File Already Opened");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in ButtonGenerateFile_Click() while trying to generate the SQL.\n\n" + ex.Message, "Unknown Error Occurred");
            }
        }
    }
}
