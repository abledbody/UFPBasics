using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#endif

namespace UnityForProgrammers {
	// This is where dreams of nice easy documentation go to die.
	public static partial class MathExtensions {
	#region SqrMagnitude
		/// <summary>
		/// Returns the squared magnitude of the vector.
		/// </summary>
		/// <param name="this">The vector to get the squared magnitude of.</param>
		/// <returns>The squared magnitude of the vector.</returns>
		/// <remarks>If your code is performance-critical, this is more efficient than using Magnitude,
		/// but at the cost of being harder to understand, and trickier to write formulas with.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this Vector2 @this) => @this.sqrMagnitude;
		
		/// <summary>
		/// Returns the squared magnitude of the vector.
		/// </summary>
		/// <param name="this">The vector to get the squared magnitude of.</param>
		/// <returns>The squared magnitude of the vector.</returns>
		/// <remarks>If your code is performance-critical, this is more efficient than using Magnitude,
		/// but at the cost of being harder to understand, and trickier to write formulas with.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this Vector3 @this) => @this.sqrMagnitude;
		
		/// <summary>
		/// Returns the squared magnitude of the vector.
		/// </summary>
		/// <param name="this">The vector to get the squared magnitude of.</param>
		/// <returns>The squared magnitude of the vector.</returns>
		/// <remarks>If your code is performance-critical, this is more efficient than using Magnitude,
		/// but at the cost of being harder to understand, and trickier to write formulas with.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this Vector4 @this) => @this.sqrMagnitude;
	#endregion
	
	#region Magnitude
		/// <summary>
		/// Returns the magnitude (or length) of the vector.
		/// </summary>
		/// <param name="this">The vector to get the magnitude of.</param>
		/// <returns>The magnitude of the vector.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this Vector2 @this) => @this.magnitude;
		
		/// <summary>
		/// Returns the magnitude (or length) of the vector.
		/// </summary>
		/// <param name="this">The vector to get the magnitude of.</param>
		/// <returns>The magnitude of the vector.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this Vector3 @this) => @this.magnitude;
		
		/// <summary>
		/// Returns the magnitude (or length) of the vector.
		/// </summary>
		/// <param name="this">The vector to get the magnitude of.</param>
		/// <returns>The magnitude of the vector.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this Vector4 @this) => @this.magnitude;
	#endregion
	
	#region Normalized
		/// <summary>
		/// Returns the vector with a magnitude of 1.
		/// </summary>
		/// <param name="this">The vector to normalize.</param>
		/// <returns>The normalized vector, or zero if the vector is zero</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Normalized(this Vector2 @this) => @this.normalized;
		
		/// <summary>
		/// Returns the vector with a magnitude of 1.
		/// </summary>
		/// <param name="this">The vector to normalize.</param>
		/// <returns>The normalized vector, or zero if the vector is zero</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Normalized(this Vector3 @this) => @this.normalized;
		
		/// <summary>
		/// Returns the vector with a magnitude of 1.
		/// </summary>
		/// <param name="this">The vector to normalize.</param>
		/// <returns>The normalized vector, or zero if the vector is zero</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Normalized(this Vector4 @this) => @this.normalized;
	#endregion
		
	#region WithMagnitude
		/// <summary>
		/// Returns the vector with the specified magnitude.
		/// </summary>
		/// <param name="this">The vector to change the magnitude of.</param>
		/// <param name="magnitude">The magnitude to set the vector to.</param>
		/// <returns>The vector with the specified magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 WithMagnitude(this Vector2 @this, float magnitude) => @this.Normalized() * magnitude;
		
		/// <summary>
		/// Returns the vector with the specified magnitude.
		/// </summary>
		/// <param name="this">The vector to change the magnitude of.</param>
		/// <param name="magnitude">The magnitude to set the vector to.</param>
		/// <returns>The vector with the specified magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 WithMagnitude(this Vector3 @this, float magnitude) => @this.Normalized() * magnitude;
		
