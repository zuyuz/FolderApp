using System;
using System.Collections.Generic;
using System.IO;
namespace FolderApp
{
    [Serializable]
    public class FolderTree
    {
        #region Fields

        string path;
        List<FolderTree> subFolders;
        List<File> subFiles;

        #endregion


        #region Properties

        /// <summary>
        ///     Physical path to file.
        /// </summary>
        public string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }
        /// <summary>
        ///     List of all folder's subfolders.
        /// </summary>
        public List<FolderTree> SubFolders
        {
            get
            {
                return subFolders;
            }

            set
            {
                subFolders = value;
            }
        }
        /// <summary>
        ///     List of all folder's subfiles.
        /// </summary>
        public List<File> SubFiles
        {
            get
            {
                return subFiles;
            }

            set
            {
                subFiles = value;
            }
        }

        #endregion


        #region Constructors
        /// <summary>
        ///     Constructor, that writes path to folder,
        ///     initializes subFiles and subFolders lists.
        /// </summary>
        /// <param name="p"></param>
        public FolderTree(string p)
        {
            path = p;
            subFiles = new List<File>();
            subFolders = new List<FolderTree>();
        }
        #endregion
    }

    [Serializable]
    public class File
    {
        #region Fields

        string path;
        byte[] fileInBytes;

        #endregion


        #region Properties

        /// <summary>
        ///     Physical path to file.
        /// </summary>
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }

        /// <summary>
        ///     Byte representation of file.
        /// </summary>
        public byte[] FileInBytes
        {
            get
            {
                return fileInBytes;
            }
            set
            {
                fileInBytes = value;
            }
        }

        #endregion


        #region Constructors

        /// <summary>
        ///     Constructor writes given path and copies all files bytes.
        /// </summary>
        /// <param name="path">Path to file.</param>
        public File(string path)
        {
            this.path = path;
            fileInBytes = System.IO.File.ReadAllBytes(path);
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Method, that iterate over FolderTree, and return Subfolder
        ///     with given name, if it exists, or null, if not or no element
        ///     with such name.
        /// </summary>
        /// <param name="p">path to search on.</param>
        /// <param name="folderTree">Folder's tree represantation</param>
        /// <returns></returns>
        public static FolderTree GetVertexByPath(string p, FolderTree folderTree)
        {
            if(folderTree == null)
            {
                return null;
            }

            foreach(var i in folderTree.SubFolders)
            {
                if(i.Path == p)
                {
                    return i;
                }
            }
            foreach (var i in folderTree.SubFolders)
            {
                return GetVertexByPath(p, i);
            }

            return null;
        }

        #endregion
    }
}
