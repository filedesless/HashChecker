using System.ComponentModel;
using System.Security.Cryptography;

namespace HashChecker.Hashing_classes
{
    class HashSHA512 : Hash
    {
        public HashSHA512(BackgroundWorker bg) : base(bg, SHA512.Create()) { }

    }
}
