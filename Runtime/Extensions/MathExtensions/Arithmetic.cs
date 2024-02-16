using System.Runtime.CompilerServices;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#else
using System;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Mod(this int lhs, int rhs) => (lhs % rhs + rhs) % rhs;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Mod(this float lhs, float rhs) => (lhs % rhs + rhs) % rhs;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sqr(this float val) => val * val;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sqr(this int val) => val * val;
	
	#if UFP_PKG_MATHEMATICS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sqrt(this float val) => math.sqrt(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sqrt(this int val) => math.sqrt(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Pow(this float val, float power) => math.pow(val, power);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Pow(this int val, float power) => math.pow(val, power);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Exp(this float val) => math.exp(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Exp(this int val) => math.exp(val);
	#else
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sqrt(this float val) => (float)Math.Sqrt(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sqrt(this int val) => (float)Math.Sqrt(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Pow(this float val, float power) => (float)Math.Pow(val, power);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Pow(this int val, float power) => (float)Math.Pow(val, power);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Exp(this float val) => (float)Math.Exp(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Exp(this int val) => (float)Math.Exp(val);
	#endif
	}
}