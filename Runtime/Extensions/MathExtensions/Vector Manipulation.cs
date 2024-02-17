using System;
using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		/// <summary>
		/// Applies a function to each component of the vector.
		/// </summary>
		/// <param name="this">The vector to apply the function to.</param>
		/// <param name="func">The function to apply to each component.</param>
		/// <returns>A new vector with the function applied to each component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Piecewise(this Vector2 @this, Func<float, float> func) => new(func(@this.x), func(@this.y));
		
		/// <summary>
		/// Applies a function to each component of the vector.
		/// </summary>
		/// <param name="this">The vector to apply the function to.</param>
		/// <param name="func">The function to apply to each component.</param>
		/// <returns>A new vector with the function applied to each component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Piecewise(this Vector3 @this, Func<float, float> func) => new(func(@this.x), func(@this.y), func(@this.z));
		
		/// <summary>
		/// Applies a function to each component of the vector.
		/// </summary>
		/// <param name="this">The vector to apply the function to.</param>
		/// <param name="func">The function to apply to each component.</param>
		/// <returns>A new vector with the function applied to each component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Piecewise(this Vector4 @this, Func<float, float> func) => new(func(@this.x), func(@this.y), func(@this.z), func(@this.w));
		
		/// <summary>
		/// Applies a function piecewise to two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <param name="func">A function applied to corresponding components in both vectors.</param>
		/// <returns>A new vector with components resulting from the function.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Piecewise(this Vector2 a, Vector2 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y));
		
		/// <summary>
		/// Applies a function piecewise to two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <param name="func">A function applied to corresponding components in both vectors.</param>
		/// <returns>A new vector with components resulting from the function.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Piecewise(this Vector3 a, Vector3 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y), func(a.z, b.z));
		
		/// <summary>
		/// Applies a function piecewise to two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <param name="func">A function applied to corresponding components in both vectors.</param>
		/// <returns>A new vector with components resulting from the function.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Piecewise(this Vector4 a, Vector4 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y), func(a.z, b.z), func(a.w, b.w));
		
		/// <summary>
		/// Returns a new vector with modified components.
		/// </summary>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		public static Vector2 With(this Vector2 @this, float? x = null, float? y = null) =>
			new(x ?? @this.x, y ?? @this.y);
		
		/// <summary>
		/// Returns a new vector with modified components.
		/// </summary>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <param name="z">The optional new z-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 With(this Vector3 @this, float? x = null, float? y = null, float? z = null) =>
			new(x ?? @this.x, y ?? @this.y, z ?? @this.z);
		
		/// <summary>
		/// Returns a new vector with modified components.
		/// </summary>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <param name="z">The optional new z-component.</param>
		/// <param name="w">The optional new w-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 With(this Vector4 @this, float? x = null, float? y = null, float? z = null, float? w = null) =>
			new(x ?? @this.x, y ?? @this.y, z ?? @this.z, w ?? @this.w);
		
		/// <summary>
		/// Adds an additional component to the vector.
		/// </summary>
		/// <param name="z">The new z-component.</param>
		/// <returns>The input vector modified with the new component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 With(this Vector2 @this, float z) =>
			new(@this.x, @this.y, z);
		
		/// <summary>
		/// Adds an additional component to the vector.
		/// </summary>
		/// <param name="w">The new w-component.</param>
		/// <returns>The input vector modified with the new component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 With(this Vector3 @this, float w) =>
			new(@this.x, @this.y, @this.z, w);
		
		/// <summary>
		/// Adds additional components to the vector.
		/// </summary>
		/// <param name="z">The new z-component.</param>
		/// <param name="w">The new w-component.</param>
		/// <returns>The input vector modified with the new component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 With(this Vector2 @this, float z, float w) =>
			new(@this.x, @this.y, z, w);
		
		/// <summary>
		/// Raises the dimensionality of the vector, and optionally modifies the existing components.
		/// </summary>
		/// <param name="z">The new z-component.</param>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 With(this Vector2 @this, float z, float? x = null, float? y = null) =>
			new(x ?? @this.x, y ?? @this.y, z);
		
		/// <summary>
		/// Raises the dimensionality of the vector, and optionally modifies the existing components.
		/// </summary>
		/// <param name="z">The new z-component.</param>
		/// <param name="z">The new w-component.</param>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 With(this Vector2 @this, float z, float w, float? x = null, float? y = null) =>
			new(x ?? @this.x, y ?? @this.y, z, w);
		
		/// <summary>
		/// Raises the dimensionality of the vector, and optionally modifies the existing components.
		/// </summary>
		/// <param name="z">The new w-component.</param>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <param name="z">The optional new z-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 With(this Vector3 @this, float w, float? x = null, float? y = null, float? z = null) =>
			new(x ?? @this.x, y ?? @this.y, z ?? @this.z, w);
		
	#if UFP_PKG_MATHEMATICS
		/// <summary>
		/// Applies a function to each component of the vector.
		/// </summary>
		/// <param name="this">The vector to apply the function to.</param>
		/// <param name="func">The function to apply to each component.</param>
		/// <returns>A new vector with the function applied to each component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Piecewise(this float2 @this, Func<float, float> func) => new(func(@this.x), func(@this.y));
		
		/// <summary>
		/// Applies a function to each component of the vector.
		/// </summary>
		/// <param name="this">The vector to apply the function to.</param>
		/// <param name="func">The function to apply to each component.</param>
		/// <returns>A new vector with the function applied to each component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Piecewise(this float3 @this, Func<float, float> func) => new(func(@this.x), func(@this.y), func(@this.z));
		
		/// <summary>
		/// Applies a function to each component of the vector.
		/// </summary>
		/// <param name="this">The vector to apply the function to.</param>
		/// <param name="func">The function to apply to each component.</param>
		/// <returns>A new vector with the function applied to each component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Piecewise(this float4 @this, Func<float, float> func) => new(func(@this.x), func(@this.y), func(@this.z), func(@this.w));
		
		/// <summary>
		/// Applies a function piecewise to two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <param name="func">A function applied to corresponding components in both vectors.</param>
		/// <returns>A new vector with components resulting from the function.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Piecewise(this float2 a, float2 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y));
		
		/// <summary>
		/// Applies a function piecewise to two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <param name="func">A function applied to corresponding components in both vectors.</param>
		/// <returns>A new vector with components resulting from the function.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Piecewise(this float3 a, float3 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y), func(a.z, b.z));
		
		/// <summary>
		/// Applies a function piecewise to two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <param name="func">A function applied to corresponding components in both vectors.</param>
		/// <returns>A new vector with components resulting from the function.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Piecewise(this float4 a, float4 b, Func<float, float, float> func) => new(func(a.x, b.x), func(a.y, b.y), func(a.z, b.z), func(a.w, b.w));
		
		/// <summary>
		/// Returns a new vector with modified components.
		/// </summary>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		public static float2 With(this float2 @this, float? x = null, float? y = null) =>
			new(x ?? @this.x, y ?? @this.y);
		
		/// <summary>
		/// Returns a new vector with modified components.
		/// </summary>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <param name="z">The optional new z-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 With(this float2 @this, float z, float? x = null, float? y = null) =>
			new(x ?? @this.x, y ?? @this.y, z);
		
		/// <summary>
		/// Returns a new vector with modified components.
		/// </summary>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <param name="z">The optional new z-component.</param>
		/// <param name="w">The optional new w-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 With(this float2 @this, float z, float w, float? x = null, float? y = null) =>
			new(x ?? @this.x, y ?? @this.y, z, w);
		
		/// <summary>
		/// Adds an additional component to the vector.
		/// </summary>
		/// <param name="z">The new z-component.</param>
		/// <returns>The input vector modified with the new component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 With(this float2 @this, float z) =>
			new(@this.x, @this.y, z);
		
		/// <summary>
		/// Adds an additional component to the vector.
		/// </summary>
		/// <param name="w">The new w-component.</param>
		/// <returns>The input vector modified with the new component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 With(this float3 @this, float w) =>
			new(@this.x, @this.y, @this.z, w);
		
		/// <summary>
		/// Adds additional components to the vector.
		/// </summary>
		/// <param name="z">The new z-component.</param>
		/// <param name="w">The new w-component.</param>
		/// <returns>The input vector modified with the new component.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 With(this float2 @this, float z, float w) =>
			new(@this.x, @this.y, z, w);
		
		/// <summary>
		/// Raises the dimensionality of the vector, and optionally modifies the existing components.
		/// </summary>
		/// <param name="z">The new z-component.</param>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 With(this float3 @this, float? x = null, float? y = null, float? z = null) =>
			new(x ?? @this.x, y ?? @this.y, z ?? @this.z);
		
		/// <summary>
		/// Raises the dimensionality of the vector, and optionally modifies the existing components.
		/// </summary>
		/// <param name="z">The new z-component.</param>
		/// <param name="z">The new w-component.</param>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 With(this float3 @this, float w, float? x = null, float? y = null, float? z = null) =>
			new(x ?? @this.x, y ?? @this.y, z ?? @this.z, w);
		
		/// <summary>
		/// Raises the dimensionality of the vector, and optionally modifies the existing components.
		/// </summary>
		/// <param name="z">The new w-component.</param>
		/// <param name="x">The optional new x-component.</param>
		/// <param name="y">The optional new y-component.</param>
		/// <param name="z">The optional new z-component.</param>
		/// <returns>The input vector modified with the new components.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 With(this float4 @this, float? x = null, float? y = null, float? z = null, float? w = null) =>
			new(x ?? @this.x, y ?? @this.y, z ?? @this.z, w ?? @this.w);
	#else
		// For now, nothing in this category uses Mathf or System.Math. If you need to use them, you can add them here.
	#endif
	}
}