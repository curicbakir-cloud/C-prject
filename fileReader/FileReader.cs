using System;
using System.IO;
using System.Text;

namespace FileReaderApp
{
    public class FileReader
    {
        public static string ReadFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found.", filePath);

            return File.ReadAllText(filePath);
        }

        public static List<string>ConvertFileToList(string filePath){
            return [.. File.ReadAllLines(filePath)];
        }
        public static string GetSpecificColumn(List<string> linesOfFile, int columnNum)
        {
            var result = new StringBuilder();
            foreach (var line in linesOfFile)
            {
            var columns = line.Split(',');
            if (columnNum >= 0 && columnNum < columns.Length)
            {
                result.Append(columns[columnNum]);
                result.AppendLine();
            }
            }
            return result.ToString().Trim();
        }
    }
}