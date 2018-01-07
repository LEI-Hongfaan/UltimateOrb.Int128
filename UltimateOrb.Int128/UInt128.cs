using Internal;
using System;
using System.Diagnostics;

namespace UltimateOrb {
    using static global::Internal.System.IConvertibleModule;
    using static global::Internal.System.Converter;
    using static UltimateOrb.Utilities.ThrowHelper;

    using MathEx = UltimateOrb.Mathematics.DoubleArithmetic;

    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Interoperability", "CA1413:AvoidNonpublicFieldsInComVisibleValueTypes")]
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.SerializableAttribute()]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 16)]
    public partial struct UInt128 : IEquatable<UInt128>, IComparable<UInt128>
#if FEATURE_STANDARD_LIBRARY_INTEROPERABILITY_FORMATTING_AND_CONVERSION
        , IConvertible, IFormattable
#endif
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly UInt64 lo;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly UInt64 hi;

        [System.Diagnostics.Contracts.PureAttribute()]
        public Int64 LoInt64Bits {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return unchecked((Int64)this.lo);
            }
        }

        [System.Diagnostics.Contracts.PureAttribute()]
        public Int64 HiInt64Bits {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return unchecked((Int64)this.hi);
            }
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        internal UInt128(UInt64 lo, UInt64 hi) {
            this.lo = lo;
            this.hi = hi;
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 FromBits(Int64 lo, Int64 hi) {
            return new UInt128(unchecked((UInt64)lo), unchecked((UInt64)hi));
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 FromBits(UInt64 lo, UInt64 hi) {
            return new UInt128(unchecked((UInt64)lo), unchecked((UInt64)hi));
        }

        #region Standard values
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Zero {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return default(UInt128);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool IsZero {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return 0 == this.lo && 0 == this.hi;
            }
        }

        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 One {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return new UInt128(1, 0);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool IsOne {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return 1 == this.lo && 0 == this.hi;
            }
        }

        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Two {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return new UInt128(2, 0);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool IsTwo {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return 2 == this.lo && 0 == this.hi;
            }
        }

        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 MaxValue {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return new UInt128(UInt64.MaxValue, UInt64.MaxValue);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool IsMaxValue {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return UInt64.MaxValue == this.lo && UInt64.MaxValue == this.hi;
            }
        }

        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 MinValue {
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return new UInt128(UInt64.MinValue, UInt64.MinValue);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool IsMinValue {
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return UInt64.MinValue == this.lo && UInt64.MinValue == this.hi;
            }
        }
        #endregion

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool IsEven {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return 0 == (this.lo & 1);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool IsNegative {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return false;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public int Sign {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return (this.lo == 0 && this.hi == 0) ? 0 : 1;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool CanConvertToUInt64 {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return 0 == this.hi;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool CanConvertToUInt32 {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return CanConvertToUIntN(32);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool CanConvertToUInt16 {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            get {
                return CanConvertToUIntN(16);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "n")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool CanConvertToUIntN(int n) {
            if (n < 128) {
                if (n > 0) {
                    if (n <= 64) {
                        if (64 < n) {
                            return 0 == this.hi && 0 == this.lo >> (64 - n);
                        }
                        return this.CanConvertToUInt64;
                    }
                    return 0 == this.hi >> (128 - n);
                }
                return this.IsZero;
            }
            return true;
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static int TestBit(UInt128 value, int index) {
            if (0 <= index && 128 > index) {
                if (index < 64) {
                    return 1 & unchecked((int)(value.lo >> index));
                }
                return 1 & unchecked((int)(value.hi >> index));
            }
            return 0;
        }

        #region Bitwise operations
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 OnesComplement(UInt128 value) {
            return new UInt128(~value.lo, ~value.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator ~(UInt128 value) {
            return new UInt128(~value.lo, ~value.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 BitwiseOr(UInt128 first, UInt128 second) {
            return new UInt128(first.lo | second.lo, first.hi | second.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator |(UInt128 first, UInt128 second) {
            return new UInt128(first.lo | second.lo, first.hi | second.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Xor(UInt128 first, UInt128 second) {
            return new UInt128(first.lo ^ second.lo, first.hi ^ second.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator ^(UInt128 first, UInt128 second) {
            return new UInt128(first.lo ^ second.lo, first.hi ^ second.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 BitwiseAnd(UInt128 first, UInt128 second) {
            return new UInt128(first.lo & second.lo, first.hi & second.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator &(UInt128 first, UInt128 second) {
            return new UInt128(first.lo & second.lo, first.hi & second.hi);
        }
        #endregion

        #region Shift operations        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator <<(UInt128 value, int count) {
            var lo = MathEx.ShiftLeft(value.lo, value.hi, count, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "op")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 op_LeftShift(UInt128 value) {
            var lo = MathEx.ShiftLeft(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator >>(UInt128 value, int count) {
            var lo = MathEx.ShiftRight(value.lo, value.hi, count, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "op")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 op_RightShift(UInt128 value) {
            var lo = MathEx.ShiftRight(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }
        #endregion

        #region Comparisons
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public bool Equals(UInt128 other) {
            return this.lo == other.lo && this.hi == other.hi;
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public override bool Equals(object obj) {
            if (obj is UInt128 value) {
                return this.Equals(value);
            }
            return base.Equals(obj);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        bool IEquatable<UInt128>.Equals(UInt128 other) {
            return this.lo == other.lo && this.hi == other.hi;
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public override int GetHashCode() {
            return HashCodeHelper.GetHashCode(this.lo ^ unchecked((UInt64)this.hi));
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public int CompareTo(UInt128 other) {
            return MathEx.Compare(this.lo, this.hi, other.lo, other.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        int IComparable<UInt128>.CompareTo(UInt128 other) {
            return MathEx.Compare(this.lo, this.hi, other.lo, other.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static bool operator ==(UInt128 first, UInt128 second) {
            return (first.lo == second.lo) && (first.hi == second.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static bool operator !=(UInt128 first, UInt128 second) {
            return !(first == second);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static int Compare(UInt128 first, UInt128 second) {
            return MathEx.Compare(first.lo, first.hi, second.lo, second.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static bool operator >(UInt128 first, UInt128 second) {
            return MathEx.GreaterThan(first.lo, first.hi, second.lo, second.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static bool operator >=(UInt128 first, UInt128 second) {
            return MathEx.GreaterThanOrEqual(first.lo, first.hi, second.lo, second.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static bool operator <(UInt128 first, UInt128 second) {
            return MathEx.LessThan(first.lo, first.hi, second.lo, second.hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static bool operator <=(UInt128 first, UInt128 second) {
            return MathEx.LessThanOrEqual(first.lo, first.hi, second.lo, second.hi);
        }
        #endregion

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public Int128 AsSigned() {
            return new Int128(unchecked((UInt64)this.lo), unchecked((Int64)this.hi));
        }

        #region Numeric Conversions
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static implicit operator UInt128(sbyte value) {
            return new UInt128(unchecked((UInt64)checked((byte)value)), 0);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static implicit operator UInt128(Int16 value) {
            return new UInt128(unchecked((UInt64)checked((UInt16)value)), 0);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static implicit operator UInt128(Int32 value) {
            return new UInt128(unchecked((UInt64)checked((UInt32)value)), 0);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static implicit operator UInt128(Int64 value) {
            return new UInt128(unchecked((UInt64)checked((UInt64)value)), 0);
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static implicit operator UInt128(byte value) {
            return new UInt128(unchecked((UInt64)value), 0);
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static implicit operator UInt128(UInt16 value) {
            return new UInt128(unchecked((UInt64)value), 0);
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static implicit operator UInt128(UInt32 value) {
            return new UInt128(unchecked((UInt64)value), 0);
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static implicit operator UInt128(UInt64 value) {
            return new UInt128(unchecked((UInt64)value), 0);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator sbyte(UInt128 value) {
            (checked(0 - value.hi)).Ignore(); // check overflow
            return checked((sbyte)value.lo);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator Int16(UInt128 value) {
            (checked(0 - value.hi)).Ignore(); // check overflow
            return checked((Int16)value.lo);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator Int32(UInt128 value) {
            (checked(0 - value.hi)).Ignore(); // check overflow
            return checked((Int32)value.lo);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator Int64(UInt128 value) {
            (checked(0 - value.hi)).Ignore(); // check overflow
            return checked((Int64)value.lo);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator byte(UInt128 value) {
            (checked(0 - unchecked((UInt64)value.hi))).Ignore(); // check overflow
            return checked((byte)value.lo);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator UInt16(UInt128 value) {
            (checked(0 - unchecked((UInt64)value.hi))).Ignore(); // check overflow
            return checked((UInt16)value.lo);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator UInt32(UInt128 value) {
            (checked(0 - unchecked((UInt64)value.hi))).Ignore(); // check overflow
            return checked((UInt32)value.lo);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator UInt64(UInt128 value) {
            (checked(0 - unchecked((UInt64)value.hi))).Ignore(); // check overflow
            return value.lo;
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static implicit operator double(UInt128 value) {
            const int BitSize = 64;
            const int ExponentBitSize = 11;
            const int ExponentBias = unchecked(checked((1 << (ExponentBitSize - 1))) - 1);
            const int SignBitSize = 1;
            const int FractionBitSize = checked(BitSize - SignBitSize - ExponentBitSize);

            var lo = value.lo;
            var hi = value.hi;
            if (0 != hi) {
                // var c = Mathematics.BinaryNumerals.CountLeadingZeros(unchecked((UInt64)hi));
                var c = 0;
                for (var tmp = hi; 0 <= unchecked((Int64)tmp); tmp <<= 1) {
                    unchecked {
                        ++c;
                    }
                }
                var s = unchecked((UInt64)(checked(128 - 1 + ExponentBias) - c)) << FractionBitSize;
                lo = MathEx.ShiftLeft(lo, hi, unchecked(1 + c), out hi);
                var lo0 = lo & unchecked(((UInt64)1 << checked(BitSize - FractionBitSize)) - 1);
                lo = MathEx.ShiftRightUnsigned(lo, hi, checked(BitSize - FractionBitSize), out hi);
                s |= hi;
                // IEEE Std 754-2008 roundTiesToEven
                if (unchecked((UInt64)Int64.MinValue) < lo || (unchecked((UInt64)Int64.MinValue) == lo && (lo0 > 0 || (lo0 == 0 && 0 != (1 & hi))))) {
                    s = unchecked(1 + s);
                }
                return BitConverter.Int64BitsToDouble(unchecked((Int64)s));
            }
            return unchecked((double)lo);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static implicit operator Single(UInt128 value) {
            const int BitSize = 64;
            const int ExponentBitSize = 11;
            const int ExponentBias = unchecked(checked((1 << (ExponentBitSize - 1))) - 1);
            const int SignBitSize = 1;
            const int FractionBitSize = checked(BitSize - SignBitSize - ExponentBitSize);

            const int BitSizeTo = 32;
            const int ExponentBitSizeTo = 8;
            const int ExponentBiasTo = unchecked(checked((1 << (ExponentBitSizeTo - 1))) - 1);
            const int SignBitSizeTo = 1;
            const int FractionBitSizeTo = checked(BitSizeTo - SignBitSizeTo - ExponentBitSizeTo);

            var lo = value.lo;
            var hi = value.hi;
            if (0 != hi) {
                if (hi < (((UInt64)1 << checked(1 + 1 + FractionBitSizeTo)) - 1) << checked(BitSize - (1 + 1 + FractionBitSizeTo))) {
                    // var c = Mathematics.BinaryNumerals.CountLeadingZeros(unchecked((UInt64)hi));
                    var c = 0;
                    for (var tmp = hi; 0 <= unchecked((Int64)tmp); tmp <<= 1) {
                        unchecked {
                            ++c;
                        }
                    }
                    var s = unchecked((UInt64)(checked(128 - 1 + ExponentBias) - c)) << FractionBitSize;
                    lo = MathEx.ShiftLeft(lo, hi, unchecked(1 + c), out hi);
                    var lo0 = lo & unchecked(((UInt64)1 << checked(BitSize - FractionBitSizeTo)) - 1);
                    lo = MathEx.ShiftRightUnsigned(lo, hi, checked(BitSize - FractionBitSizeTo), out hi);
                    // IEEE Std 754-2008 roundTiesToEven
                    if (unchecked((UInt64)Int64.MinValue) < lo || (unchecked((UInt64)Int64.MinValue) == lo && (lo0 > 0 || (lo0 == 0 && 0 != (1 & hi))))) {
                        unchecked {
                            ++hi;
                        }
                    }
                    s = unchecked(s + (hi << checked(FractionBitSize - FractionBitSizeTo)));
                    return unchecked((Single)BitConverter.Int64BitsToDouble(unchecked((Int64)s)));
                }
                return Single.PositiveInfinity;
            }
            // We cannot write "return (float)lo;" because of the double rounding issue.
            // See http://www.exploringbinary.com/double-rounding-errors-in-floating-point-conversions/ .
            return ToSingle(lo);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator UInt128(double value) {
            const int BitSize = 64;
            const int ExponentBitSize = 11;
            const int ExponentBias = unchecked(checked((1 << (ExponentBitSize - 1))) - 1);
            const int SignBitSize = 1;
            const int FractionBitSize = checked(BitSize - SignBitSize - ExponentBitSize);

            // const Int64 SignMask = unchecked((Int64)checked((Int64)1u << (ExponentBitSize + FractionBitSize)));
            const Int64 ExponentMask = unchecked((Int64)checked((((Int64)1u << ExponentBitSize) - 1u) << FractionBitSize));
            const Int64 FractionMask = unchecked((Int64)checked(((Int64)1u << FractionBitSize) - 1u));

            var b = BitConverter.DoubleToInt64Bits(value);
            var e = checked((int)(ExponentMask >> FractionBitSize)) & unchecked((int)(b >> FractionBitSize));
            if (e >= checked(ExponentBias - 1)) {
                b.ThrowOnNegative();
                checked(checked(ExponentBias - 1 + 128) - e).Ignore();
                {
                    e = unchecked(e - (FractionBitSize + ExponentBias));
                    var lo = unchecked((UInt64)(((Int64)1 << FractionBitSize) | (FractionMask & b)));
                    var hi = (UInt64)0;
                    if (e > 0) {
                        lo = MathEx.ShiftLeft(lo, hi, e, out hi);
                    } else if (e < 0) {
                        var ol = (UInt64)0;
                        ol = MathEx.ShiftRight(ol, lo, unchecked(-e), out lo);
                        if (unchecked((UInt64)Int64.MinValue) < ol || (unchecked((UInt64)Int64.MinValue) == ol && 0 != (1 & lo))) {
                            lo = unchecked(1 + lo);
                        }
                    }
                    if (0 > b) {
                        lo = MathEx.NegateUnchecked(lo, hi, out hi);
                    }
                    return new UInt128(lo, hi);
                }
            }
            return Zero;
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator UInt128(float value) {
            return (UInt128)unchecked((double)value);
        }

#if FEATURE_STANDARD_LIBRARY_INTEROPERABILITY_FORMATTING_AND_CONVERSION
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator global::System.Decimal(UInt128 value) {
            checked((UInt32)value.hi).Ignore(); // check overflow
            return new decimal(unchecked((Int32)(value.lo >> (32 * 0))), unchecked((Int32)(value.lo >> (32 * 1))), unchecked((Int32)(value.hi >> (32 * 0))), false, 0);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly UInt128[] PowersOf10 = GetPowersOf10();

        private static UInt128[] GetPowersOf10() {
            var lo = (UInt64)1;
            var hi = (UInt64)0;
            var r = new UInt128[39];
            for (var i = 1; r.Length > i; ++i) {
                lo = MathEx.MultiplyUnchecked(10, 0, lo, hi, out hi);
                r[i] = new UInt128(lo, hi);
            }
            return r;
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static explicit operator UInt128(global::System.Decimal value) {
            // TODO: Need a Cer.Success version?
            // TODO: Struct layout of global::System.Decimal may vary...
            var a = ((object)global::System.Decimal.GetBits(value)) as UInt32[]; // CLI actually allows such sign casts.
            var lo = a[0] | ((UInt64)a[1] << 32);
            var hi = (UInt64)a[2];
            var f = a[3];
            var scale = (f >> 16) & 0x1F;
            var d = PowersOf10[scale];
            lo = MathEx.DivRem(lo, hi, d.lo, d.hi, out UInt64 r_lo, out UInt64 r_hi, out hi);
            // Note: r <= (a[0] | ((UInt64)a[1] << 32), (Int64)a[2]) .
            //   ==> r: Left shift (as a multiplication) will not lead to an arithmetic overflow.
            r_lo = MathEx.ShiftLeft(r_lo, r_hi, out r_hi);
            var c = MathEx.Compare(d.lo, d.hi, r_lo, r_hi);
            // 'Banker's rounding' (same as IEEE Std 754-2008 roundTiesToEven)
            if (c > 0 || (0 == c && (0 != (1 & lo)))) {
                lo = MathEx.IncreaseUnsigned(lo, hi, out hi);
            }
            if (0 > f) {
                lo = MathEx.NegateUnsigned(lo, hi, out hi);
            }
            return new UInt128(lo, hi);
        }
#endif

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public byte[] ToBigIntegerByteArray() {
            var a = new byte[128 / 8 + 1];
            {
                var t = this.lo;
                var j = 0;
                for (var i = 0; (64 / 8) > i; ++i) {
                    a[(64 / 8) * j + i] = unchecked((byte)(t >> (8 * i)));
                }
            }
            {
                var t = this.hi;
                var j = 1;
                for (var i = 0; (64 / 8) > i; ++i) {
                    a[(64 / 8) * j + i] = unchecked((byte)(t >> (8 * i)));
                }
            }
            return a;
        }
        #endregion

        #region Basic arithmetic operations
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Plus(UInt128 value) {
            return value;
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator +(UInt128 value) {
            return value;
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Negate(UInt128 value) {
            var lo = MathEx.NegateSigned(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator -(UInt128 value) {
            var lo = MathEx.NegateSigned(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "op")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 op_UnaryNegationUnchecked(UInt128 value) {
            var lo = MathEx.NegateUnchecked(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Increase(UInt128 value) {
            var lo = MathEx.IncreaseSigned(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Increment(UInt128 value) {
            var lo = MathEx.IncreaseSigned(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator ++(UInt128 value) {
            var lo = MathEx.IncreaseSigned(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "op")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 op_IncrementUnchecked(UInt128 value) {
            var lo = MathEx.IncreaseUnchecked(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static UInt128 Decrease(UInt128 value) {
            var lo = MathEx.DecreaseSigned(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Decrement(UInt128 value) {
            var lo = MathEx.DecreaseSigned(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator --(UInt128 value) {
            var lo = MathEx.DecreaseSigned(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "op")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 op_DecrementUnchecked(UInt128 value) {
            var lo = MathEx.DecreaseUnchecked(value.lo, value.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Add(UInt128 first, UInt128 second) {
            var lo = MathEx.AddSigned(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator +(UInt128 first, UInt128 second) {
            var lo = MathEx.AddSigned(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "op")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 op_AdditionUnchecked(UInt128 first, UInt128 second) {
            var lo = MathEx.AddUnchecked(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Subtract(UInt128 first, UInt128 second) {
            var lo = MathEx.SubtractSigned(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator -(UInt128 first, UInt128 second) {
            var lo = MathEx.SubtractSigned(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "op")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 op_SubtractionUnchecked(UInt128 first, UInt128 second) {
            var lo = MathEx.SubtractUnchecked(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Multiply(UInt128 first, UInt128 second) {
            var lo = MathEx.MultiplySigned(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator *(UInt128 first, UInt128 second) {
            var lo = MathEx.MultiplySigned(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "op")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 op_MultiplyUnchecked(UInt128 first, UInt128 second) {
            var lo = MathEx.MultiplyUnchecked(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Div")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 DivRem(UInt128 first, UInt128 second, out UInt128 remainder) {
            var lo = MathEx.DivRem(first.lo, first.hi, second.lo, second.hi, out UInt64 remainder_lo, out UInt64 remainder_hi, out UInt64 hi);
            remainder = new UInt128(remainder_lo, remainder_hi);
            return new UInt128(lo, hi);
        }

        /*
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static (UInt128 Quotient, UInt128 Remainder) DivRem(UInt128 first, UInt128 second, out UInt128 remainder) {
            var lo = MathEx.DivRem(first.lo, first.hi, second.lo, second.hi, out UInt64 remainder_lo, out UInt64 remainder_hi, out UInt64 hi);
            return (new UInt128(lo, hi), new UInt128(remainder_lo, remainder_hi));
        }
        */

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Division(UInt128 first, UInt128 second) {
            var lo = MathEx.Divide(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "op")]
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 op_IntegerDivision(UInt128 first, UInt128 second) {
            var lo = MathEx.Divide(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 Remainder(UInt128 first, UInt128 second) {
            var lo = MathEx.Remainder(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }

        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        public static UInt128 operator %(UInt128 first, UInt128 second) {
            var lo = MathEx.Remainder(first.lo, first.hi, second.lo, second.hi, out UInt64 hi);
            return new UInt128(lo, hi);
        }
        #endregion

        #region IConvertible
#if FEATURE_STANDARD_LIBRARY_INTEROPERABILITY_FORMATTING_AND_CONVERSION
        TypeCode IConvertible.GetTypeCode() {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider) {
            return (0 != this).ToBoolean(provider);
        }

        Char IConvertible.ToChar(IFormatProvider provider) {
            if ((long)Char.MinValue <= this && this <= (long)Char.MaxValue) {
                return unchecked((Char)this.lo).ToChar(provider);
            }
            return ((long)Char.MinValue - 1).ToChar(provider); // Let the underlying standard libraries raise the exception.
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider) {
            if ((long)sbyte.MinValue <= this && this <= (long)sbyte.MaxValue) {
                return unchecked((sbyte)this.lo).ToSByte(provider);
            }
            return ((long)sbyte.MinValue - 1).ToSByte(provider); // Let the underlying standard libraries raise the exception.
        }

        byte IConvertible.ToByte(IFormatProvider provider) {
            if ((long)byte.MinValue <= this && this <= (long)byte.MaxValue) {
                return unchecked((byte)this.lo).ToByte(provider);
            }
            return ((long)byte.MinValue - 1).ToByte(provider); // Let the underlying standard libraries raise the exception.
        }

        Int16 IConvertible.ToInt16(IFormatProvider provider) {
            if ((long)Int16.MinValue <= this && this <= (long)Int16.MaxValue) {
                return unchecked((Int16)this.lo).ToInt16(provider);
            }
            return ((long)Int16.MinValue - 1).ToInt16(provider); // Let the underlying standard libraries raise the exception.
        }

        UInt16 IConvertible.ToUInt16(IFormatProvider provider) {
            if ((long)UInt16.MinValue <= this && this <= (long)UInt16.MaxValue) {
                return unchecked((UInt16)this.lo).ToUInt16(provider);
            }
            return ((long)UInt16.MinValue - 1).ToUInt16(provider); // Let the underlying standard libraries raise the exception.
        }

        Int32 IConvertible.ToInt32(IFormatProvider provider) {
            if ((long)Int32.MinValue <= this && this <= (long)Int32.MaxValue) {
                return unchecked((Int32)this.lo).ToInt32(provider);
            }
            return ((long)Int32.MinValue - 1).ToInt32(provider); // Let the underlying standard libraries raise the exception.
        }

        UInt32 IConvertible.ToUInt32(IFormatProvider provider) {
            if ((long)UInt32.MinValue <= this && this <= (long)UInt32.MaxValue) {
                return unchecked((UInt32)this.lo).ToUInt32(provider);
            }
            return ((long)UInt32.MinValue - 1).ToUInt32(provider); // Let the underlying standard libraries raise the exception.
        }

        Int64 IConvertible.ToInt64(IFormatProvider provider) {
            if (Int64.MinValue <= this && this <= Int64.MaxValue) {
                return unchecked((Int64)this.lo).ToInt64(provider);
            }
            return ((long)Int32.MinValue - 1).ToInt32(provider); // Let the underlying standard libraries raise the exception.
        }

        UInt64 IConvertible.ToUInt64(IFormatProvider provider) {
            if (UInt64.MinValue <= this && this <= UInt64.MaxValue) {
                return unchecked((UInt64)this.lo).ToUInt64(provider);
            }
            return ((long)UInt32.MinValue - 1).ToUInt32(provider); // Let the underlying standard libraries raise the exception.
        }

        Single IConvertible.ToSingle(IFormatProvider provider) {
            return ((Single)this).ToSingle(provider);
        }

        Double IConvertible.ToDouble(IFormatProvider provider) {
            return ((Double)this).ToDouble(provider);
        }

        Decimal IConvertible.ToDecimal(IFormatProvider provider) {
            return ((Decimal)this).ToDecimal(provider);
        }

        private static string getMessageForInvalidCastException(IFormatProvider provider) {
            try {
                ((Int64)(-1)).ToDateTime(provider).Ignore(); // Generate an InvalidCastException.
            } catch (InvalidCastException ex) {
                // Catch the InvalidCastException and extract the value of Message property.
                try {
                    // So everyone can use their language.
                    return ex.Message.Replace(nameof(Int64), nameof(Int128));
                } catch (Exception) {
                }
            } catch (Exception) {
            }
            return null;
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider) {
            throw new InvalidCastException(getMessageForInvalidCastException(provider));
        }

        string IConvertible.ToString(IFormatProvider provider) {
            return this.ToString(null, provider);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider) {
            if (null == conversionType) {
                throw new ArgumentNullException(nameof(conversionType));
            }
            // return Convert.DefaultToType((IConvertible)this, type, provider);
            throw new NotImplementedException();
        }
#endif
        #endregion

        /// <summary>
        ///     <para>Parses a unsigned integer.</para>
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        ///     <para>The Number must be in format <c>[1-9][0-9]*</c>.</para>
        /// </remarks>
        public static bool TryParseCStyleNormalizedU128(string s, out UInt128 result) {
            if (null != s && s.Length > 0) {
                var i = 0;
                var c = s[i++];
                UInt64 lo;
                UInt64 hi;
                var d = c - '0';
                if (0 < d && d < 10) {
                    lo = unchecked((uint)d);
                    hi = 0;
                    while (s.Length > i) {
                        c = s[i++];
                        d = c - '0';
                        if (0 > d || d >= 10) {
                            goto L_f;
                        }
                        // TODO: ...
                        try {
                            lo = MathEx.MultiplyUnsigned(lo, hi, 10, 0, out hi);
                            lo = MathEx.AddUnsigned(lo, hi, unchecked((uint)d), 0, out hi);
                        } catch (ArithmeticException ex) {
                            goto L_f;
                        }
                    }
                    if (s.Length == i) {
                        result = new UInt128(lo, hi);
                        return true;
                    }
                }
            }
            L_f:;
            System.Diagnostics.Contracts.Contract.ValueAtReturn(out result);
            return false;
        }

        public static bool TryParseCStyleNormalizedX128(string s, out UInt128 result) {
            if (null != s && s.Length > 0) {
                var i = 0;
                var c = s[i++];
                UInt64 lo;
                UInt64 hi;
                var d = c - '0';
                if ((0 < d && d < 10) || (17 <= d && d < 23)) {
                    if (10 <= d) {
                        d -= 7;
                    }
                    lo = unchecked((uint)d);
                    hi = 0;
                    while (s.Length > i) {
                        c = s[i++];
                        d = c - '0';
                        if ((0 > d || d >= 10) && (17 > d || d >= 23)) {
                            goto L_f;
                        }
                        if (10 <= d) {
                            d -= 7;
                        }
                        // TODO: ...
                        try {
                            {
                                var ignored = checked(0 - unchecked(hi >> (64 - 4)));
                            }
                            lo = MathEx.ShiftLeft(lo, hi, 4, out hi);
                            lo = MathEx.AddUnsigned(lo, hi, unchecked((uint)d), 0, out hi);
                        } catch (ArithmeticException ex) {
                            goto L_f;
                        }
                    }
                    if (s.Length == i) {
                        // TODO: ...
                        result = new UInt128(lo, hi);
                        return true;
                    }
                }
            }
            L_f:;
            System.Diagnostics.Contracts.Contract.ValueAtReturn(out result);
            return false;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static char[] buffer_ToStringCStyleU128 {

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            get {
                return Int128.buffer_ToStringCStyleI128;
            }
        }

        public string ToStringCStyleU128() {
            var buffer = buffer_ToStringCStyleU128;
            var lo = this.lo;
            var hi = unchecked((UInt64)this.hi);
            var i = buffer.Length;
            {
                UInt64 r_lo;
                UInt64 r_hi;
                do {
                    lo = MathEx.DivRem(lo, hi, 10, 0, out r_lo, out r_hi, out hi);
                    buffer[--i] = unchecked((char)('0' + r_lo));
                } while (0 != lo || 0 != hi);
            }
            return new string(buffer, i, buffer.Length - i);
        }

        public override string ToString() {
#if FEATURE_STANDARD_LIBRARY_INTEROPERABILITY_FORMATTING_AND_CONVERSION
            {
                return this.ToString(null, Globalization.CultureInfo.CurrentCulture);
            }
#endif
            {
#pragma warning disable CS0162 // Unreachable code detected
                return this.ToStringCStyleU128();
#pragma warning restore CS0162 // Unreachable code detected
            }
        }

#if FEATURE_STANDARD_LIBRARY_INTEROPERABILITY_FORMATTING_AND_CONVERSION
        public string ToString(IFormatProvider formatProvider) {
            return this.ToString(null, formatProvider);
        }

        public string ToString(string format, IFormatProvider formatProvider) {
            // TODO: ...
            {
                return this.ToStringCStyleU128();
            }
        }
#endif
    }
}

namespace UltimateOrb {
    using Internal;

    using static UltimateOrb.Utilities.ThrowHelper;

    using MathEx = UltimateOrb.Mathematics.DoubleArithmetic;

    public partial struct UInt128 {

        public static partial class Math {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 BigMul(UInt64 first, UInt64 second) {
                var lo = MathEx.BigMul(first, second, out UInt64 hi);
                return new UInt128(lo, hi);
            }

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 Pow(UInt128 @base, int exponent) {
                var lo = @base.lo;
                var hi = @base.hi;
                if (exponent > 0) {
                    var result_lo = (UInt64)1;
                    var result_hi = (UInt64)0;
                    for (; ; ) {
                        if (0 != (1 & exponent)) {
                            result_lo = MathEx.MultiplyUnsigned(result_lo, result_hi, lo, hi, out result_hi);
                        }
                        if (0 != (exponent >>= 1)) {
                            lo = MathEx.MultiplyUnsigned(lo, hi, lo, hi, out hi);
                            continue;
                        }
                        break;
                    }
                    return new UInt128(result_lo, result_hi);
                }
                if (0 == exponent || (1 == lo && 0 == hi)) {
                    return UInt128.One;
                }
                if (0 != lo || 0 != hi) {
                    // return 0;
                    return default(UInt128);
                }
                // throw DivideByZeroException
                return exponent / 0;
            }
        }

        public static partial class DoubleArithmetic {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 BigMul(UInt128 first, UInt128 second, out UInt128 result_hi) {
                var result_lo_lo = MathEx.BigMul(first.lo, first.hi, second.lo, second.hi, out UInt64 result_lo_hi, out UInt64 result_hi_lo, out UInt64 result_hi_hi);
                result_hi = new UInt128(result_hi_lo, result_hi_hi);
                return new UInt128(result_lo_lo, result_lo_hi);
            }
        }

        public static partial class BinaryNumerals {

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 NextPermutation(UInt128 value) {
                var lo = value.lo;
                var hi = value.hi;
                lo = MathEx.NextPermutation(lo, hi, out hi);
                return new UInt128(lo, hi);
            }
        }

        public static partial class EuclideanAlgorithm {

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 GreatestCommonDivisor(UInt128 first, UInt128 second) {
                System.Diagnostics.Contracts.Contract.Ensures((System.Diagnostics.Contracts.Contract.Result<ulong>() == 0u) == (System.Diagnostics.Contracts.Contract.OldValue(first) == 0u && System.Diagnostics.Contracts.Contract.OldValue(second) == 0u));
                System.Diagnostics.Contracts.Contract.Ensures(0u == System.Diagnostics.Contracts.Contract.Result<ulong>() || 0u == System.Diagnostics.Contracts.Contract.OldValue(first) % System.Diagnostics.Contracts.Contract.Result<ulong>());
                System.Diagnostics.Contracts.Contract.Ensures(0u == System.Diagnostics.Contracts.Contract.Result<ulong>() || 0u == System.Diagnostics.Contracts.Contract.OldValue(second) % System.Diagnostics.Contracts.Contract.Result<ulong>());
                unchecked {
                    var first_lo = first.lo;
                    var first_hi = first.hi;
                    var second_lo = second.lo;
                    var second_hi = second.hi;
                    if (0 == second_lo && 0 == second_hi) {
                        return first;
                    }
                    if (0 == first_lo && 0 == first_hi) {
                        return second;
                    }
                    if (MathEx.GreaterThan(first_lo, first_hi, second_lo, second_hi)) {
                        first_lo = MathEx.Remainder(first_lo, first_hi, second_lo, second_hi, out first_hi);
                        if (0 == first_lo && 0 == first_hi) {
                            return second;
                        }
                    } else {
                        second_lo = MathEx.Remainder(second_lo, second_hi, first_lo, first_hi, out second_hi);
                        if (0 == second_lo && 0 == second_hi) {
                            return first;
                        }
                    }
                    var c = 0;
                    for (; 0 == (1 & unchecked((uint)first_lo | (uint)second_lo));) {
                        unchecked {
                            ++c;
                        }
                        first_lo = MathEx.ShiftRight(first_lo, first_hi, out first_hi);
                        second_lo = MathEx.ShiftRight(second_lo, second_hi, out second_hi);
                    }
                    first_lo = GreatestCommonDivisorPartialStub0002(first_lo, first_hi, second_lo, second_hi, out first_hi);
                    first_lo = MathEx.ShiftLeft(first_lo, first_hi, c, out first_hi);
                    return new UInt128(first_lo, first_hi);
                }
            }

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            internal static ulong GreatestCommonDivisorPartialStub0001(ulong first_lo, ulong first_hi, ulong second_lo, ulong second_hi, out ulong result_hi) {
                System.Diagnostics.Contracts.Contract.Requires(0 != (1 & second_lo) && (second_hi > 0 || second_lo > 1u));
                unchecked {
                    var first_lo_ = first_lo;
                    var first_hi_ = first_hi;
                    var second_lo_ = second_lo;
                    var second_hi_ = second_hi;
                    if (0 == first_lo_ && 0 == first_hi_) {
                        result_hi = second_hi_;
                        return second_lo_;
                    }
                    while (0 == (1 & first_lo_)) {
                        first_lo_ = MathEx.ShiftRight(first_lo_, first_hi_, out first_hi_);
                    }
                    if (1 == first_lo_ && 0 == first_hi_) {
                        result_hi = 0;
                        return 1;
                    }
                    if (first_lo_ == second_lo_ && first_hi_ == second_hi_) {
                        result_hi = second_hi_;
                        return second_lo_;
                    } else if (MathEx.GreaterThan(first_lo_, first_hi_, second_lo_, second_hi_)) {
                        goto L_Gt;
                    }
                    L_Lt:;
                    if (0 != (2 & ((uint)first_lo_ ^ (uint)second_lo_))) {
                        var t_lo = first_lo_;
                        var t_hi = first_hi_;
                        t_lo = MathEx.ShiftRight(t_lo, t_hi, 2, out t_hi);
                        second_lo_ = MathEx.ShiftRight(second_lo_, second_hi_, 2, out second_hi_);
                        t_lo = MathEx.IncreaseUnchecked(t_lo, t_hi, out t_hi);
                        second_lo_ = MathEx.AddUnchecked(second_lo_, second_hi_, t_lo, t_hi, out second_hi_);
                    } else {
                        second_lo_ = MathEx.SubtractUnchecked(second_lo_, second_hi_, first_lo_, first_hi_, out second_hi_);
                        second_lo_ = MathEx.ShiftRight(second_lo_, second_hi_, 2, out second_hi_);
                    }
                    while (0 == (1 & second_lo_)) {
                        second_lo_ = MathEx.ShiftRight(second_lo_, second_hi_, out second_hi_);
                    }
                    if (1 == second_lo_ && 0 == second_hi_) {
                        result_hi = 0;
                        return 1;
                    }
                    if (first_lo_ == second_lo_ && first_hi_ == second_hi_) {
                        result_hi = second_hi_;
                        return second_lo_;
                    } else if (MathEx.GreaterThan(second_lo_, second_hi_, first_lo_, first_hi_)) {
                        goto L_Lt;
                    }
                    L_Gt:;
                    if (0 != (2 & ((uint)first_lo_ ^ (uint)second_lo_))) {
                        var t_lo = second_lo_;
                        var t_hi = second_hi_;
                        t_lo = MathEx.ShiftRight(t_lo, t_hi, 2, out t_hi);
                        first_lo_ = MathEx.ShiftRight(first_lo_, first_hi_, 2, out first_hi_);
                        t_lo = MathEx.IncreaseUnchecked(t_lo, t_hi, out t_hi);
                        first_lo_ = MathEx.AddUnchecked(first_lo_, first_hi_, t_lo, t_hi, out first_hi_);
                    } else {
                        first_lo_ = MathEx.SubtractUnchecked(first_lo_, first_hi_, second_lo_, second_hi_, out first_hi_);
                        first_lo_ = MathEx.ShiftRight(first_lo_, first_hi_, 2, out first_hi_);
                    }
                    while (0 == (1 & first_lo_)) {
                        first_lo_ = MathEx.ShiftRight(first_lo_, first_hi_, out first_hi_);
                    }
                    if (1 == first_lo_ && 0 == first_hi_) {
                        result_hi = 0;
                        return 1;
                    }
                    if (first_lo_ == second_lo_ && first_hi_ == second_hi_) {
                        result_hi = second_hi_;
                        return second_lo_;
                    } else if (MathEx.GreaterThan(first_lo_, first_hi_, second_lo_, second_hi_)) {
                        goto L_Gt;
                    }
                    goto L_Lt;
                }
            }

            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            internal static ulong GreatestCommonDivisorPartialStub0002(ulong first_lo, ulong first_hi, ulong second_lo, ulong second_hi, out ulong result_hi) {
                System.Diagnostics.Contracts.Contract.Requires(0 != (1 & first_lo) || 0 != (1 & second_lo));
                unchecked {
                    if (0 != (1 & second_lo)) {
                        if ((1 == first_lo && 0 == first_hi) || (1 == second_lo && 0 == second_hi)) {
                            result_hi = 0;
                            return 1;
                        } else {
                            return GreatestCommonDivisorPartialStub0001(first_lo, first_hi, second_lo, second_hi, out result_hi);
                        }
                    } else {
                        if (1 == first_lo && 0 == first_hi) {
                            result_hi = 0;
                            return 1;
                        } else {
                            return GreatestCommonDivisorPartialStub0001(second_lo, second_hi, first_lo, first_hi, out result_hi);
                        }
                    }
                }
            }
        }

        public static partial class ZZOverNZZModule {

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 Sum(UInt128 n, UInt128 first, UInt128 second) {
                System.Diagnostics.Contracts.Contract.Requires(n > first);
                System.Diagnostics.Contracts.Contract.Requires(n > second);
                System.Diagnostics.Contracts.Contract.Ensures(System.Diagnostics.Contracts.Contract.OldValue(n) > System.Diagnostics.Contracts.Contract.Result<UInt128>());
                return unchecked(n <= (second = (first + second)) || first > second ? second - n : second);
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 Double(UInt128 n, UInt128 value) {
                System.Diagnostics.Contracts.Contract.Requires(n > value);
                System.Diagnostics.Contracts.Contract.Ensures(System.Diagnostics.Contracts.Contract.OldValue(n) > System.Diagnostics.Contracts.Contract.Result<UInt128>());
                return Sum(n, value, value);
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 Difference(UInt128 n, UInt128 first, UInt128 second) {
                System.Diagnostics.Contracts.Contract.Requires(n > first);
                System.Diagnostics.Contracts.Contract.Requires(n > second);
                System.Diagnostics.Contracts.Contract.Ensures(System.Diagnostics.Contracts.Contract.OldValue(n) > System.Diagnostics.Contracts.Contract.Result<UInt128>());
                return unchecked(second > first ? first - second + n : first - second);
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 Opposite(UInt128 n, UInt128 value) {
                System.Diagnostics.Contracts.Contract.Requires(n > value);
                System.Diagnostics.Contracts.Contract.Ensures(System.Diagnostics.Contracts.Contract.OldValue(n) > System.Diagnostics.Contracts.Contract.Result<UInt128>());
                return Difference(n, 0u, value);
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 Product(UInt128 n, UInt128 first, UInt128 second) {
                System.Diagnostics.Contracts.Contract.Requires(n > first);
                System.Diagnostics.Contracts.Contract.Requires(n > second);
                System.Diagnostics.Contracts.Contract.Ensures(System.Diagnostics.Contracts.Contract.OldValue(n) > System.Diagnostics.Contracts.Contract.Result<UInt128>());
                var p_lo_lo = UltimateOrb.Mathematics.DoubleArithmetic.BigMul(first.lo, first.hi, second.lo, second.hi, out var p_lo_hi, out var p_hi_lo, out var p_hi_hi);
                var lo = UltimateOrb.Mathematics.DoubleArithmetic.BigRemNoThrow(p_lo_lo, p_lo_hi, p_hi_lo, p_hi_hi, n.lo, n.hi, out var hi);
                return new UInt128(lo, hi);
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 Square(UInt128 n, UInt128 value) {
                System.Diagnostics.Contracts.Contract.Requires(n > value);
                System.Diagnostics.Contracts.Contract.Ensures(System.Diagnostics.Contracts.Contract.OldValue(n) > System.Diagnostics.Contracts.Contract.Result<UInt128>());
                var p_lo_lo = UltimateOrb.Mathematics.DoubleArithmetic.BigSquare(value.lo, value.hi, out var p_lo_hi, out var p_hi_lo, out var p_hi_hi);
                var lo = UltimateOrb.Mathematics.DoubleArithmetic.BigRemNoThrow(p_lo_lo, p_lo_hi, p_hi_lo, p_hi_hi, n.lo, n.hi, out var hi);
                return new UInt128(lo, hi);
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 Power(UInt128 n, UInt128 @base, uint exponent) {
                System.Diagnostics.Contracts.Contract.Requires(n > @base);
                System.Diagnostics.Contracts.Contract.Ensures(System.Diagnostics.Contracts.Contract.OldValue(n) > System.Diagnostics.Contracts.Contract.Result<UInt128>());
                UInt128 j = 0u;
                if (n != 1u) {
                    j = 1u;
                }
                for (; ; ) {
                    if (0u != (exponent & 1u)) {
                        j = Product(n, @base, j);
                    }
                    if (0u == (exponent >>= 1)) {
                        break;
                    }
                    @base = Square(n, @base);
                }
                return j;
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 Power(UInt128 n, UInt128 @base, ulong exponent) {
                System.Diagnostics.Contracts.Contract.Requires(n > @base);
                System.Diagnostics.Contracts.Contract.Ensures(System.Diagnostics.Contracts.Contract.OldValue(n) > System.Diagnostics.Contracts.Contract.Result<UInt128>());
                UInt128 j = 0u;
                if (n != 1u) {
                    j = 1u;
                }
                for (; ; ) {
                    if (0u != (exponent & 1u)) {
                        j = Product(n, @base, j);
                    }
                    if (0u == (exponent >>= 1)) {
                        break;
                    }
                    @base = Square(n, @base);
                }
                return j;
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
            [System.Runtime.TargetedPatchingOptOutAttribute(null)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            [System.Diagnostics.Contracts.PureAttribute()]
            public static UInt128 Power(UInt128 n, UInt128 @base, UInt128 exponent) {
                System.Diagnostics.Contracts.Contract.Requires(n > @base);
                System.Diagnostics.Contracts.Contract.Ensures(System.Diagnostics.Contracts.Contract.OldValue(n) > System.Diagnostics.Contracts.Contract.Result<UInt128>());
                UInt128 j = 0u;
                if (n != 1u) {
                    j = 1u;
                }
                for (; ; ) {
                    if (0u != (exponent & 1u)) {
                        j = Product(n, @base, j);
                    }
                    if (0u == (exponent >>= 1)) {
                        break;
                    }
                    @base = Square(n, @base);
                }
                return j;
            }
        }
    }
}

namespace Internal.System {

    using static UltimateOrb.Utilities.ThrowHelper;

    using MathEx = UltimateOrb.Mathematics.DoubleArithmetic;

    public static partial class Converter {

        [global::System.CLSCompliantAttribute(false)]
        [global::System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
        [global::System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [global::System.Diagnostics.Contracts.PureAttribute()]
        public static Single ToSingle(UInt64 value) {
            const int BitSize = 64;
            const int ExponentBitSize = 11;
            const int ExponentBias = unchecked(checked((1 << (ExponentBitSize - 1))) - 1);
            const int SignBitSize = 1;
            const int FractionBitSize = checked(BitSize - SignBitSize - ExponentBitSize);

            const int BitSizeTo = 32;
            const int ExponentBitSizeTo = 8;
            const int ExponentBiasTo = unchecked(checked((1 << (ExponentBitSizeTo - 1))) - 1);
            const int SignBitSizeTo = 1;
            const int FractionBitSizeTo = checked(BitSizeTo - SignBitSizeTo - ExponentBitSizeTo);

            var value_ = value;
            if (0 != value_) {
                // var c = Mathematics.BinaryNumerals.CountLeadingZeros(unchecked((UInt64)value_));
                var c = 0;
                for (var tmp = value_; 0 <= unchecked((Int64)tmp); tmp <<= 1) {
                    unchecked {
                        ++c;
                    }
                }
                var s = unchecked((UInt64)(checked(64 - 1 + ExponentBias) - c)) << FractionBitSize;
                value_ <<= unchecked(1 + c);
                var lo = value_ & unchecked(((UInt64)1 << checked(BitSize - FractionBitSizeTo)) - 1);
                value_ >>= checked(BitSize - FractionBitSizeTo);
                if ((UInt64)1 << checked(BitSize - FractionBitSizeTo - 1) < lo || ((UInt64)1 << checked(BitSize - FractionBitSizeTo - 1) == lo && 0 != (1 & value_))) {
                    unchecked {
                        ++value_;
                    }
                }
                s = unchecked(s + (value_ << checked(FractionBitSize - FractionBitSizeTo)));
                return unchecked((Single)BitConverter.Int64BitsToDouble(unchecked((Int64)s)));
            }
            return default(Single);
        }
    }
}