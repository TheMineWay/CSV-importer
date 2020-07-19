/*


        TheMineWay: CSV IMPORTER
        https://themineway.com
        VERSION 1.0.0


 */ 
using System.Collections.Generic;

public class CSV_IMPORTER
{
    public static List<string[]> ImportCSV(string rawInput)
    {
        List<string[]> outputList = new List<string[]>();
        foreach (string line in rawInput.Split('\n'))
        {
            List<string> _temp = new List<string>();
            _temp.Add("");
            bool inside = false;
            for (int n = 0; n < line.Length; n++)
            {
                if (line[n] == '"')
                {
                    if (n == 0)
                        inside = !inside;
                    else if (line[n - 1] == '\\')
                    {
                        _temp[_temp.Count - 1] = _temp[_temp.Count - 1].Remove(_temp[_temp.Count - 1].Length - 1);
                        _temp[_temp.Count - 1] += '"';
                    }
                    else
                        inside = !inside;
                }
                else if (inside)
                    _temp[_temp.Count - 1] += line[n];
                else if (line[n] == ',')
                    _temp.Add("");
            }
            outputList.Add(_temp.ToArray());
        }
        return outputList;
    }
}