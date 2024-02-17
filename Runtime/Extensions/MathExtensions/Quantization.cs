using System.Runtime.CompilerServices;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#else
using System;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		/// <summary>
		/// Rounds a float value to the nearest multiple of the specified interval.
		/// </summary>
		/// <param name="val">The float value to quantize.</param>
		/// <param name="interval">The interval between quantized values.</param>
		/// <returns>The quantized value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Quantize(this float val, float interval) => (val / interval).Round() * interval;
		
	#if UFP_PKG_MATHEMATICS
		/// <summary>
		/// Rounds a float down to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round down.</param>
		/// <returns>The nearest value which is a integer and not greater than the input value, as a floating point number.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Floor(this float val) => math.floor(val);
		
		/// <summary>
		/// Rounds a float down to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round down.</param>
		/// <returns>The nearest value which is an integer and not greater than the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FloorToInt(this float val) => (int)math.floor(val);
		
		/// <summary>
		/// Rounds a float up to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round up.</param>
		/// <returns>The nearest value which is an integer and not less than the input value, as a floating point number.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Ceil(this float val) => math.ceil(val);
		
		/// <summary>
		/// Rounds a float up to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round up.</param>
		/// <returns>The nearest value which is an integer and not less than the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CeilToInt(this float val) => (int)math.ceil(val);
		
		/// <summary>
		/// Rounds a float to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round.</param>
		/// <returns>The nearest value which is a integer, as a floating point number.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Round(this float val) => math.round(val);
		
		/// <summary>
		/// Rounds a float to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round.</param>
		/// <returns>The nearest value which is an integer.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int RoundToInt(this float val) => (int)math.round(val);
	#else
		/// <summary>
		/// Rounds a float down to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round down.</param>
		/// <returns>The nearest value which is a integer and not greater than the input value, as a floating point number.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Floor(this float val) => (float)Math.Floor(val);
		
		/// <summary>
		/// Rounds a float down to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round down.</param>
		/// <returns>The nearest value which is an integer and not greater than the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FloorToInt(this float val) => (int)Math.Floor(val);
		
		/// <summary>
		/// Rounds a float up to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round up.</param>
		/// <returns>The nearest value which is an integer and not less than the input value, as a floating point number.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Ceil(this float val) => (float)Math.Ceiling(val);
		
		/// <summary>
		/// Rounds a float up to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round up.</param>
		/// <returns>The nearest value which is an integer and not less than the input value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CeilToInt(this float val) => (int)Math.Ceiling(val);
		
		/// <summary>
		/// Rounds a float to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round.</param>
		/// <returns>The nearest value which is a integer, as a floating point number.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Round(this float val) => (float)Math.Round(val);
		
		/// <summary>
		/// Rounds a float to the nearest integer.
		/// </summary>
		/// <param name="val">The float value to round.</param>
		/// <returns>The nearest value which is an integer.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int RoundToInt(this float val) => (int)Math.Round(val);
	#endif
	}
}