		/// <summary>
		/// Returns the vector with the specified magnitude.
		/// </summary>
		/// <param name="this">The vector to change the magnitude of.</param>
		/// <param name="magnitude">The magnitude to set the vector to.</param>
		/// <returns>The vector with the specified magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 WithMagnitude(this Vector4 @this, float magnitude) => @this.Normalized() * magnitude;
	#endregion
		
	#region Dot
		/// <summary>
		/// Returns the dot product of two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The dot product of the two vectors.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this Vector2 a, Vector2 b) => Vector2.Dot(a, b);
		
		/// <summary>
		/// Returns the dot product of two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The dot product of the two vectors.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this Vector3 a, Vector3 b) => Vector3.Dot(a, b);
		
		/// <summary>
		/// Returns the dot product of two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The dot product of the two vectors.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this Vector4 a, Vector4 b) => Vector4.Dot(a, b);
	#endregion
		
	#region ProjectScalar
		/// <summary>
		/// Gets the scalar component of lhs which lies in the same direction as rhs.
		/// </summary>
		/// <param name="lhs">The value to project.</param>
		/// <param name="rhs">The value to project onto.</param>
		/// <returns>The scalar component of lhs which lies in the same direction as rhs.</returns>
		/// <remarks>Though this is done in one dimension, it is still has all of the applicable features of a scalar projection.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this float lhs, float rhs) => lhs * rhs.Sign();
		
		/// <summary>
		/// Gets the scalar component of lhs which lies in the same direction as rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The scalar component of lhs which lies in the same direction as rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this Vector2 lhs, Vector2 rhs) => lhs.Dot(rhs.Normalized());
		
		/// <summary>
		/// Gets the scalar component of lhs which lies in the same direction as rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The scalar component of lhs which lies in the same direction as rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this Vector3 lhs, Vector3 rhs) => lhs.Dot(rhs.Normalized());
		
		/// <summary>
		/// Gets the scalar component of lhs which lies in the same direction as rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The scalar component of lhs which lies in the same direction as rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this Vector4 lhs, Vector4 rhs) => lhs.Dot(rhs.Normalized());
	#endregion
	
	#region Project
		/// <summary>
		/// Gets the component of lhs that is parallel to rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The component of lhs that is parallel to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Project(this Vector2 lhs, Vector2 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
		
		/// <summary>
		/// Gets the component of lhs that is parallel to rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The component of lhs that is parallel to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Project(this Vector3 lhs, Vector3 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
		
		/// <summary>
		/// Gets the component of lhs that is parallel to rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The component of lhs that is parallel to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Project(this Vector4 lhs, Vector4 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
	#endregion
		
	#region ProjectOnNormal
		/// <summary>
		/// Gets the component of the vector that is parallel to normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to project.</param>
		/// <param name="normal">The vector to project onto.</param>
		/// <returns>The component of the vector that is parallel to normal.</returns>
		/// <remarks>Normalizing a vector can be expensive. This method is provided so that if you already have a normalized vector, you can avoid the cost of normalizing it again.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 ProjectOnNormal(this Vector2 @this, Vector2 normal) => @this.Dot(normal) * normal;
		
		/// <summary>
		/// Gets the point at which this point is closest to the line defined by normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to project.</param>
		/// <param name="normal">The vector to project onto.</param>
		/// <returns>The component of the vector that is parallel to normal.</returns>
		/// <remarks>Normalizing a vector can be expensive. This method is provided so that if you already have a normalized vector, you can avoid the cost of normalizing it again.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 ProjectOnNormal(this Vector3 @this, Vector3 normal) => @this.Dot(normal) * normal;
		
