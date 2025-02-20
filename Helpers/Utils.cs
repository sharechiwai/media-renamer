using System.Text.RegularExpressions;

namespace Media_Renamer.Helpers
{
    public static class Utils
    {
        /// <summary>
        /// Some filename already stored a date taken format, 
        /// e.g. Samsung
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>boolean</returns>
        public static bool IsValidFilenameFormatWithDate(string filename)
        {
            // Regex pattern for yyyyMMdd_HHmmss
            string pattern = @"^\d{8}_\d{6}";

            // Check if the filename matches the pattern
            return Regex.IsMatch(Path.GetFileNameWithoutExtension(filename), pattern);
        }
    }
}
