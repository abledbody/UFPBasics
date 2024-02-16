using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#else
using System;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Min(this float a, params float[] b) {
			var min = a;
			for (int i = 0; i < b.Length; i++)
				min = min.Min(b[i]);
			return min;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Min(this int a, params int[] b) {
			var min = a;
			for (int i = 0; i < b.Length; i++)
				min = min.Min(b[i]);
			return min;
		}
		
		/// <summary>Returns the value with the largest magnitude.</summary>
		/// <param name="a">The first value to be compared</param>
		/// <param name="values">Each additional value to be compared</param>
		/// <returns>The value with the largest magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float MinMagnitude(this float a, params float[] values) {
			var min = a;
			for (int i = 0; i < values.Length; i++) 
				min = values[i].Abs() < min.Abs() ? values[i] : min;
			return min;
		}
		/// <summary>Returns the value with the largest magnitude.</summary>
		/// <param name="a">The first value to be compared</param>
		/// <param name="values">Each additional value to be compared</param>
		/// <returns>The value with the largest magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int MinMagnitude(this int a, params int[] values) {
			var min = a;
			for (int i = 0; i < values.Length; i++) 
				min = values[i].Abs() < min.Abs() ? values[i] : min;
			return min;
		}
		/// <summary>Returns the value with the lowest magnitude.</summary>
		/// <param name="values">Each value to be compared</param>
		/// <returns>The value with the lowest magnitude.</returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float MinMagnitude(params float[] values) => values[0].MinMagnitude(values);
		/// <summary>Returns the value with the lowest magnitude.</summary>
		/// <param name="values">Each value to be compared</param>
		/// <returns>The value with the lowest magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int MinMagnitude(params int[] values) => values[0].MinMagnitude(values);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float MinMagnitude(this float a, float b) => a.Abs() < b.Abs() ? a : b;
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Max(this float a, params float[] b) {
			var max = a;
			for (int i = 0; i < b.Length; i++)
				max = max.Max(b[i]);
			return max;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Max(this int a, params int[] b) {
			var max = a;
			for (int i = 0; i < b.Length; i++)
				max = max.Max(b[i]);
			return max;
		}
		
		/// <summary>Returns the value with the largest magnitude.</summary>
		/// <param name="a">The first value to be compared</param>
		/// <param name="values">Each additional value to be compared</param>
		/// <returns>The value with the largest magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float MaxMagnitude(this float a, params float[] values) {
			var max = a;
			for (int i = 0; i < values.Length; i++)
				max = values[i].Abs() > max.Abs() ? values[i] : max;
			return max;
		}
		/// <summary>Returns the value with the largest magnitude.</summary>
		/// <param name="a">The first value to be compared</param>
		/// <param name="values">Each additional value to be compared</param>
		/// <returns>The value with the largest magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int MaxMagnitude(this int a, params int[] values) {
			var max = a;
			for (int i = 0; i < values.Length; i++)
				max = values[i].Abs() > max.Abs() ? values[i] : max;
			return max;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float MaxMagnitude(this float a, float b) => a.Abs() > b.Abs() ? a : b;
		/// <summary>Returns the value with the largest magnitude.</summary>
		/// <param name="values">Each value to be compared</param>
		/// <returns>The value with the largest magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float MaxMagnitude(params float[] values) => values[0].MaxMagnitude(values);
		/// <summary>Returns the value with the largest magnitude.</summary>
		/// <param name="values">Each value to be compared</param>
		/// <returns>The value with the largest magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float MaxMagnitude(params int[] values) => values[0].MaxMagnitude(values);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 ClampMagnitude(this Vector2 val, float maxMagnitude) => Vector2.ClampMagnitude(val, maxMagnitude);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 ClampMagnitude(this Vector3 val, float maxMagnitude) => Vector3.ClampMagnitude(val, maxMagnitude);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 ClampMagnitude(this Vector4 val, float maxMagnitude) => val.Normalized() * maxMagnitude.Min(val.Magnitude());
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Saturate(this float val) => val.Clamp(0f, 1f);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Saturate(this int val) => val.Clamp(0, 1);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Clamp01(this float val) => val.Saturate();
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Clamp01(this int val) => val.Saturate();
		
	#if UFP_PKG_MATHEMATICS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Min(this float a, float b) => math.min(a,b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Min(this int a, int b) => math.min(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Max(this float a, float b) => math.max(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Max(this int a, int b) => math.max(a, b);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Clamp(this float val, float min, float max) => math.clamp(val, min, max);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Clamp(this int val, int min, int max) => math.clamp(val, min, max);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 ClampMagnitude(this float2 val, float maxMagnitude) {
			var mag = val.Magnitude();
			return val / mag * maxMagnitude.Min(mag);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 ClampMagnitude(this float3 val, float maxMagnitude) {
			var mag = val.Magnitude();
			return val / mag * maxMagnitude.Min(mag);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 ClampMagnitude(this float4 val, float maxMagnitude) {
			var mag = val.Magnitude();
			return val / mag * maxMagnitude.Min(mag);
		}
	#else
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Min(this float a, float b) => Math.Min(a,b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Min(this int a, int b) => Math.Min(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Max(this float a, float b) => Math.Max(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Max(this int a, int b) => Math.Max(a, b);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Clamp(this float val, float min, float max) => Math.Clamp(val, min, max);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Clamp(this int val, int min, int max) => Math.Clamp(val, min, max);
	#endif
	}
}