		/// <summary>
		/// Gets the point at which this point is closest to the line defined by normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to project.</param>
		/// <param name="normal">The vector to project onto.</param>
		/// <returns>The component of the vector that is parallel to normal.</returns>
		/// <remarks>Normalizing a vector can be expensive. This method is provided so that if you already have a normalized vector, you can avoid the cost of normalizing it again.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 ProjectOnNormal(this Vector4 @this, Vector4 normal) => @this.Dot(normal) * normal;
	#endregion
		
	#region Reject
		/// <summary>
		/// Gets the element of lhs that is perpendicular to rhs.
		/// </summary>
		/// <param name="lhs">The vector to reject.</param>
		/// <param name="rhs">The vector to reject from.</param>
		/// <returns>The element of lhs that is perpendicular to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Reject(this Vector2 lhs, Vector2 rhs) => lhs - lhs.Project(rhs);
		
		/// <summary>
		/// Gets the element of lhs that is perpendicular to rhs.
		/// </summary>
		/// <param name="lhs">The vector to reject.</param>
		/// <param name="rhs">The vector to reject from.</param>
		/// <returns>The element of lhs that is perpendicular to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Reject(this Vector3 lhs, Vector3 rhs) => lhs - lhs.Project(rhs);
		
		/// <summary>
		/// Gets the element of lhs that is perpendicular to rhs.
		/// </summary>
		/// <param name="lhs">The vector to reject.</param>
		/// <param name="rhs">The vector to reject from.</param>
		/// <returns>The element of lhs that is perpendicular to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Reject(this Vector4 lhs, Vector4 rhs) => lhs - lhs.Project(rhs);
	#endregion
	
	#region RejectFromNormal
		/// <summary>
		/// Gets the element of the vector that is perpendicular to normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to reject.</param>
		/// <param name="normal">The vector to reject from.</param>
		/// <returns>The element of the vector that is perpendicular to normal.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 RejectFromNormal(this Vector2 @this, Vector2 normal) => @this - @this.ProjectOnNormal(normal);
		
		/// <summary>
		/// Gets the element of the vector that is perpendicular to normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to reject.</param>
		/// <param name="normal">The vector to reject from.</param>
		/// <returns>The element of the vector that is perpendicular to normal.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 RejectFromNormal(this Vector3 @this, Vector3 normal) => @this - @this.ProjectOnNormal(normal);
		
		/// <summary>
		/// Gets the element of the vector that is perpendicular to normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to reject.</param>
		/// <param name="normal">The vector to reject from.</param>
		/// <returns>The element of the vector that is perpendicular to normal.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 RejectFromNormal(this Vector4 @this, Vector4 normal) => @this - @this.ProjectOnNormal(normal);
	#endregion
		
		/// <summary>
		/// Returns a vector that is perpendicular (rotated 90 degrees counterclockwise) to the input vector.
		/// </summary>
		/// <param name="this">The vector to get the perpendicular of.</param>
		/// <returns>The perpendicular vector.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Perpendicular(this Vector2 @this) => Vector2.Perpendicular(@this);
		
		/// <summary>
		/// Returns a vector that is orthogonal to the plane on which both input vectors lie.
		/// </summary>
		/// <param name="lhs">The first vector.</param>
		/// <param name="rhs">The second vector.</param>
		/// <returns>The cross product of the two vectors.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Cross(this Vector3 lhs, Vector3 rhs) => Vector3.Cross(lhs, rhs);
	
	#region Distance
		/// <summary>
		/// Returns the distance between two points.
		/// </summary>
		/// <param name="a">The first point.</param>
		/// <param name="b">The second point.</param>
		/// <returns>The distance between the two points.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this Vector2 a, Vector2 b) => Vector2.Distance(a, b);
		
		/// <summary>
		/// Returns the distance between two points.
		/// </summary>
		/// <param name="a">The first point.</param>
		/// <param name="b">The second point.</param>
		/// <returns>The distance between the two points.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this Vector3 a, Vector3 b) => Vector3.Distance(a, b);
		
