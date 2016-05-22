using System.ComponentModel;
using System.Security.Cryptography;

namespace HashChecker.Hashing_classes
{
    class HashSHA1 : Hash
    {
        public HashSHA1(BackgroundWorker bg) : base(bg, SHA1.Create()) { }

    }
}
