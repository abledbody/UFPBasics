using System;
using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Piecewise(this Vector2 vec, Func<float, float> func) => new(func(vec.x), func(vec.y));
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Piecewise(this Vector2 a, Vector2 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y));
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Piecewise(this Vector3 vec, Func<float, float> func) => new(func(vec.x), func(vec.y), func(vec.z));
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Piecewise(this Vector3 a, Vector3 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y), func(a.z, b.z));
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Piecewise(this Vector4 vec, Func<float, float> func) => new(func(vec.x), func(vec.y), func(vec.z), func(vec.w));
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Piecewise(this Vector4 a, Vector4 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y), func(a.z, b.z), func(a.w, b.w));
		
		public static Vector2 With(this Vector2 vec, float? x = null, float? y = null) =>
			new(x ?? vec.x, y ?? vec.y);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 With(this Vector2 vec, float z, float? x = null, float? y = null) =>
			new(x ?? vec.x, y ?? vec.y, z);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 With(this Vector2 vec, float z, float w, float? x = null, float? y = null) =>
			new(x ?? vec.x, y ?? vec.y, z, w);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 With(this Vector3 vec, float? x = null, float? y = null, float? z = null) =>
			new(x ?? vec.x, y ?? vec.y, z ?? vec.z);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 With(this Vector3 vec, float w, float? x = null, float? y = null, float? z = null) =>
			new(x ?? vec.x, y ?? vec.y, z ?? vec.z, w);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 With(this Vector4 vec, float? x = null, float? y = null, float? z = null, float? w = null) =>
			new(x ?? vec.x, y ?? vec.y, z ?? vec.z, w ?? vec.w);
		
	#if UFP_PKG_MATHEMATICS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Piecewise(this float2 vec, Func<float, float> func) => new(func(vec.x), func(vec.y));
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Piecewise(this float2 a, float2 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y));
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Piecewise(this float3 vec, Func<float, float> func) => new(func(vec.x), func(vec.y), func(vec.z));
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Piecewise(this float3 a, float3 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y), func(a.z, b.z));
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Piecewise(this float4 vec, Func<float, float> func) => new(func(vec.x), func(vec.y), func(vec.z), func(vec.w));
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Piecewise(this float4 a, float4 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y), func(a.z, b.z), func(a.w, b.w));
		
		public static float2 With(this float2 vec, float? x = null, float? y = null) =>
			new(x ?? vec.x, y ?? vec.y);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 With(this float2 vec, float z, float? x = null, float? y = null) =>
			new(x ?? vec.x, y ?? vec.y, z);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 With(this float2 vec, float z, float w, float? x = null, float? y = null) =>
			new(x ?? vec.x, y ?? vec.y, z, w);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 With(this float3 vec, float? x = null, float? y = null, float? z = null) =>
			new(x ?? vec.x, y ?? vec.y, z ?? vec.z);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 With(this float3 vec, float w, float? x = null, float? y = null, float? z = null) =>
			new(x ?? vec.x, y ?? vec.y, z ?? vec.z, w);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 With(this float4 vec, float? x = null, float? y = null, float? z = null, float? w = null) =>
			new(x ?? vec.x, y ?? vec.y, z ?? vec.z, w ?? vec.w);
	#else
		// For now, nothing in this category uses Mathf or System.Math. If you need to use them, you can add them here.
	#endif
	}
}