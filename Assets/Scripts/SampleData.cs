using System;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Scripts
{
    internal class SampleData
    {
        public static Union[] CreateData()
        {
            const int N = 10;

            var rand = new Random();
            var chars = range('a', 'z').Concat(range('A', 'Z')).ToArray();

            var items = new Union[N];

            for (int loop = 0; loop < N; loop++) // 無駄に N 回上書き
            {
                for (int i = 0; i < N; i++)
                {
                    items[i] = getUnion();
                }
            }

            return items;

            Union getUnion()
            {
                var i = rand.Next(0, 4);

                switch (i % 4)
                {
                    case 0: return new Union.A { Id = getI(), Name = getS() };
                    case 1: return new Union.B { X = getF(), Y = getF(), Z = getF(), Tag = getS() };
                    case 2: return new Union.C { M0 = getB(), M1 = getB(), M2 = getB(), M3 = getB(), M4 = getB(), M5 = getB() };
                    default: return new Union.D { Data1 = getS(), XY = new Pair(getS(), getS()) };
                };
            }

            IEnumerable<char> range(char a, char b)
            {
                for (var i = a; i <= b; ++i)
                {
                    yield return i;
                }
            }

            string getS()
            {
                var buffer = new char[rand.Next(0, 20)];

                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] = chars[rand.Next(0, chars.Length)];
                }

                return new string(buffer);
            }

            byte getB() => (byte)rand.Next();
            int getI() => rand.Next();
            float getF() => (float)rand.NextDouble();
        }
    }
}
