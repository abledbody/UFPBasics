using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#else
using System;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		/// <summary>Converts a FOV value in degrees into a slope.</summary>
		/// <param name="fov">The FOV value in degrees.</param>
		/// <returns>The slope of half the FOV.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float FOVToSlope(this float fov) => (fov.Radians() / 2f).Tan();
		/// <summary>Converts a slope into a FOV value in degrees.</summary>
		/// <param name="slope">The slope of half the FOV.</param>
		/// <returns>The FOV value in degrees.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SlopeToFOV(this float slope) => slope.Atan().Degrees() * 2f;
		
	#if UFP_PKG_MATHEMATICS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Degrees(this float radians) => math.degrees(radians);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Radians(this float degrees) => math.radians(degrees);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sin(this float a) => math.sin(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Asin(this float a) => math.asin(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Cos(this float a) => math.cos(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Acos(this float a) => math.acos(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Tan(this float a) => math.tan(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Atan(this float a) => math.atan(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Atan2(this Vector2 vec) => math.atan2(vec.y, vec.x);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Atan2(this float2 vec) => math.atan2(vec.y, vec.x);
	#else
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Degrees(this float radians) => radians * Mathf.Rad2Deg;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Radians(this float degrees) => degrees * Mathf.Deg2Rad;
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sin(this float a) => (float)Math.Sin(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Asin(this float a) => (float)Math.Asin(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Cos(this float a) => (float)Math.Cos(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Acos(this float a) => (float)Math.Acos(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Tan(this float a) => (float)Math.Tan(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Atan(this float a) => (float)Math.Atan(a);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Atan2(this Vector2 vec) => (float)Math.Atan2(vec.y, vec.x);
	#endif
	}
}