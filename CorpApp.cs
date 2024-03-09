using System;
using System.Diagnostics;
using System.IO;

namespace CorpApp
{
    class ProcessMonitor
    {
        static void Main()
        {
            // Specify the directory where the output file will be saved
            string outputDirectory = @"C:\Users\Public";
            // Specify the filename for the output file
            string outputFile = "RunningProcesses.txt";
            // Combine the directory and filename to get the full path
            string outputPath = Path.Combine(outputDirectory, outputFile);

            try
            {
                // Get the list of currently running processes
                Process[] processes = Process.GetProcesses();

                // Write the list of processes to the output file
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    writer.WriteLine("List of Running Processes:");
                    foreach (Process process in processes)
                    {
                        writer.WriteLine($"Process Name: {process.ProcessName}, ID: {process.Id}");
                    }
                }

                Console.WriteLine($"List of running processes has been saved to {outputPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
