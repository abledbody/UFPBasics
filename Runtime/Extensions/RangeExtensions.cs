using System;
using System.Runtime.CompilerServices;

namespace UnityForProgrammers {
	/// <summary>Extensions which make it possible to iterate over a range of integers.</summary>
	public static class RangeExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntEnumerator GetEnumerator(this Range @this) => new(@this);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntEnumerator GetEnumerator(this int number) => new(0..number);
	}

	public ref struct IntEnumerator {
		public int Current { get; private set; }
		private readonly int end;
		public IntEnumerator(Range range) {
			Current = range.Start.Value - 1;
			end = range.End.Value;
		}
		
		public bool MoveNext() => Current++ < end;
	}
}