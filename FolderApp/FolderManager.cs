using System;
using System.IO;
using System.Collections;

namespace FolderApp
{
    class FolderManager
    {
        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory, FolderTree folderTree)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                folderTree.SubFiles.Add(new File(fileName));
                ProcessFile(fileName);
            }

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                FolderTree folder = new FolderTree(subdirectory);
                folderTree.SubFolders.Add(folder);
                ProcessDirectory(subdirectory, folder);
            }
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }
    }
}
