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
	
	/// <summary>An enumerator which can be used to iterate over a range of integers.</summary>
	public ref struct IntEnumerator {
		public int Current { get; private set; }
		private readonly int start;
		private readonly int end;
		private readonly bool reverse;
		
		public IntEnumerator(Range range) {
			start = range.Start.Value;
			end = range.End.Value;
			reverse = start > end;
			Current = reverse ? start : start - 1;
		}
		
		public bool MoveNext() => reverse ? --Current >= end : ++Current < end;
	}
}