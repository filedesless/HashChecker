namespace HashChecker.Utilities
{
    static class file_struct
    {
        public static string name;
        public static string md5;
        public static string sha1;
        public static string sha256;
        public static string sha512;

        public static void clear()
        {
            name = md5 = sha1 = sha256 = sha512 = "";
        }
    }
}
