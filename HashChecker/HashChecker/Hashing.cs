using System.ComponentModel;
using HashChecker.Hashing_classes;
using System.Windows.Forms;

namespace HashChecker
{

    /// <summary>
    /// Intermediary class for managing the file hashing background task
    /// </summary>
    class Hashing
    {
        private BackgroundWorker task;
        private string filename;

        /// <summary>
        /// Set the background job to report to and the file to hash
        /// </summary>
        /// <param name="bg">Background task to report progress to</param>
        /// <param name="filePath">Full path of the file to hash</param>
        public Hashing(BackgroundWorker bg, string filePath)
        {
            task = bg;
            filename = filePath;
        }

        /// <summary>
        /// Computes md5 of the file
        /// </summary>
        /// <returns>The human readable MD5 checksum of the file</returns>
        public string md5()
        {
            Hash h = new HashMD5(task);
            return h.digest(filename);
        }

        /// <summary>
        /// Computes SHA1 of the file
        /// </summary>
        /// <returns>The human readable SHA1 checksum of the file</returns>
        public string sha1()
        {
            Hash h = new HashSHA1(task);
            return h.digest(filename);
        }

        /// <summary>
        /// Computes SHA256 of the file
        /// </summary>
        /// <returns>The human readable SHA256 checksum of the file</returns>
        public string sha256()
        {
            Hash h = new HashSHA256(task);
            return h.digest(filename);
        }

        /// <summary>
        /// Computes SHA512 of the file
        /// </summary>
        /// <returns>The human readable SHA512 checksum of the file</returns>
        public string sha512()
        {
            Hash h = new HashSHA512(task);
            return h.digest(filename);
        }

    }
}
