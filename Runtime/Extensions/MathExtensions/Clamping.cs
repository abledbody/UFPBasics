using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#else
using System;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
	#region Min
		/// <summary>
		/// Finds and returns the smallest value among several numbers.
		/// </summary>
		/// <param name="this">The first value to be compared.</param>
		/// <param name="values">Each additional value to be compared.</param>
		/// <returns>The number with the smallest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Min(this float @this, params float[] values) {
			var min = @this;
			for (int i = 0; i < values.Length; i++)
				min = min.Min(values[i]);
			return min;
		}
		
		/// <summary>
		/// Finds and returns the smallest value among several numbers.
		/// </summary>
		/// <param name="this">The first value to be compared.</param>
		/// <param name="values">Each additional value to be compared.</param>
		/// <returns>The number with the smallest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Min(this int @this, params int[] values) {
			var min = @this;
			for (int i = 0; i < values.Length; i++)
				min = min.Min(values[i]);
			return min;
		}
	#endregion
	
	#region AbsMin
		/// <summary>Returns the number with smallest absolute value.</summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with smallest absolute value.</returns>
		/// <remarks>The sign of the minimum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float AbsMin(this float a, float b) => a.Abs() < b.Abs() ? a : b;
		
		/// <summary>Returns the number with smallest absolute value.</summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with smallest absolute value.</returns>
		/// <remarks>The sign of the minimum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int AbsMin(this int a, int b) => a.Abs() < b.Abs() ? a : b;
		
		/// <summary>Returns the number with smallest absolute value.</summary>
		/// <param name="this">The first value to be compared.</param>
		/// <param name="values">Each additional value to be compared.</param>
		/// <returns>The number with smallest absolute value.</returns>
		/// <remarks>The sign of the minimum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float AbsMin(this float @this, params float[] values) {
			var min = @this;
			for (int i = 0; i < values.Length; i++) 
				min = values[i].AbsMin(min);
			return min;
		}
		
		/// <summary>Returns the number with smallest absolute value.</summary>
		/// <param name="this">The first value to be compared.</param>
		/// <param name="values">Each additional value to be compared.</param>
		/// <returns>The number with smallest absolute value.</returns>
		/// <remarks>The sign of the minimum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int AbsMin(this int @this, params int[] values) {
			var min = @this;
			for (int i = 0; i < values.Length; i++) 
				min = values[i].AbsMin(min);
			return min;
		}
		
		/// <summary>Returns the number with smallest absolute value.</summary>
		/// <param name="values">Each value to be compared.</param>
		/// <returns>The number with smallest absolute value.</returns>
		/// <remarks>The sign of the minimum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float AbsMin(params float[] values) => values[0].AbsMin(values);
		
		/// <summary>Returns the number with smallest absolute value.</summary>
		/// <param name="values">Each value to be compared.</param>
		/// <returns>The number with smallest absolute value.</returns>
		/// <remarks>The sign of the minimum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int AbsMin(params int[] values) => values[0].AbsMin(values);
	#endregion
	
	#region Max
		/// <summary>
		/// Finds and returns the largest value among several numbers.
		/// </summary>
		/// <param name="this">The first value to be compared.</param>
		/// <param name="values">Each additional value to be compared.</param>
		/// <returns>The number with the largest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Max(this float a, params float[] b) {
			var max = a;
			for (int i = 0; i < b.Length; i++)
				max = max.Max(b[i]);
			return max;
		}
		
		/// <summary>
		/// Finds and returns the largest value among several numbers.
		/// </summary>
		/// <param name="this">The first value to be compared.</param>
		/// <param name="values">Each additional value to be compared.</param>
		/// <returns>The number with the largest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Max(this int a, params int[] b) {
			var max = a;
			for (int i = 0; i < b.Length; i++)
				max = max.Max(b[i]);
			return max;
		}
	#endregion
	
	#region AbsMax
		/// <summary>Returns the number with largest absolute value.</summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with largest absolute value.</returns>
		/// <remarks>The sign of the maximum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float AbsMax(this float a, float b) => a.Abs() > b.Abs() ? a : b;
		
		/// <summary>Returns the number with largest absolute value.</summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with largest absolute value.</returns>
		/// <remarks>The sign of the maximum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int AbsMax(this int a, int b) => a.Abs() > b.Abs() ? a : b;
		
		/// <summary>Returns the number with largest absolute value.</summary>
		/// <param name="this">The first value to be compared.</param>
		/// <param name="values">Each additional value to be compared.</param>
		/// <returns>The number with largest absolute value.</returns>
		/// <remarks>The sign of the maximum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float AbsMax(this float @this, params float[] values) {
			var max = @this;
			for (int i = 0; i < values.Length; i++)
				max = values[i].Abs() > max.Abs() ? values[i] : max;
			return max;
		}
		
		/// <summary>Returns the number with largest absolute value.</summary>
		/// <param name="this">The first value to be compared.</param>
		/// <param name="values">Each additional value to be compared.</param>
		/// <returns>The number with largest absolute value.</returns>
		/// <remarks>The sign of the maximum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int AbsMax(this int @this, params int[] values) {
			var max = @this;
			for (int i = 0; i < values.Length; i++)
				max = values[i].Abs() > max.Abs() ? values[i] : max;
			return max;
		}
		
		/// <summary>Returns the number with largest absolute value.</summary>
		/// <param name="values">Each value to be compared.</param>
		/// <returns>The number with largest absolute value.</returns>
		/// <remarks>The sign of the maximum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float AbsMax(params float[] values) => values[0].AbsMax(values);
		
		/// <summary>Returns the number with largest absolute value.</summary>
		/// <param name="values">Each value to be compared.</param>
		/// <returns>The number with largest absolute value.</returns>
		/// <remarks>The sign of the maximum number is maintained.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float AbsMax(params int[] values) => values[0].AbsMax(values);
	#endregion
		
	#region CapMagnitude
		/// <summary>
		/// Limits the magnitude of a vector to be no greater than the specified value.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no greater than the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 CapMagnitude(this Vector2 @this, float maxMagnitude) {
			var mag = @this.Magnitude();
			return @this / mag * mag.Min(maxMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be no greater than the specified value.
		/// </summary>
		/// <param name="this">The vector to clamp.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no greater than the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 CapMagnitude(this Vector3 @this, float maxMagnitude) {
			var mag = @this.Magnitude();
			return @this / mag * mag.Min(maxMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be no greater than the specified value.
		/// </summary>
		/// <param name="this">The vector to clamp.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no greater than the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 CapMagnitude(this Vector4 @this, float maxMagnitude) {
			var mag = @this.Magnitude();
			return @this / mag * mag.Min(maxMagnitude);
		}
	#endregion
	
	#region BaseMagnitude
		/// <summary>
		/// Limits the magnitude of a vector to be no less than the specified value.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no less than the specified value, or zero if the vector is zero.</returns>
		public static Vector2 BaseMagnitude(this Vector2 @this, float minMagnitude) {
			if (@this == Vector2.zero) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Max(minMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be no less than the specified value.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no less than the specified value, or zero if the vector is zero.</returns>
		public static Vector3 BaseMagnitude(this Vector3 @this, float minMagnitude) {
			if (@this == Vector3.zero) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Max(minMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be no less than the specified value.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no less than the specified value, or zero if the vector is zero.</returns>
		public static Vector4 BaseMagnitude(this Vector4 @this, float minMagnitude) {
			if (@this == Vector4.zero) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Max(minMagnitude);
		}
	#endregion
	
	#region ClampMagnitude
		/// <summary>
		/// Limits the magnitude of a vector to be within the specified range.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude within the specified range, or zero if the vector is zero.</returns>
		public static Vector2 ClampMagnitude(this Vector2 @this, float minMagnitude, float maxMagnitude) {
			if (@this == Vector2.zero) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Clamp(minMagnitude, maxMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be within the specified range.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude within the specified range, or zero if the vector is zero.</returns>
		public static Vector3 ClampMagnitude(this Vector3 @this, float minMagnitude, float maxMagnitude) {
			if (@this == Vector3.zero) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Clamp(minMagnitude, maxMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be within the specified range.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude within the specified range, or zero if the vector is zero.</returns>
		public static Vector4 ClampMagnitude(this Vector4 @this, float minMagnitude, float maxMagnitude) {
			if (@this == Vector4.zero) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Clamp(minMagnitude, maxMagnitude);
		}
	#endregion
	
	#region Saturate
		/// <summary>
		/// Clamps a value to be within the range of 0 to 1.
		/// </summary>
		/// <param name="val">The value to clamp.</param>
		/// <returns>The value clamped to be within the range of 0 to 1.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Saturate(this float val) => val.Clamp(0f, 1f);
		
		/// <summary>
		/// Clamps a value to be within the range of 0 to 1.
		/// </summary>
		/// <param name="val">The value to clamp.</param>
		/// <returns>The value clamped to be within the range of 0 to 1.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Clamp01(this float val) => val.Saturate();
	#endregion
		
	#if UFP_PKG_MATHEMATICS
	
	#region Min
		/// <summary>
		/// Returns the number with the smallest value.
		/// </summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with the smallest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Min(this float a, float b) => math.min(a,b);
		
		/// <summary>
		/// Returns the number with the smallest value.
		/// </summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with the smallest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Min(this int a, int b) => math.min(a, b);
	#endregion
		
	#region Max
		/// <summary>
		/// Returns the number with the largest value.
		/// </summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with the largest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Max(this float a, float b) => math.max(a, b);
		
		/// <summary>
		/// Returns the number with the largest value.
		/// </summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with the largest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Max(this int a, int b) => math.max(a, b);
	#endregion
		
	#region Clamp
		/// <summary>
		/// Clamps a value to be within the specified range.
		/// </summary>
		/// <param name="val">The value to clamp.</param>
		/// <param name="min">The lower bound.</param>
		/// <param name="max">The upper bound.</param>
		/// <returns>The value clamped betwen min and max.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Clamp(this float val, float min, float max) => math.clamp(val, min, max);
		
		/// <summary>
		/// Clamps a value to be within the specified range.
		/// </summary>
		/// <param name="val">The value to clamp.</param>
		/// <param name="min">The lower bound.</param>
		/// <param name="max">The upper bound.</param>
		/// <returns>The value clamped betwen min and max.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Clamp(this int val, int min, int max) => math.clamp(val, min, max);
	#endregion
		
	#region CapMagnitude
		/// <summary>
		/// Limits the magnitude of a vector to be no greater than the specified value.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no greater than the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 CapMagnitude(this float2 @this, float maxMagnitude) {
			var mag = @this.Magnitude();
			return @this / mag * mag.Min(maxMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be no greater than the specified value.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no greater than the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 CapMagnitude(this float3 @this, float maxMagnitude) {
			var mag = @this.Magnitude();
			return @this / mag * mag.Min(maxMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be no greater than the specified value.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no greater than the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 CapMagnitude(this float4 @this, float maxMagnitude) {
			var mag = @this.Magnitude();
			return @this / mag * mag.Min(maxMagnitude);
		}
		
		
	#endregion
	
	#region BaseMagnitude
		/// <summary>
		/// Limits the magnitude of a vector to be no less than the specified value.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no less than the specified value, or zero if the vector is zero.</returns>
		public static float2 BaseMagnitude(this float2 @this, float minMagnitude) {
			if (@this.Equals(float2.zero)) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Max(minMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be no less than the specified value.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no less than the specified value, or zero if the vector is zero.</returns>
		public static float3 BaseMagnitude(this float3 @this, float minMagnitude) {
			if (@this.Equals(float3.zero)) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Max(minMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be no less than the specified value.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude no less than the specified value, or zero if the vector is zero.</returns>
		public static float4 BaseMagnitude(this float4 @this, float minMagnitude) {
			if (@this.Equals(float4.zero)) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Max(minMagnitude);
		}
	#endregion
		
	#region ClampMagnitude
		/// <summary>
		/// Limits the magnitude of a vector to be within the specified range.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude within the specified range, or zero if the vector is zero.</returns>
		public static float2 ClampMagnitude(this float2 @this, float minMagnitude, float maxMagnitude) {
			if (@this.Equals(float2.zero)) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Clamp(minMagnitude, maxMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be within the specified range.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude within the specified range, or zero if the vector is zero.</returns>
		public static float3 ClampMagnitude(this float3 @this, float minMagnitude, float maxMagnitude) {
			if (@this.Equals(float3.zero)) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Clamp(minMagnitude, maxMagnitude);
		}
		
		/// <summary>
		/// Limits the magnitude of a vector to be within the specified range.
		/// </summary>
		/// <param name="this">The vector to limit.</param>
		/// <param name="minMagnitude">The minimum magnitude of the vector.</param>
		/// <param name="maxMagnitude">The maximum magnitude of the vector.</param>
		/// <returns>The vector with a magnitude within the specified range, or zero if the vector is zero.</returns>
		public static float4 ClampMagnitude(this float4 @this, float minMagnitude, float maxMagnitude) {
			if (@this.Equals(float4.zero)) return @this;
			var mag = @this.Magnitude();
			return @this / mag * mag.Clamp(minMagnitude, maxMagnitude);
		}
	#endregion
	#else
	
	#region Min
		/// <summary>
		/// Returns the number with the smallest value.
		/// </summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with the smallest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Min(this float a, float b) => Math.Min(a,b);
		
		/// <summary>
		/// Returns the number with the smallest value.
		/// </summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with the smallest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Min(this int a, int b) => Math.Min(a, b);
	#endregion
	
	#region Max
		/// <summary>
		/// Returns the number with the largest value.
		/// </summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with the largest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Max(this float a, float b) => Math.Max(a, b);
		
		/// <summary>
		/// Returns the number with the largest value.
		/// </summary>
		/// <param name="a">The first value to be compared.</param>
		/// <param name="b">The second value to be compared.</param>
		/// <returns>The number with the largest value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Max(this int a, int b) => Math.Max(a, b);
	#endregion
	
	#region Clamp
		/// <summary>
		/// Clamps a value to be within the specified range.
		/// </summary>
		/// <param name="val">The value to clamp.</param>
		/// <param name="min">The lower bound.</param>
		/// <param name="max">The upper bound.</param>
		/// <returns>The value clamped betwen min and max.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Clamp(this float val, float min, float max) => Math.Clamp(val, min, max);
		
		/// <summary>
		/// Clamps a value to be within the specified range.
		/// </summary>
		/// <param name="val">The value to clamp.</param>
		/// <param name="min">The lower bound.</param>
		/// <param name="max">The upper bound.</param>
		/// <returns>The value clamped betwen min and max.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Clamp(this int val, int min, int max) => Math.Clamp(val, min, max);
	#endregion
	#endif
	}
}