using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FolderApp
{
    class Serialization
    {
        /// <summary>
        ///     Method, that creates one file with all folderTree data.
        ///     BinaryFormatter is used.
        /// </summary>
        /// <param name="folderTree">Data to be written</param>
        /// <param name="path">path to new file</param>
        public static void Serialize(FolderTree folderTree, string path)
        {

            // To serialize the hashtable and its key/value pairs,  
            // you must first open a stream for writing. 
            // In this case, use a file stream.
            FileStream fs = new FileStream(path, FileMode.Create);
            
            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, folderTree);
            }
            catch (SerializationException e)
            {
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        /// <summary>
        ///     Method, that reads data from serialized file.
        /// </summary>
        /// <param name="path">path to serialized file.</param>
        /// <returns>File's data as FolderTree.</returns>
        public static FolderTree Deserialize(string path)
        {
            // Declare the FileStream reference.
            FolderTree folder = null;

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream(path, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the hashtable from the file and 
                // assign the reference to the local variable.
                folder = (FolderTree)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                throw;
            }
            finally
            {
                fs.Close();
            }

            return folder;
        }
    }
}
