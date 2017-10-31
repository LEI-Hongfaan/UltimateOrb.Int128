using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using FsCheck;
using FsCheck.Xunit;

namespace UltimateOrb.Int128.Tests {

    public class UnitTests {
        public static System.Numerics.BigInteger Int64ArrayToBigInteger(params Int64[] bits) {
            var c = bits.Length;
            if (c > 1) {
                var a = (System.Numerics.BigInteger)unchecked((Int64)bits[--c]);
                for (; c > 0;) {
                    a = (a << 64) | unchecked((UInt64)bits[--c]);
                }
                return a;
            }
            if (1 == c) {
                return bits[0];
            }
            return default(System.Numerics.BigInteger);
        }

        public static System.Numerics.BigInteger UInt64ArrayToBigInteger(params UInt64[] bits) {
            return Int64ArrayToBigInteger(((object)bits) as Int64[]);
        }

        public static System.Numerics.BigInteger Int64ArrayToBigIntegerUnsigned(params Int64[] bits) {
            var c = bits.Length;
            if (c > 1) {
                var a = (System.Numerics.BigInteger)unchecked((UInt64)bits[--c]);
                for (; c > 0;) {
                    a = (a << 64) | unchecked((UInt64)bits[--c]);
                }
                return a;
            }
            if (1 == c) {
                return bits[0];
            }
            return default(System.Numerics.BigInteger);
        }

        public static System.Numerics.BigInteger UInt64ArrayToBigIntegerUnsigned(params UInt64[] bits) {
            return Int64ArrayToBigIntegerUnsigned(((object)bits) as Int64[]);
        }

        [Property]
        public bool Test_GCD_1(Tuple<ulong, ulong, ulong, ulong> a) {
            var m0 = a.Item1;
            var m1 = a.Item2;
            var n0 = a.Item3;
            var n1 = a.Item4;
            var mm = UInt128.FromBits(m0, m1);
            var nn = UInt128.FromBits(n0, n1);
            var dd = UInt128.EuclideanAlgorithm.GreatestCommonDivisor(mm, nn);

            var m = UInt64ArrayToBigIntegerUnsigned(m0, m1);
            var n = UInt64ArrayToBigIntegerUnsigned(n0, n1);

            var p = System.Numerics.BigInteger.GreatestCommonDivisor(m, n);
            var d = UInt64ArrayToBigIntegerUnsigned(unchecked((ulong)dd.LoInt64Bits), unchecked((ulong)dd.HiInt64Bits));
            return p == d;
        }
    }
}
