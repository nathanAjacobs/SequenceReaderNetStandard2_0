using System;
using System.Buffers.Binary;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace SequenceReaderNetStandard2_0
{
    public static partial class SequenceReaderExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool TryCopyTo<T>(ref this SequenceReader<byte> reader, ref Span<byte> dest) where T : unmanaged
        {
            if (reader.Length < sizeof(T))
            {
                dest = default;
                return false;
            }

            if (!reader.TryCopyTo(dest))
            {
                dest = default;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Reads an <see cref="ushort"/> as little endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="ushort"/>.</returns>
        public static bool TryReadLittleEndian(ref this SequenceReader<byte> reader, out ushort value)
        {
            bool passed = TryReadLittleEndian(ref reader, out short val);
            value = (ushort)val;
            return passed;
        }

        /// <summary>
        /// Reads an <see cref="ushort"/> as big endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="short"/>.</returns>
        public static bool TryReadBigEndian(ref this SequenceReader<byte> reader, out ushort value)
        {
            bool passed = TryReadBigEndian(ref reader, out short val);
            value = (ushort)val;
            return passed;
        }

        /// <summary>
        /// Reads an <see cref="short"/> as little endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="short"/>.</returns>
        public static unsafe bool TryReadLittleEndian(ref this SequenceReader<byte> reader, out short value)
        {
            short temp = default;
            Span<byte> buffer = new Span<byte>(&temp, sizeof(short));

            if (!TryCopyTo<short>(ref reader, ref buffer))
            {
                value = default;
                return false;
            }

            reader.Advance(sizeof(short));

            value = BinaryPrimitives.ReadInt16LittleEndian(buffer);
            return true;
        }

        /// <summary>
        /// Reads an <see cref="short"/> as big endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="short"/>.</returns>
        public static unsafe bool TryReadBigEndian(ref this SequenceReader<byte> reader, out short value)
        {
            short temp = default;
            Span<byte> buffer = new Span<byte>(&temp, sizeof(short));

            if (!TryCopyTo<short>(ref reader, ref buffer))
            {
                value = default;
                return false;
            }

            reader.Advance(sizeof(short));

            value = BinaryPrimitives.ReadInt16BigEndian(buffer);
            return true;
        }

        /// <summary>
        /// Reads an <see cref="uint"/> as little endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="uint"/>.</returns>
        public static bool TryReadLittleEndian(ref this SequenceReader<byte> reader, out uint value)
        {
            bool passed = TryReadLittleEndian(ref reader, out int val);
            value = (uint)val;
            return passed;
        }

        /// <summary>
        /// Reads an <see cref="uint"/> as big endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="uint"/>.</returns>
        public static bool TryReadBigEndian(ref this SequenceReader<byte> reader, out uint value)
        {
            bool passed = TryReadBigEndian(ref reader, out int val);
            value = (uint)val;
            return passed;
        }

        /// <summary>
        /// Reads an <see cref="int"/> as little endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="int"/>.</returns>
        public static unsafe bool TryReadLittleEndian(ref this SequenceReader<byte> reader, out int value)
        {
            int temp = default;
            Span<byte> buffer = new Span<byte>(&temp, sizeof(int));

            if (!TryCopyTo<int>(ref reader, ref buffer))
            {
                value = default;
                return false;
            }

            reader.Advance(sizeof(int));

            value = BinaryPrimitives.ReadInt32LittleEndian(buffer);
            return true;
        }

        /// <summary>
        /// Reads an <see cref="int"/> as big endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="int"/>.</returns>
        public static unsafe bool TryReadBigEndian(ref this SequenceReader<byte> reader, out int value)
        {
            int temp = default;
            Span<byte> buffer = new Span<byte>(&temp, sizeof(int));

            if (!TryCopyTo<int>(ref reader, ref buffer))
            {
                value = default;
                return false;
            }

            reader.Advance(sizeof(int));

            value = BinaryPrimitives.ReadInt32BigEndian(buffer);
            return true;
        }

        /// <summary>
        /// Reads an <see cref="ulong"/> as little endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="ulong"/>.</returns>
        public static bool TryReadLittleEndian(ref this SequenceReader<byte> reader, out ulong value)
        {
            bool passed = TryReadLittleEndian(ref reader, out long val);
            value = (ulong)val;
            return passed;
        }

        /// <summary>
        /// Reads an <see cref="ulong"/> as big endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="ulong"/>.</returns>
        public static bool TryReadBigEndian(ref this SequenceReader<byte> reader, out ulong value)
        {
            bool passed = TryReadBigEndian(ref reader, out long val);
            value = (ulong)val;
            return passed;
        }

        /// <summary>
        /// Reads an <see cref="long"/> as little endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="long"/>.</returns>
        public static unsafe bool TryReadLittleEndian(ref this SequenceReader<byte> reader, out long value)
        {
            long temp = default;
            Span<byte> buffer = new Span<byte>(&temp, sizeof(long));

            if (!TryCopyTo<long>(ref reader, ref buffer))
            {
                value = default;
                return false;
            }

            reader.Advance(sizeof(long));

            value = BinaryPrimitives.ReadInt64LittleEndian(buffer);
            return true;
        }

        /// <summary>
        /// Reads an <see cref="long"/> as big endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="long"/>.</returns>
        public static unsafe bool TryReadBigEndian(ref this SequenceReader<byte> reader, out long value)
        {
            long temp = default;
            Span<byte> buffer = new Span<byte>(&temp, sizeof(long));

            if (!TryCopyTo<long>(ref reader, ref buffer))
            {
                value = default;
                return false;
            }

            reader.Advance(sizeof(long));

            value = BinaryPrimitives.ReadInt64BigEndian(buffer);
            return true;
        }

        /// <summary>
        /// Reads an <see cref="float"/> as little endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="float"/>.</returns>
        public static unsafe bool TryReadLittleEndian(ref this SequenceReader<byte> reader, out float value)
        {
            float temp = default;
            Span<byte> buffer = new Span<byte>(&temp, sizeof(float));

            if (!TryCopyTo<float>(ref reader, ref buffer))
            {
                value = default;
                return false;
            }

            reader.Advance(sizeof(float));

            value = BinaryPrimitivesNetStandard2_0.BinaryPrimitivesNetStandard2_0.ReadSingleLittleEndian(buffer);
            return true;
        }

        /// <summary>
        /// Reads an <see cref="float"/> as big endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="float"/>.</returns>
        public static unsafe bool TryReadBigEndian(ref this SequenceReader<byte> reader, out float value)
        {
            float temp = default;
            Span<byte> buffer = new Span<byte>(&temp, sizeof(float));

            if (!TryCopyTo<float>(ref reader, ref buffer))
            {
                value = default;
                return false;
            }

            reader.Advance(sizeof(float));

            value = BinaryPrimitivesNetStandard2_0.BinaryPrimitivesNetStandard2_0.ReadSingleBigEndian(buffer);
            return true;
        }

        /// <summary>
        /// Reads an <see cref="double"/> as little endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="double"/>.</returns>
        public static unsafe bool TryReadLittleEndian(ref this SequenceReader<byte> reader, out double value)
        {
            double temp = default;
            Span<byte> buffer = new Span<byte>(&temp, sizeof(double));

            if (!TryCopyTo<double>(ref reader, ref buffer))
            {
                value = default;
                return false;
            }

            reader.Advance(sizeof(float));

            value = BinaryPrimitivesNetStandard2_0.BinaryPrimitivesNetStandard2_0.ReadDoubleLittleEndian(buffer);
            return true;
        }

        /// <summary>
        /// Reads an <see cref="double"/> as big endian.
        /// </summary>
        /// <returns>False if there wasn't enough data for an <see cref="double"/>.</returns>
        public static unsafe bool TryReadBigEndian(ref this SequenceReader<byte> reader, out double value)
        {
            double temp = default;
            Span<byte> buffer = new Span<byte>(&temp, sizeof(double));

            if (!TryCopyTo<double>(ref reader, ref buffer))
            {
                value = default;
                return false;
            }

            reader.Advance(sizeof(float));

            value = BinaryPrimitivesNetStandard2_0.BinaryPrimitivesNetStandard2_0.ReadDoubleBigEndian(buffer);
            return true;
        }

        /// <summary>
        /// Polyfill method used by the <see cref="SequenceReader{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of element kept by the sequence.</typeparam>
        /// <param name="sequence">The sequence to retrieve.</param>
        /// <param name="first">The first span in the sequence.</param>
        /// <param name="next">The next position.</param>
        public static void GetFirstSpan<T>(this ReadOnlySequence<T> sequence, out ReadOnlySpan<T> first, out SequencePosition next)
        {
            first = sequence.First.Span;
            next = sequence.GetPosition(first.Length);
        }
    }
}
