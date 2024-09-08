# ExcelSqlGenerator
Generates SQL using columns from an Excel Doc, plus any raw SQL you may specify. Uses the NuGet package ExcelDataReader 3.7.0

![image](https://github.com/user-attachments/assets/d03d1dc7-24df-4670-a10c-7b931c9cd8c3)

## Section Overview

### Orange Section - Choosing a File
The first section (with the orange text) is for specifying what excel file you want to pull values from.

- Sheet to Parse
  - You can pick which tab/sheet of Excel you want to pull values from.
- Ignore First Row
  - If your first row is nothing but header columns, you can opt to skip over this row.
- Choose Excel File Button
  - Self explanatory. You can pick an Excel file. It supports .xls and .xlsx formats

### Red Section - Raw SQL Adding
This is for portions of SQL that wont change for every query. For example, say you have a document that wants to insert entries into a table for every row of the excel document. Your SQL would look something like this...

```sql
INSERT INTO MY_TABLE VALUES ( MYTA_SQ.NEXTVAL(), <COLUMN A>, <COLUMN B> );
INSERT INTO MY_TABLE VALUES ( MYTA_SQ.NEXTVAL(), <COLUMN A>, <COLUMN B> );
INSERT INTO MY_TABLE VALUES ( MYTA_SQ.NEXTVAL(), <COLUMN A>, <COLUMN B> );
INSERT INTO MY_TABLE VALUES ( MYTA_SQ.NEXTVAL(), <COLUMN A>, <COLUMN B> );
```

^ So in this case, since every SQL statement is going to start with the `INSERT` portion, you can add that in the Raw SQL portion. Then, after COLUMN A, you're always going to have a comma and space, so you could add ", " next.

### Purple Section - Column Adding
This is where you add a column from your document's tab/sheet into your SQL.

- Column (Letter)
  - The excel column to insert into your document. Case insensitive.
- Include Ticks? 'Blah'
  - Whether this column's data should be surrounded with single quotes. This is useful for insert string values into your SQL. So if your cell said `Bruce`, it would be inserted into the SQL as `'Bruce'`.
- Allow Null Entries
  - Whether it's okay or not for a column to be null. Sometimes you are given a document with thousands of rows, and in just a few of those rows, there is faulty data. If this program finds a null cell, it is going to put `null` into the SQL. If this is okay, then check this box. However, if this is NOT okay, leave the box unchecked, and if any null entries are found, a `null` entry will still be inserted into the SQL, but they will be also be logged in the Log tab aftewards, so that you can make corrections to the document and run the generator again, or you can browse to the location in the SQL and make the corrections yourself.
- Add Column Button
  - Self explanatory. Adds the column to the output section.

### Green Section - Filter Adding/Listing
This section is for doing a find/replace on cells as they are generated into SQL. For example, if you had an Excel document that listed "Active" and "Inactive" for a status, but your database only stores them as "T" or "F", you can do a find/replace on the text as you go to convert them automatically.

- Column (Letter)
  - Which column we are going to be performing the Find/Replace action on.
- Find
  - What to find. Case sensitive. Cannot be null.
- Replace
  - What to replace with. Case sensitive. Allows null, but will prompt you to make sure.
- Add Find/Replace
  - Adds this Find/Replace action to the Find/Replace list

These Find/Replace actions are done in the order they appear in the Filter List. So if you have "Inactive -> F" at the top of the list, followed by "Active -> T" under it... then the first find/replace that runs is the Inactive replace, followed by the Active replace.

### Generate Button
Generates the SQL from the raw SQL and columns you provided, and places the results into your copy buffer.

### Generate File...
Generates the SQL from the raw SQL and columns you provided, and prompts the user to select a location to save this SQL into a file.

### SQL Tab
Holds the SQL generated when you clicked one of the Generate buttons. Useful if you want to copy the SQL later, there is a Copy SQL button provided.

### Log Tab
Logs any problematic data found during SQL Generation. Provides a Copy Log button if you want to send this Log to someone else so they can correct the Excel Document.
