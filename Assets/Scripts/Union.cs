using System.Runtime.InteropServices;

namespace Assets.Scripts
{
    struct Union
    {
        public UnionType Type { get; }
        public Inner Data;

        public Union(A x) : this() { Data.A = x; Type = UnionType.A; }
        public Union(B x) : this() { Data.B = x; Type = UnionType.B; }
        public Union(C x) : this() { Data.C = x; Type = UnionType.C; }
        public Union(D x) : this() { Data.D = x; Type = UnionType.D; }

        public static implicit operator Union(A x) => new Union(x);
        public static implicit operator Union(B x) => new Union(x);
        public static implicit operator Union(C x) => new Union(x);
        public static implicit operator Union(D x) => new Union(x);

        public override string ToString()
        {
            switch (Type)
            {
                case UnionType.A: return Data.A.ToString();
                case UnionType.B: return Data.B.ToString();
                case UnionType.C: return Data.C.ToString();
                case UnionType.D: return Data.D.ToString();
                default: return "None";
            };
        }

        public enum UnionType : byte { None, A, B, C, D }

        [StructLayout(LayoutKind.Explicit)]
        public struct Inner
        {
            [FieldOffset(0)] public A A;
            [FieldOffset(0)] public B B;
            [FieldOffset(0)] public C C;
            [FieldOffset(0)] public D D;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct A
        {
            public int Id;
            public string Name;
            public override string ToString() => $"A({Id}, {Name})";

#pragma warning disable CS0169, IDE0044, IDE0051
            private string _dummy0;
#pragma warning restore
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct B
        {
            public float X;
            public float Y;
            public float Z;
            public string Tag;
            public override string ToString() => $"B({X}, {Y}, {Z}, {Tag})";

#pragma warning disable CS0169, IDE0044, IDE0051
            private string _dummy0;
#pragma warning restore
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct C
        {
            public byte M0;
            public byte M1;
            public byte M2;
            public byte M3;
            public byte M4;
            public byte M5;
            public override string ToString() => $"C({M0}, {M1}, {M2}, {M3}, {M4}, {M5})";

#pragma warning disable CS0169, IDE0044, IDE0051
            private string _dummy0;
            private string _dummy1;
#pragma warning restore
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct D
        {
            public object Data1;
            public Pair XY;
            public override string ToString() => $"D({Data1}, ({XY.X}, {XY.Y}))";
        }
    }
}
