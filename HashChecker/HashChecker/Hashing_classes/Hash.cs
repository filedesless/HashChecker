using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;

namespace HashChecker.Hashing_classes
{
    /// <summary>
    /// Provides child classes a method to asynchronously compute the checksum of a file by its path
    /// Reads the file as a stream (4k at a time) and report percentage of completion
    /// </summary>
    abstract class Hash
    {
        byte[] buffer;
        byte[] oldBuffer;
        int bytesRead;
        int oldBytesRead;
        long fileSize;
        long totalBytesRead;
        int bufferSize = 1024 * 1024;
        BackgroundWorker backgroundWorker;
        HashAlgorithm hashAlgorithm;

        /// <summary>
        /// Set the background job and algorithm to use
        /// </summary>
        /// <param name="bg">The background task it should run in</param>
        /// <param name="ha">The algorithm to use (md5, sha1), should be specified by child classes</param>
        protected Hash(BackgroundWorker bg, HashAlgorithm ha)
        {
            backgroundWorker = bg;
            hashAlgorithm = ha;
        }
        /// <summary>
        /// Computes a digest asynchronously, while reporting completion percentage to backgroundWorker job
        /// </summary>
        /// <param name="filename">Full path of the file to computer the hash for</param>
        /// <returns>Human readable string of the checksum</returns>
        public string digest(string filename)
        {
            // Open file stream
            using (Stream fileStream = File.OpenRead(filename))
            {
                fileSize = fileStream.Length;

                buffer = new byte[bufferSize];

                // Read first bytes from buffer
                bytesRead = fileStream.Read(buffer, 0, buffer.Length);
                totalBytesRead += bytesRead;

                do
                {
                    // Keep the bytes around
                    oldBytesRead = bytesRead;
                    oldBuffer = buffer;

                    // Fetch new bytes into buffer
                    buffer = new byte[bufferSize];
                    bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                    totalBytesRead += bytesRead;

                    if (bytesRead != 0) // If data has been read, computes oldBuffer and loop
                    {
                        hashAlgorithm.TransformBlock(oldBuffer, 0, oldBytesRead, oldBuffer, 0);
                        backgroundWorker.ReportProgress((int)((double)totalBytesRead * 100 / fileSize));
                    }
                    else // final block, compute old buffer which is likely smaller than bufferSize in length
                    {
                        hashAlgorithm.TransformFinalBlock(oldBuffer, 0, oldBytesRead);
                        backgroundWorker.ReportProgress(100, BitConverter.ToString(hashAlgorithm.Hash).Replace("-", ""));
                    }

                    if (backgroundWorker.CancellationPending)
                        return "";
                } while (bytesRead != 0);

                return BitConverter.ToString(hashAlgorithm.Hash).Replace("-", "");
            }
        }
    }
}
