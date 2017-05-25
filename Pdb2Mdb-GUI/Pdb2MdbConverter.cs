using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pdb2Mdb;

namespace Pdb2Mdb_GUI
{
    public static class Pdb2MdbConverter
    {
        public static List<string> GetNetResourcePaths(IEnumerable<string> paths)
        {
            List<string> netPaths = new List<string>();

            foreach (string path in paths)
            {
                FileAttributes attr = File.GetAttributes(path);

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    // Path is a directory.

                    // We do not recursively convert. This is intentional.
                    foreach (string subFile in Directory.EnumerateFiles(path))
                        if (IsNetResource(subFile))
                            netPaths.Add(subFile);
                }
                else
                {
                    // Path is a file.

                    if (IsNetResource(path))
                        netPaths.Add(path);
                }
            }

            return netPaths;
        }

        private static bool IsNetResource(string path)
        {
            string fileExtension = Path.GetExtension(path);
            return (fileExtension == ".dll" || fileExtension == ".exe");
        }

        public static async Task<ConversionResult> ConvertNetResourceAsync(string path)
        {
            ConversionResult result = new ConversionResult { Path = path };

            try
            {
                await Task.Run(() => Converter.Convert(path));
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex;
            }

            return result;
        }

        public class ConversionResult
        {
            public string Path { get; set; }
            public bool Success { get; set; }
            public Exception Error { get; set; }
        }
    }
}
