using System;

namespace VerifyThat
{
    public static class Verify
    {
        public static bool equals(string p1, string p2) => p1 == p2;

        public static bool equals(string p1, int p2) => Int32.Parse(p1) == p2;

        public static bool That<T>(string s, Func<string, T, bool> g, T value) =>
            g(s, value);
    }
}