		/// <summary>
		/// Returns the distance between two points.
		/// </summary>
		/// <param name="a">The first point.</param>
		/// <param name="b">The second point.</param>
		/// <returns>The distance between the two points.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this Vector4 a, Vector4 b) => Vector4.Distance(a, b);
	#endregion
		
	#if UFP_PKG_MATHEMATICS
		
	#region SqrMagnitude
		/// <summary>
		/// Returns the squared magnitude of the vector.
		/// </summary>
		/// <param name="this">The vector to get the squared magnitude of.</param>
		/// <returns>The squared magnitude of the vector.</returns>
		/// <remarks>If your code is performance-critical, this is more efficient than using Magnitude,
		/// but at the cost of being harder to understand, and trickier to write formulas with.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this float2 @this) => math.lengthsq(@this);
		
		/// <summary>
		/// Returns the squared magnitude of the vector.
		/// </summary>
		/// <param name="this">The vector to get the squared magnitude of.</param>
		/// <returns>The squared magnitude of the vector.</returns>
		/// <remarks>If your code is performance-critical, this is more efficient than using Magnitude,
		/// but at the cost of being harder to understand, and trickier to write formulas with.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this float3 @this) => math.lengthsq(@this);
		
		/// <summary>
		/// Returns the squared magnitude of the vector.
		/// </summary>
		/// <param name="this">The vector to get the squared magnitude of.</param>
		/// <returns>The squared magnitude of the vector.</returns>
		/// <remarks>If your code is performance-critical, this is more efficient than using Magnitude,
		/// but at the cost of being harder to understand, and trickier to write formulas with.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this float4 @this) => math.lengthsq(@this);
	#endregion
		
	#region Magnitude
		/// <summary>
		/// Returns the magnitude (or length) of the vector.
		/// </summary>
		/// <param name="this">The vector to get the magnitude of.</param>
		/// <returns>The magnitude of the vector.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this float2 @this) => math.length(@this);
		
		/// <summary>
		/// Returns the magnitude (or length) of the vector.
		/// </summary>
		/// <param name="this">The vector to get the magnitude of.</param>
		/// <returns>The magnitude of the vector.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this float3 @this) => math.length(@this);
		
		/// <summary>
		/// Returns the magnitude (or length) of the vector.
		/// </summary>
		/// <param name="this">The vector to get the magnitude of.</param>
		/// <returns>The magnitude of the vector.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this float4 @this) => math.length(@this);
	#endregion
		
	#region Normalized
		/// <summary>
		/// Returns the vector with a magnitude of 1.
		/// </summary>
		/// <param name="this">The vector to normalize.</param>
		/// <returns>The normalized vector, or zero if the vector is zero</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Normalized(this float2 @this) => math.normalize(@this);
		
		/// <summary>
		/// Returns the vector with a magnitude of 1.
		/// </summary>
		/// <param name="this">The vector to normalize.</param>
		/// <returns>The normalized vector, or zero if the vector is zero</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Normalized(this float3 @this) => math.normalize(@this);
		
		/// <summary>
		/// Returns the vector with a magnitude of 1.
		/// </summary>
		/// <param name="this">The vector to normalize.</param>
		/// <returns>The normalized vector, or zero if the vector is zero</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Normalized(this float4 @this) => math.normalize(@this);
	#endregion
		
	#region WithMagnitude
		/// <summary>
		/// Returns the vector with the specified magnitude.
		/// </summary>
		/// <param name="this">The vector to change the magnitude of.</param>
		/// <param name="magnitude">The magnitude to set the vector to.</param>
		/// <returns>The vector with the specified magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 WithMagnitude(this float2 @this, float magnitude) => @this.Normalized() * magnitude;
		
		/// <summary>
		/// Returns the vector with the specified magnitude.
		/// </summary>
		/// <param name="this">The vector to change the magnitude of.</param>
		/// <param name="magnitude">The magnitude to set the vector to.</param>
		/// <returns>The vector with the specified magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 WithMagnitude(this float3 @this, float magnitude) => @this.Normalized() * magnitude;
		
