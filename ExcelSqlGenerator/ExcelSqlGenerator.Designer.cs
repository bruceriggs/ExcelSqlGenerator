namespace ExcelDocSQLGenerator
{
    partial class ExcelSQLGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMoveFindDown = new System.Windows.Forms.Button();
            this.buttonMoveFindUp = new System.Windows.Forms.Button();
            this.buttonRemoveFind = new System.Windows.Forms.Button();
            this.labelFindReplace = new System.Windows.Forms.Label();
            this.LBoxFind = new System.Windows.Forms.ListBox();
            this.GBoxFind = new System.Windows.Forms.GroupBox();
            this.buttonAddFind = new System.Windows.Forms.Button();
            this.labelReplace = new System.Windows.Forms.Label();
            this.TBoxReplace = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.TBoxFind = new System.Windows.Forms.TextBox();
            this.TBoxFindCol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.GBoxSQL = new System.Windows.Forms.GroupBox();
            this.ButtonAddSQL = new System.Windows.Forms.Button();
            this.TBoxSQL = new System.Windows.Forms.TextBox();
            this.LBoxParts = new System.Windows.Forms.ListBox();
            this.GBoxCol = new System.Windows.Forms.GroupBox();
            this.CHBoxAllowNullEntries = new System.Windows.Forms.CheckBox();
            this.ButtonAddColumn = new System.Windows.Forms.Button();
            this.CHBoxIncludeTicks = new System.Windows.Forms.CheckBox();
            this.TBoxColumn = new System.Windows.Forms.TextBox();
            this.labelColumn = new System.Windows.Forms.Label();
            this.GBoxSpreadsheet = new System.Windows.Forms.GroupBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.ButtonChooseFile = new System.Windows.Forms.Button();
            this.CHBoxHeader = new System.Windows.Forms.CheckBox();
            this.NUDTab = new System.Windows.Forms.NumericUpDown();
            this.labelSpreadsheetInfoTab = new System.Windows.Forms.Label();
            this.tabSql = new System.Windows.Forms.TabPage();
            this.ButtonCopySql = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.ButtonCopyLog = new System.Windows.Forms.Button();
            this.labelLogStatus = new System.Windows.Forms.Label();
            this.ButtonGenerateFile = new System.Windows.Forms.Button();
            this.TBoxFinishedSql = new System.Windows.Forms.RichTextBox();
            this.TBoxLog = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.GBoxFind.SuspendLayout();
            this.GBoxSQL.SuspendLayout();
            this.GBoxCol.SuspendLayout();
            this.GBoxSpreadsheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTab)).BeginInit();
            this.tabSql.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Controls.Add(this.tabSql);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 612);
            this.tabControl1.TabIndex = 2;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.ButtonGenerateFile);
            this.tabInfo.Controls.Add(this.button1);
            this.tabInfo.Controls.Add(this.buttonMoveFindDown);
            this.tabInfo.Controls.Add(this.buttonMoveFindUp);
            this.tabInfo.Controls.Add(this.buttonRemoveFind);
            this.tabInfo.Controls.Add(this.labelFindReplace);
            this.tabInfo.Controls.Add(this.LBoxFind);
            this.tabInfo.Controls.Add(this.GBoxFind);
            this.tabInfo.Controls.Add(this.ButtonGenerate);
            this.tabInfo.Controls.Add(this.ButtonDown);
            this.tabInfo.Controls.Add(this.ButtonUp);
            this.tabInfo.Controls.Add(this.ButtonRemove);
            this.tabInfo.Controls.Add(this.GBoxSQL);
            this.tabInfo.Controls.Add(this.LBoxParts);
            this.tabInfo.Controls.Add(this.GBoxCol);
            this.tabInfo.Controls.Add(this.GBoxSpreadsheet);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(936, 586);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMoveFindDown
            // 
            this.buttonMoveFindDown.Location = new System.Drawing.Point(800, 360);
            this.buttonMoveFindDown.Name = "buttonMoveFindDown";
            this.buttonMoveFindDown.Size = new System.Drawing.Size(88, 23);
            this.buttonMoveFindDown.TabIndex = 16;
            this.buttonMoveFindDown.Text = "Move Down v";
            this.buttonMoveFindDown.UseVisualStyleBackColor = true;
            this.buttonMoveFindDown.Click += new System.EventHandler(this.buttonMoveFindDown_Click);
            // 
            // buttonMoveFindUp
            // 
            this.buttonMoveFindUp.Location = new System.Drawing.Point(706, 360);
            this.buttonMoveFindUp.Name = "buttonMoveFindUp";
            this.buttonMoveFindUp.Size = new System.Drawing.Size(88, 23);
            this.buttonMoveFindUp.TabIndex = 15;
            this.buttonMoveFindUp.Text = "Move Up ^";
            this.buttonMoveFindUp.UseVisualStyleBackColor = true;
            this.buttonMoveFindUp.Click += new System.EventHandler(this.buttonMoveFindUp_Click);
            // 
            // buttonRemoveFind
            // 
            this.buttonRemoveFind.Location = new System.Drawing.Point(625, 360);
            this.buttonRemoveFind.Name = "buttonRemoveFind";
            this.buttonRemoveFind.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveFind.TabIndex = 14;
            this.buttonRemoveFind.Text = "Remove";
            this.buttonRemoveFind.UseVisualStyleBackColor = true;
            this.buttonRemoveFind.Click += new System.EventHandler(this.buttonRemoveFind_Click);
            // 
            // labelFindReplace
            // 
            this.labelFindReplace.AutoSize = true;
            this.labelFindReplace.Location = new System.Drawing.Point(625, 206);
            this.labelFindReplace.Name = "labelFindReplace";
            this.labelFindReplace.Size = new System.Drawing.Size(102, 13);
            this.labelFindReplace.TabIndex = 14;
            this.labelFindReplace.Text = "Find/Replace Parts:";
            // 
            // LBoxFind
            // 
            this.LBoxFind.FormattingEnabled = true;
            this.LBoxFind.Location = new System.Drawing.Point(625, 222);
            this.LBoxFind.Name = "LBoxFind";
            this.LBoxFind.Size = new System.Drawing.Size(300, 134);
            this.LBoxFind.TabIndex = 13;
            // 
            // GBoxFind
            // 
            this.GBoxFind.Controls.Add(this.buttonAddFind);
            this.GBoxFind.Controls.Add(this.labelReplace);
            this.GBoxFind.Controls.Add(this.TBoxReplace);
            this.GBoxFind.Controls.Add(this.labelFind);
            this.GBoxFind.Controls.Add(this.TBoxFind);
            this.GBoxFind.Controls.Add(this.TBoxFindCol);
            this.GBoxFind.Controls.Add(this.label1);
            this.GBoxFind.Location = new System.Drawing.Point(625, 11);
            this.GBoxFind.Name = "GBoxFind";
            this.GBoxFind.Size = new System.Drawing.Size(300, 187);
            this.GBoxFind.TabIndex = 12;
            this.GBoxFind.TabStop = false;
            this.GBoxFind.Text = "Find/Replace";
            // 
            // buttonAddFind
            // 
            this.buttonAddFind.Location = new System.Drawing.Point(92, 97);
            this.buttonAddFind.Name = "buttonAddFind";
            this.buttonAddFind.Size = new System.Drawing.Size(113, 23);
            this.buttonAddFind.TabIndex = 10;
            this.buttonAddFind.Text = "Add Find/Replace";
            this.buttonAddFind.UseVisualStyleBackColor = true;
            this.buttonAddFind.Click += new System.EventHandler(this.buttonAddFind_Click);
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(36, 74);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(50, 13);
            this.labelReplace.TabIndex = 7;
            this.labelReplace.Text = "Replace:";
            // 
            // TBoxReplace
            // 
            this.TBoxReplace.Location = new System.Drawing.Point(92, 71);
            this.TBoxReplace.Name = "TBoxReplace";
            this.TBoxReplace.Size = new System.Drawing.Size(113, 20);
            this.TBoxReplace.TabIndex = 9;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(56, 48);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(30, 13);
            this.labelFind.TabIndex = 5;
            this.labelFind.Text = "Find:";
            // 
            // TBoxFind
            // 
            this.TBoxFind.Location = new System.Drawing.Point(92, 45);
            this.TBoxFind.Name = "TBoxFind";
            this.TBoxFind.Size = new System.Drawing.Size(113, 20);
            this.TBoxFind.TabIndex = 8;
            // 
            // TBoxFindCol
            // 
            this.TBoxFindCol.Location = new System.Drawing.Point(92, 18);
            this.TBoxFindCol.Name = "TBoxFindCol";
            this.TBoxFindCol.Size = new System.Drawing.Size(113, 20);
            this.TBoxFindCol.TabIndex = 7;
            this.TBoxFindCol.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Column (Letter):";
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerate.Location = new System.Drawing.Point(625, 397);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(300, 70);
            this.ButtonGenerate.TabIndex = 21;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // ButtonDown
            // 
            this.ButtonDown.Location = new System.Drawing.Point(188, 550);
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.Size = new System.Drawing.Size(88, 23);
            this.ButtonDown.TabIndex = 20;
            this.ButtonDown.Text = "Move Down v";
            this.ButtonDown.UseVisualStyleBackColor = true;
            this.ButtonDown.Click += new System.EventHandler(this.ButtonDown_Click);
            // 
            // ButtonUp
            // 
            this.ButtonUp.Location = new System.Drawing.Point(94, 550);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(88, 23);
            this.ButtonUp.TabIndex = 19;
            this.ButtonUp.Text = "Move Up ^";
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += new System.EventHandler(this.ButtonUp_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(13, 550);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemove.TabIndex = 18;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // GBoxSQL
            // 
            this.GBoxSQL.Controls.Add(this.ButtonAddSQL);
            this.GBoxSQL.Controls.Add(this.TBoxSQL);
            this.GBoxSQL.Location = new System.Drawing.Point(13, 204);
            this.GBoxSQL.Name = "GBoxSQL";
            this.GBoxSQL.Size = new System.Drawing.Size(606, 187);
            this.GBoxSQL.TabIndex = 8;
            this.GBoxSQL.TabStop = false;
            this.GBoxSQL.Text = "Raw SQL";
            // 
            // ButtonAddSQL
            // 
            this.ButtonAddSQL.Location = new System.Drawing.Point(525, 156);
            this.ButtonAddSQL.Name = "ButtonAddSQL";
            this.ButtonAddSQL.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddSQL.TabIndex = 12;
            this.ButtonAddSQL.Text = "Add SQL";
            this.ButtonAddSQL.UseVisualStyleBackColor = true;
            this.ButtonAddSQL.Click += new System.EventHandler(this.ButtonAddSQL_Click);
            // 
            // TBoxSQL
            // 
            this.TBoxSQL.Location = new System.Drawing.Point(6, 19);
            this.TBoxSQL.Multiline = true;
            this.TBoxSQL.Name = "TBoxSQL";
            this.TBoxSQL.Size = new System.Drawing.Size(594, 133);
            this.TBoxSQL.TabIndex = 11;
            // 
            // LBoxParts
            // 
            this.LBoxParts.FormattingEnabled = true;
            this.LBoxParts.HorizontalScrollbar = true;
            this.LBoxParts.Location = new System.Drawing.Point(13, 397);
            this.LBoxParts.Name = "LBoxParts";
            this.LBoxParts.Size = new System.Drawing.Size(606, 147);
            this.LBoxParts.TabIndex = 17;
            // 
            // GBoxCol
            // 
            this.GBoxCol.Controls.Add(this.CHBoxAllowNullEntries);
            this.GBoxCol.Controls.Add(this.ButtonAddColumn);
            this.GBoxCol.Controls.Add(this.CHBoxIncludeTicks);
            this.GBoxCol.Controls.Add(this.TBoxColumn);
            this.GBoxCol.Controls.Add(this.labelColumn);
            this.GBoxCol.Location = new System.Drawing.Point(319, 11);
            this.GBoxCol.Name = "GBoxCol";
            this.GBoxCol.Size = new System.Drawing.Size(300, 187);
            this.GBoxCol.TabIndex = 2;
            this.GBoxCol.TabStop = false;
            this.GBoxCol.Text = "Columns";
            // 
            // CHBoxAllowNullEntries
            // 
            this.CHBoxAllowNullEntries.AutoSize = true;
            this.CHBoxAllowNullEntries.Location = new System.Drawing.Point(93, 67);
            this.CHBoxAllowNullEntries.Name = "CHBoxAllowNullEntries";
            this.CHBoxAllowNullEntries.Size = new System.Drawing.Size(107, 17);
            this.CHBoxAllowNullEntries.TabIndex = 5;
            this.CHBoxAllowNullEntries.Text = "Allow Null Entries";
            this.CHBoxAllowNullEntries.UseVisualStyleBackColor = true;
            // 
            // ButtonAddColumn
            // 
            this.ButtonAddColumn.Location = new System.Drawing.Point(93, 90);
            this.ButtonAddColumn.Name = "ButtonAddColumn";
            this.ButtonAddColumn.Size = new System.Drawing.Size(113, 23);
            this.ButtonAddColumn.TabIndex = 6;
            this.ButtonAddColumn.Text = "Add Column";
            this.ButtonAddColumn.UseVisualStyleBackColor = true;
            this.ButtonAddColumn.Click += new System.EventHandler(this.ButtonAddColumn_Click);
            // 
            // CHBoxIncludeTicks
            // 
            this.CHBoxIncludeTicks.AutoSize = true;
            this.CHBoxIncludeTicks.Location = new System.Drawing.Point(93, 44);
            this.CHBoxIncludeTicks.Name = "CHBoxIncludeTicks";
            this.CHBoxIncludeTicks.Size = new System.Drawing.Size(124, 17);
            this.CHBoxIncludeTicks.TabIndex = 4;
            this.CHBoxIncludeTicks.Text = "Include Ticks? \'Blah\'";
            this.CHBoxIncludeTicks.UseVisualStyleBackColor = true;
            // 
            // TBoxColumn
            // 
            this.TBoxColumn.Location = new System.Drawing.Point(93, 18);
            this.TBoxColumn.Name = "TBoxColumn";
            this.TBoxColumn.Size = new System.Drawing.Size(113, 20);
            this.TBoxColumn.TabIndex = 3;
            this.TBoxColumn.Text = "A";
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.Location = new System.Drawing.Point(7, 21);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(81, 13);
            this.labelColumn.TabIndex = 0;
            this.labelColumn.Text = "Column (Letter):";
            // 
            // GBoxSpreadsheet
            // 
            this.GBoxSpreadsheet.Controls.Add(this.labelFile);
            this.GBoxSpreadsheet.Controls.Add(this.ButtonChooseFile);
            this.GBoxSpreadsheet.Controls.Add(this.CHBoxHeader);
            this.GBoxSpreadsheet.Controls.Add(this.NUDTab);
            this.GBoxSpreadsheet.Controls.Add(this.labelSpreadsheetInfoTab);
            this.GBoxSpreadsheet.Location = new System.Drawing.Point(13, 11);
            this.GBoxSpreadsheet.Name = "GBoxSpreadsheet";
            this.GBoxSpreadsheet.Size = new System.Drawing.Size(300, 187);
            this.GBoxSpreadsheet.TabIndex = 1;
            this.GBoxSpreadsheet.TabStop = false;
            this.GBoxSpreadsheet.Text = "Spreadsheet";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(88, 100);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(88, 13);
            this.labelFile.TabIndex = 4;
            this.labelFile.Text = "No File Chosen...";
            // 
            // ButtonChooseFile
            // 
            this.ButtonChooseFile.Location = new System.Drawing.Point(88, 71);
            this.ButtonChooseFile.Name = "ButtonChooseFile";
            this.ButtonChooseFile.Size = new System.Drawing.Size(114, 23);
            this.ButtonChooseFile.TabIndex = 2;
            this.ButtonChooseFile.Text = "Choose Excel File...";
            this.ButtonChooseFile.UseVisualStyleBackColor = true;
            this.ButtonChooseFile.Click += new System.EventHandler(this.ButtonChooseFile_Click);
            // 
            // CHBoxHeader
            // 
            this.CHBoxHeader.AutoSize = true;
            this.CHBoxHeader.Checked = true;
            this.CHBoxHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHBoxHeader.Location = new System.Drawing.Point(89, 48);
            this.CHBoxHeader.Name = "CHBoxHeader";
            this.CHBoxHeader.Size = new System.Drawing.Size(153, 17);
            this.CHBoxHeader.TabIndex = 1;
            this.CHBoxHeader.Text = "Ignore First Row (Header)?";
            this.CHBoxHeader.UseVisualStyleBackColor = true;
            // 
            // NUDTab
            // 
            this.NUDTab.Location = new System.Drawing.Point(89, 19);
            this.NUDTab.Name = "NUDTab";
            this.NUDTab.Size = new System.Drawing.Size(45, 20);
            this.NUDTab.TabIndex = 0;
            // 
            // labelSpreadsheetInfoTab
            // 
            this.labelSpreadsheetInfoTab.AutoSize = true;
            this.labelSpreadsheetInfoTab.Location = new System.Drawing.Point(7, 21);
            this.labelSpreadsheetInfoTab.Name = "labelSpreadsheetInfoTab";
            this.labelSpreadsheetInfoTab.Size = new System.Drawing.Size(80, 13);
            this.labelSpreadsheetInfoTab.TabIndex = 0;
            this.labelSpreadsheetInfoTab.Text = "Sheet to Parse:";
            // 
            // tabSql
            // 
            this.tabSql.Controls.Add(this.TBoxFinishedSql);
            this.tabSql.Controls.Add(this.ButtonCopySql);
            this.tabSql.Controls.Add(this.label2);
            this.tabSql.Location = new System.Drawing.Point(4, 22);
            this.tabSql.Name = "tabSql";
            this.tabSql.Size = new System.Drawing.Size(936, 586);
            this.tabSql.TabIndex = 2;
            this.tabSql.Text = "SQL";
            this.tabSql.UseVisualStyleBackColor = true;
            // 
            // ButtonCopySql
            // 
            this.ButtonCopySql.Location = new System.Drawing.Point(815, 553);
            this.ButtonCopySql.Name = "ButtonCopySql";
            this.ButtonCopySql.Size = new System.Drawing.Size(113, 23);
            this.ButtonCopySql.TabIndex = 11;
            this.ButtonCopySql.Text = "Copy SQL";
            this.ButtonCopySql.UseVisualStyleBackColor = true;
            this.ButtonCopySql.Click += new System.EventHandler(this.ButtonCopySql_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "A ReadOnly Copy of Generated SQL";
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.TBoxLog);
            this.tabLog.Controls.Add(this.ButtonCopyLog);
            this.tabLog.Controls.Add(this.labelLogStatus);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(936, 586);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // ButtonCopyLog
            // 
            this.ButtonCopyLog.Location = new System.Drawing.Point(815, 553);
            this.ButtonCopyLog.Name = "ButtonCopyLog";
            this.ButtonCopyLog.Size = new System.Drawing.Size(113, 23);
            this.ButtonCopyLog.TabIndex = 8;
            this.ButtonCopyLog.Text = "Copy Log";
            this.ButtonCopyLog.UseVisualStyleBackColor = true;
            this.ButtonCopyLog.Click += new System.EventHandler(this.ButtonCopyLog_Click);
            // 
            // labelLogStatus
            // 
            this.labelLogStatus.AutoSize = true;
            this.labelLogStatus.Location = new System.Drawing.Point(8, 8);
            this.labelLogStatus.Name = "labelLogStatus";
            this.labelLogStatus.Size = new System.Drawing.Size(166, 13);
            this.labelLogStatus.TabIndex = 0;
            this.labelLogStatus.Text = "A ReadOnly Status of Log Events";
            // 
            // ButtonGenerateFile
            // 
            this.ButtonGenerateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerateFile.Location = new System.Drawing.Point(625, 473);
            this.ButtonGenerateFile.Name = "ButtonGenerateFile";
            this.ButtonGenerateFile.Size = new System.Drawing.Size(300, 70);
            this.ButtonGenerateFile.TabIndex = 23;
            this.ButtonGenerateFile.Text = "Generate File...";
            this.ButtonGenerateFile.UseVisualStyleBackColor = true;
            this.ButtonGenerateFile.Click += new System.EventHandler(this.ButtonGenerateFile_Click);
            // 
            // TBoxFinishedSql
            // 
            this.TBoxFinishedSql.Location = new System.Drawing.Point(11, 24);
            this.TBoxFinishedSql.Name = "TBoxFinishedSql";
            this.TBoxFinishedSql.ReadOnly = true;
            this.TBoxFinishedSql.Size = new System.Drawing.Size(917, 523);
            this.TBoxFinishedSql.TabIndex = 12;
            this.TBoxFinishedSql.Text = "";
            // 
            // TBoxLog
            // 
            this.TBoxLog.Location = new System.Drawing.Point(11, 24);
            this.TBoxLog.Name = "TBoxLog";
            this.TBoxLog.ReadOnly = true;
            this.TBoxLog.Size = new System.Drawing.Size(917, 523);
            this.TBoxLog.TabIndex = 9;
            this.TBoxLog.Text = "";
            // 
            // ExcelSQLGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 612);
            this.Controls.Add(this.tabControl1);
            this.Name = "ExcelSQLGenerator";
            this.Text = "Excel SQL Generator";
            this.tabControl1.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.GBoxFind.ResumeLayout(false);
            this.GBoxFind.PerformLayout();
            this.GBoxSQL.ResumeLayout(false);
            this.GBoxSQL.PerformLayout();
            this.GBoxCol.ResumeLayout(false);
            this.GBoxCol.PerformLayout();
            this.GBoxSpreadsheet.ResumeLayout(false);
            this.GBoxSpreadsheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTab)).EndInit();
            this.tabSql.ResumeLayout(false);
            this.tabSql.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.GroupBox GBoxSpreadsheet;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Label labelLogStatus;
        private System.Windows.Forms.TextBox TBoxSQL;
        private System.Windows.Forms.GroupBox GBoxCol;
        private System.Windows.Forms.Button ButtonAddColumn;
        private System.Windows.Forms.CheckBox CHBoxIncludeTicks;
        private System.Windows.Forms.TextBox TBoxColumn;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.Button ButtonChooseFile;
        private System.Windows.Forms.CheckBox CHBoxHeader;
        private System.Windows.Forms.NumericUpDown NUDTab;
        private System.Windows.Forms.Label labelSpreadsheetInfoTab;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Button ButtonDown;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.GroupBox GBoxSQL;
        private System.Windows.Forms.Button ButtonAddSQL;
        private System.Windows.Forms.ListBox LBoxParts;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonMoveFindDown;
        private System.Windows.Forms.Button buttonMoveFindUp;
        private System.Windows.Forms.Button buttonRemoveFind;
        private System.Windows.Forms.Label labelFindReplace;
        private System.Windows.Forms.ListBox LBoxFind;
        private System.Windows.Forms.GroupBox GBoxFind;
        private System.Windows.Forms.Button buttonAddFind;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.TextBox TBoxReplace;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox TBoxFind;
        private System.Windows.Forms.TextBox TBoxFindCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CHBoxAllowNullEntries;
        private System.Windows.Forms.TabPage tabSql;
        private System.Windows.Forms.Button ButtonCopyLog;
        private System.Windows.Forms.Button ButtonCopySql;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonGenerateFile;
        private System.Windows.Forms.RichTextBox TBoxFinishedSql;
        private System.Windows.Forms.RichTextBox TBoxLog;
    }
}

