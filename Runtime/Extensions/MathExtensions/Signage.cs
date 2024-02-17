using System.Runtime.CompilerServices;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#else
using System;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
	#if UFP_PKG_MATHEMATICS
		/// <summary>
		/// Returns the value of a number, but with a positive sign.
		/// </summary>
		/// <param name="val">The value to get the absolute value of.</param>
		/// <returns>The absolute value of the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Abs(this float val) => math.abs(val);
		
		/// <summary>
		/// Returns the value of a number, but with a positive sign.
		/// </summary>
		/// <param name="val">The value to get the absolute value of.</param>
		/// <returns>The absolute value of the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Abs(this int val) => math.abs(val);
		
		/// <summary>
		/// Returns the sign of the value. -1 if it is negative, 1 if it is positive, and 0 if it's 0.
		/// </summary>
		/// <param name="val">The value to get the sign of.</param>
		/// <returns>The sign of the input value as a float.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sign(this float val) => math.sign(val);
		
		/// <summary>
		/// Returns the sign of the value. -1 if it is negative, 1 if it is positive, and 0 if it's 0.
		/// </summary>
		/// <param name="val">The value to get the sign of.</param>
		/// <returns>The sign of the input value as an int.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sign(this int val) => (int)math.sign(val);
		
		/// <summary>
		/// Returns the sign of the value. -1 if it is negative, 1 if it is positive, and 0 if it's 0.
		/// </summary>
		/// <param name="val">The value to get the sign of.</param>
		/// <returns>The sign of the input value as an int.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int SignToInt(this float val) => (int)math.sign(val);
		
		/// <summary>
		/// Returns the sign of the value. -1 if it is negative, 1 if it is positive, and 0 if it's 0.
		/// </summary>
		/// <param name="val">The value to get the sign of.</param>
		/// <returns>The sign of the input value as a float.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SignToFloat(this int val) => math.sign(val);
	#else
		/// <summary>
		/// Returns the value of a number, but with a positive sign.
		/// </summary>
		/// <param name="val">The value to get the absolute value of.</param>
		/// <returns>The absolute value of the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Abs(this float val) => Math.Abs(val);
		
		/// <summary>
		/// Returns the value of a number, but with a positive sign.
		/// </summary>
		/// <param name="val">The value to get the absolute value of.</param>
		/// <returns>The absolute value of the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Abs(this int val) => Math.Abs(val);
		
		/// <summary>
		/// Returns the sign of the value. -1 if it is negative, 1 if it is positive, and 0 if it's 0.
		/// </summary>
		/// <param name="val">The value to get the sign of.</param>
		/// <returns>The sign of the input value as a float.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sign(this float val) => Math.Sign(val);
		
		/// <summary>
		/// Returns the sign of the value. -1 if it is negative, 1 if it is positive, and 0 if it's 0.
		/// </summary>
		/// <param name="val">The value to get the sign of.</param>
		/// <returns>The sign of the input value as an int.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sign(this int val) => Math.Sign(val);
		
		/// <summary>
		/// Returns the sign of the value. -1 if it is negative, 1 if it is positive, and 0 if it's 0.
		/// </summary>
		/// <param name="val">The value to get the sign of.</param>
		/// <returns>The sign of the input value as an int.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int SignToInt(this float val) => Math.Sign(val);
		
		/// <summary>
		/// Returns the sign of the value. -1 if it is negative, 1 if it is positive, and 0 if it's 0.
		/// </summary>
		/// <param name="val">The value to get the sign of.</param>
		/// <returns>The sign of the input value as a float.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SignToFloat(this int val) => Math.Sign(val);
	#endif
	}
}