		/// <summary>
		/// Returns the vector with the specified magnitude.
		/// </summary>
		/// <param name="this">The vector to change the magnitude of.</param>
		/// <param name="magnitude">The magnitude to set the vector to.</param>
		/// <returns>The vector with the specified magnitude.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 WithMagnitude(this float4 @this, float magnitude) => @this.Normalized() * magnitude;
	#endregion
	
	#region Dot
		/// <summary>
		/// Returns the dot product of two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The dot product of the two vectors.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this float2 a, float2 b) => math.dot(a, b);
		
		/// <summary>
		/// Returns the dot product of two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The dot product of the two vectors.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this float3 a, float3 b) => math.dot(a, b);
		
		/// <summary>
		/// Returns the dot product of two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <returns>The dot product of the two vectors.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this float4 a, float4 b) => math.dot(a, b);
	#endregion
		
	#region ProjectScalar
		/// <summary>
		/// Gets the scalar component of lhs which lies in the same direction as rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The scalar component of lhs which lies in the same direction as rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this float2 lhs, float2 rhs) => lhs.Dot(rhs.Normalized());
		
		/// <summary>
		/// Gets the scalar component of lhs which lies in the same direction as rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The scalar component of lhs which lies in the same direction as rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this float3 lhs, float3 rhs) => lhs.Dot(rhs.Normalized());
		
		/// <summary>
		/// Gets the scalar component of lhs which lies in the same direction as rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The scalar component of lhs which lies in the same direction as rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this float4 lhs, float4 rhs) => lhs.Dot(rhs.Normalized());
	#endregion
	
	#region Project
		/// <summary>
		/// Gets the component of lhs that is parallel to rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The component of lhs that is parallel to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Project(this float2 lhs, float2 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
		
		/// <summary>
		/// Gets the component of lhs that is parallel to rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The component of lhs that is parallel to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Project(this float3 lhs, float3 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
		
		/// <summary>
		/// Gets the component of lhs that is parallel to rhs.
		/// </summary>
		/// <param name="lhs">The vector to project.</param>
		/// <param name="rhs">The vector to project onto.</param>
		/// <returns>The component of lhs that is parallel to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Project(this float4 lhs, float4 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
	#endregion
		
	#region ProjectOnNormal
		/// <summary>
		/// Gets the component of the vector that is parallel to normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to project.</param>
		/// <param name="normal">The vector to project onto.</param>
		/// <returns>The component of the vector that is parallel to normal.</returns>
		/// <remarks>Normalizing a vector can be expensive. This method is provided so that if you already have a normalized vector, you can avoid the cost of normalizing it again.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 ProjectOnNormal(this float2 @this, float2 normal) => @this.Dot(normal) * normal;
		
		/// <summary>
		/// /// Gets the component of the vector that is parallel to normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to project.</param>
		/// <param name="normal">The vector to project onto.</param>
		/// <returns>The component of the vector that is parallel to normal.</returns>
		/// <remarks>Normalizing a vector can be expensive. This method is provided so that if you already have a normalized vector, you can avoid the cost of normalizing it again.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 ProjectOnNormal(this float3 @this, float3 normal) => @this.Dot(normal) * normal;
		
		/// <summary>
		/// Gets the component of the vector that is parallel to normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to project.</param>
		/// <param name="normal">The vector to project onto.</param>
		/// <returns>The component of the vector that is parallel to normal.</returns>
		/// <remarks>Normalizing a vector can be expensive. This method is provided so that if you already have a normalized vector, you can avoid the cost of normalizing it again.</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 ProjectOnNormal(this float4 @this, float4 normal) => @this.Dot(normal) * normal;
	#endregion
		
