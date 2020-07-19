# CSV-importer
You can simply import a CSV file to your project by using this code.

You have to call the ImportCSV List with the CSV text as a parameter. Then, it will return a List<string[]>:

List<string[]> csv = CSV_IMPORTER.ImportCSV("CSV TEXT");

The csv List contains the CSV file:

Every element of the List contains an string[], which represents every line of the original file. The string[] value represents every cell in the line (List element).

Example:

"1_1","1_2","1_3","1_4"
"2_1","2_2","2_3","2_4"
"3_1","3_2","3_3","3_4"
"4_1","4_2"
"4_1","4_2","4_3","4_4"

If we pass the previous text it will return a List<string[]>, let's call it "convertedFile".
Now, if we access the second element of the List ( convertedFile[1] ), we will get the following array: { "2_1","2_2","2_3","2_4" }.
We can now access a cell (for example the 2nd) by doing ( convertedFile[1][2] ). This will retrieve us "2_2".

NOTE:
If a line is shorter than the others, the array is shorter. There is no problem, as you saw on the example.
