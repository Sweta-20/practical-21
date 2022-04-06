using System;

namespace Practical_21
{
    class Program
    {
        public static void Main(string[] args)
        {
            Singleton.Instance.Show();
            Singleton.Instance.Show();
        }
    }
}
