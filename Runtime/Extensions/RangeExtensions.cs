using System;
using System.Runtime.CompilerServices;

namespace UnityForProgrammers {
	public static class RangeExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CustomIntEnumerator GetEnumerator(this Range @this) => new(@this);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CustomIntEnumerator GetEnumerator(this int number) => new(0..number);
    }

    public ref struct CustomIntEnumerator {
        public int Current {get; private set;}
        private readonly int end;
        public CustomIntEnumerator(Range range) {
            Current = range.Start.Value - 1;
            end = range.End.Value;
        }

        public bool MoveNext() {
            Current++;
            return Current <= end;
        }
    }
}