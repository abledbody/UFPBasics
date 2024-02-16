using System.Runtime.CompilerServices;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#else
using System;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
	#if UFP_PKG_MATHEMATICS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Abs(this float val) => math.abs(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Abs(this int val) => math.abs(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sign(this float val) => math.sign(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int SignToInt(this int val) => (int)math.sign(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sign(this int val) => math.sign(val);
	#else
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Abs(this float val) => Math.Abs(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Abs(this int val) => Math.Abs(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sign(this float val) => Math.Sign(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int SignToInt(this float val) => Math.Sign(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sign(this int val) => Math.Sign(val);
	#endif
	}
}