	#region Reject
		/// <summary>
		/// Gets the element of lhs that is perpendicular to rhs.
		/// </summary>
		/// <param name="lhs">The vector to reject.</param>
		/// <param name="rhs">The vector to reject from.</param>
		/// <returns>The element of lhs that is perpendicular to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Reject(this float2 lhs, float2 rhs) => lhs - lhs.Project(rhs);
		
		/// <summary>
		/// Gets the element of lhs that is perpendicular to rhs.
		/// </summary>
		/// <param name="lhs">The vector to reject.</param>
		/// <param name="rhs">The vector to reject from.</param>
		/// <returns>The element of lhs that is perpendicular to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Reject(this float3 lhs, float3 rhs) => lhs - lhs.Project(rhs);
		
		/// <summary>
		/// Gets the element of lhs that is perpendicular to rhs.
		/// </summary>
		/// <param name="lhs">The vector to reject.</param>
		/// <param name="rhs">The vector to reject from.</param>
		/// <returns>The element of lhs that is perpendicular to rhs.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Reject(this float4 lhs, float4 rhs) => lhs - lhs.Project(rhs);
	#endregion
		
	#region RejectFromNormal
		/// <summary>
		/// Gets the element of the vector that is perpendicular to normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to reject.</param>
		/// <param name="normal">The vector to reject from.</param>
		/// <returns>The element of the vector that is perpendicular to normal.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 RejectFromNormal(this float2 @this, float2 normal) => @this - @this.ProjectOnNormal(normal);
		
		/// <summary>
		/// Gets the element of the vector that is perpendicular to normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to reject.</param>
		/// <param name="normal">The vector to reject from.</param>
		/// <returns>The element of the vector that is perpendicular to normal.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 RejectFromNormal(this float3 @this, float3 normal) => @this - @this.ProjectOnNormal(normal);
		
		/// <summary>
		/// Gets the element of the vector that is perpendicular to normal, provided that normal is normalized.
		/// </summary>
		/// <param name="this">The vector to reject.</param>
		/// <param name="normal">The vector to reject from.</param>
		/// <returns>The element of the vector that is perpendicular to normal.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 RejectFromNormal(this float4 @this, float4 normal) => @this - @this.ProjectOnNormal(normal);
	#endregion
		
		/// <summary>
		/// Returns a vector that is perpendicular (rotated 90 degrees counterclockwise) to the input vector.
		/// </summary>
		/// <param name="this">The vector to get the perpendicular of.</param>
		/// <returns>The perpendicular vector.</returns>
		/// <returns>The cross product of the two vectors.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Perpendicular(this float2 @this) => new(-@this.y, @this.x);
		
		/// <summary>
		/// Returns a vector that is orthogonal to the plane on which both input vectors lie.
		/// </summary>
		/// <param name="lhs">The first vector.</param>
		/// <param name="rhs">The second vector.</param>
		/// <returns>The cross product of the two vectors.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Cross(this float3 lhs, float3 rhs) => math.cross(lhs, rhs);
		
	#region Distance
		/// <summary>
		/// Returns the distance between two points.
		/// </summary>
		/// <param name="a">The first point.</param>
		/// <param name="b">The second point.</param>
		/// <returns>The distance between the two points.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this float2 a, float2 b) => (b - a).Magnitude();
		
		/// <summary>
		/// Returns the distance between two points.
		/// </summary>
		/// <param name="a">The first point.</param>
		/// <param name="b">The second point.</param>
		/// <returns>The distance between the two points.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this float3 a, float3 b) => (b - a).Magnitude();
		
		/// <summary>
		/// Returns the distance between two points.
		/// </summary>
		/// <param name="a">The first point.</param>
		/// <param name="b">The second point.</param>
		/// <returns>The distance between the two points.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this float4 a, float4 b) => (b - a).Magnitude();
	#endregion
	#else
		// For now, nothing in this category uses Mathf or System.Math. If you need to use them, you can add them here.
	#endif
	}
}