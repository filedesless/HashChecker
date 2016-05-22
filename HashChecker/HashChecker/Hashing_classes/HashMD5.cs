using System.ComponentModel;
using System.Security.Cryptography;

namespace HashChecker.Hashing_classes
{
    class HashMD5 : Hash
    {
        public HashMD5(BackgroundWorker bg) : base(bg, MD5.Create()) { }

    }
}
