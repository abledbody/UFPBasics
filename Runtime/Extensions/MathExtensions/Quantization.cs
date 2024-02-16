using System.Runtime.CompilerServices;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#else
using System;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Quantize(this float val, float interval) => (val / interval).Round() * interval;
		
	#if UFP_PKG_MATHEMATICS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Floor(this float val) => math.floor(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FloorToInt(this float val) => (int)math.floor(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Ceil(this float val) => math.ceil(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CeilToInt(this float val) => (int)math.ceil(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Round(this float val) => math.round(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int RoundToInt(this float val) => (int)math.round(val);
	#else
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Floor(this float val) => (float)Math.Floor(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FloorToInt(this float val) => (int)Math.Floor(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Ceil(this float val) => (float)Math.Ceiling(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CeilToInt(this float val) => (int)Math.Ceiling(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Round(this float val) => (float)Math.Round(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int RoundToInt(this float val) => (int)Math.Round(val);
	#endif
	}
}