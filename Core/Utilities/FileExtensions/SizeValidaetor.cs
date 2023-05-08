
namespace Core.Utilities.FileExtensions
{
    public static class SizeValidaetor
    {
        public static bool Size1mgIsValid(long len)
        {
            var maxSize = 1120000;
            if (len > maxSize)
                return false;

            return true;
        }

        public static bool Size2mgIsValid(long len)
        {
            var maxSize = 2120000;
            if (len > maxSize)
                return false;

            return true;
        }

        public static bool Size3mgIsValid(long len)
        {
            var maxSize = 3120000;
            if (len > maxSize)
                return false;

            return true;
        }

        public static bool Size4mgIsValid(long len)
        {
            var maxSize = 4120000;
            if (len > maxSize)
                return false;

            return true;
        }

        public static bool Size5mgIsValid(long len)
        {
            var maxSize = 5120000;
            if (len > maxSize)
                return false;

            return true;
        }

        public static bool Size6mgIsValid(long len)
        {
            var maxSize = 6120000;
            if (len > maxSize)
                return false;

            return true;
        }

        public static bool Size7mgIsValid(long len)
        {
            var maxSize = 7120000;
            if (len > maxSize)
                return false;

            return true;
        }

        public static bool Size8mgIsValid(long len)
        {
            var maxSize = 8120000;
            if (len > maxSize)
                return false;

            return true;
        }

        public static bool Size9mgIsValid(long len)
        {
            var maxSize = 9120000;
            if (len > maxSize)
                return false;

            return true;
        }

        public static bool Size10mgIsValid(long len)
        {
            var maxSize = 10720000;
            if (len > maxSize)
                return false;

            return true;
        }

        public static bool Size20mgIsValid(long len)
        {
            var maxSize = 20720000;
            if (len > maxSize)
                return false;

            return true;
        }

        public static bool Size30mgIsValid(long len)
        {
            var maxSize = 30720000;
            if (len > maxSize)
                return false;

            return true;
        }
    }
}
