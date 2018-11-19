﻿using System.Security.Cryptography.X509Certificates;

namespace DelegateAndEventExample
{
    internal class SimpleMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}