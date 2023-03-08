using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte maxsbyte = sbyte.MaxValue;
            sbyte minsbyte = sbyte.MinValue;

            Console.WriteLine($"Max possible sbyte value: {maxsbyte}");
            Console.WriteLine($"Min possible sbyte value: {minsbyte}");

            byte maxbyte = byte.MaxValue;
            byte minbyte = byte.MinValue;

            Console.WriteLine($"Max possible byte value: {maxbyte}");
            Console.WriteLine($"Min possible byte value: {minbyte}");

            short maxshort = short.MaxValue;
            short minshort = short.MinValue;

            Console.WriteLine($"Max possible short value: {maxshort}");
            Console.WriteLine($"Min possible short value: {minshort}");

            ushort maxushort = ushort.MaxValue;
            ushort minushort = ushort.MinValue;

            Console.WriteLine($"Max possible ushort value: {maxushort}");
            Console.WriteLine($"Min possible ushort value: {minushort}");

            int maxint = int.MaxValue;
            int minint = int.MinValue;

            Console.WriteLine($"Max possible int value: {maxint}");
            Console.WriteLine($"Min possible int value: {minint}");

            uint maxuint = uint.MaxValue;
            uint minuint = uint.MinValue;

            Console.WriteLine($"Max possible uint value: {maxuint}");
            Console.WriteLine($"Min possible uint value: {minuint}");

            long maxlong = long.MaxValue;
            long minlong = long.MinValue;

            Console.WriteLine($"Max possible long value: {maxlong}");
            Console.WriteLine($"Min possible long value: {minlong}");

            ulong maxulong = ulong.MaxValue;
            ulong minulong = ulong.MinValue;

            Console.WriteLine($"Max possible ulong value: {maxulong}");
            Console.WriteLine($"Min possible ulong value: {minulong}");

            float maxfloat = float.MaxValue;
            float minfloat = float.MinValue;

            Console.WriteLine($"Max possible float value: {maxfloat}");
            Console.WriteLine($"Min possible float value: {minfloat}");

            double maxdouble = double.MaxValue;
            double mindouble = double.MinValue;

            Console.WriteLine($"Max possible double value: {maxdouble}");
            Console.WriteLine($"Min possible double value: {mindouble}");

            float f_plusinfinity = float.PositiveInfinity;
            float f_minusinfinity = float.NegativeInfinity;
            float f_NaN = float.NaN;

            Console.WriteLine($"+Infinity in float: {f_plusinfinity}");
            Console.WriteLine($"-Infinity in float: {f_minusinfinity}");
            Console.WriteLine($"NaN in float: {f_NaN}");

            double d_plusinfinity = double.PositiveInfinity;
            double d_minusinfinity = double.NegativeInfinity;
            double d_NaN = double.NaN;

            Console.WriteLine($"+Infinity in double: {d_plusinfinity}");
            Console.WriteLine($"-Infinity in double: {d_minusinfinity}");
            Console.WriteLine($"NaN in double: {d_NaN}");

        }
    }
}
