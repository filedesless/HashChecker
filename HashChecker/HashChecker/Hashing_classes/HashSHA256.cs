using System.ComponentModel;
using System.Security.Cryptography;

namespace HashChecker.Hashing_classes
{
    class HashSHA256 : Hash
    {
        public HashSHA256(BackgroundWorker bg) : base(bg, SHA256.Create()) { }

    }
}
