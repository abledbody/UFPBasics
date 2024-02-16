using System.Runtime.CompilerServices;
using UnityEngine;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#endif

namespace UnityForProgrammers {
	public static partial class MathExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this Vector2 val) => val.sqrMagnitude;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this Vector3 val) => val.sqrMagnitude;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this Vector4 val) => val.sqrMagnitude;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this Vector2 val) => val.magnitude;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this Vector3 val) => val.magnitude;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this Vector4 val) => val.magnitude;
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Normalized(this Vector2 val) => val.normalized;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Normalized(this Vector3 val) => val.normalized;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Normalized(this Vector4 val) => val.normalized;
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 WithMagnitude(this Vector2 vec, float magnitude) => vec.Normalized() * magnitude;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 WithMagnitude(this Vector3 vec, float magnitude) => vec.Normalized() * magnitude;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 WithMagnitude(this Vector4 vec, float magnitude) => vec.Normalized() * magnitude;
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this Vector2 a, Vector2 b) => Vector2.Dot(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this Vector3 a, Vector3 b) => Vector3.Dot(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this Vector4 a, Vector4 b) => Vector4.Dot(a, b);
		
		/// <summary>
		/// Projects lhs onto rhs. If rhs is negative, lhs is negated.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this float lhs, float rhs) => lhs * rhs.Sign();
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this Vector2 lhs, Vector2 rhs) => lhs.Dot(rhs.Normalized());
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this Vector3 lhs, Vector3 rhs) => lhs.Dot(rhs.Normalized());
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this Vector4 lhs, Vector4 rhs) => lhs.Dot(rhs.Normalized());
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Project(this Vector2 lhs, Vector2 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Project(this Vector3 lhs, Vector3 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Project(this Vector4 lhs, Vector4 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 ProjectOnNormal(this Vector2 @this, Vector2 normal) => @this.Dot(normal) * normal;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 ProjectOnNormal(this Vector3 @this, Vector3 normal) => @this.Dot(normal) * normal;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 ProjectOnNormal(this Vector4 @this, Vector4 normal) => @this.Dot(normal) * normal;
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Reject(this Vector2 lhs, Vector2 rhs) => lhs - lhs.Project(rhs);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 RejectFromNormal(this Vector2 @this, Vector2 normal) => @this - @this.ProjectOnNormal(normal);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Reject(this Vector3 lhs, Vector3 rhs) => lhs - lhs.Project(rhs);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 RejectFromNormal(this Vector3 @this, Vector3 normal) => @this - @this.ProjectOnNormal(normal);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Reject(this Vector4 lhs, Vector4 rhs) => lhs - lhs.Project(rhs);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 RejectFromNormal(this Vector4 @this, Vector4 normal) => @this - @this.ProjectOnNormal(normal);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Perpendicular(this Vector2 @this) => Vector2.Perpendicular(@this);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Cross(this Vector3 lhs, Vector3 rhs) => Vector3.Cross(lhs, rhs);
	
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this Vector2 a, Vector2 b) => Vector2.Distance(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this Vector3 a, Vector3 b) => Vector3.Distance(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this Vector4 a, Vector4 b) => Vector4.Distance(a, b);

	#if UFP_PKG_MATHEMATICS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this float2 val) => math.lengthsq(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this float3 val) => math.lengthsq(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(this float4 val) => math.lengthsq(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this float2 val) => math.length(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this float3 val) => math.length(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(this float4 val) => math.length(val);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Normalized(this float2 val) => math.normalize(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Normalized(this float3 val) => math.normalize(val);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Normalized(this float4 val) => math.normalize(val);
	
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 WithMagnitude(this float2 vec, float magnitude) => vec.Normalized() * magnitude;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 WithMagnitude(this float3 vec, float magnitude) => vec.Normalized() * magnitude;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 WithMagnitude(this float4 vec, float magnitude) => vec.Normalized() * magnitude;
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this float2 a, float2 b) => math.dot(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this float3 a, float3 b) => math.dot(a, b);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(this float4 a, float4 b) => math.dot(a, b);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this float2 lhs, float2 rhs) => lhs.Dot(rhs.Normalized());
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this float3 lhs, float3 rhs) => lhs.Dot(rhs.Normalized());
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ProjectScalar(this float4 lhs, float4 rhs) => lhs.Dot(rhs.Normalized());
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Project(this float2 lhs, float2 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Project(this float3 lhs, float3 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Project(this float4 lhs, float4 rhs) => lhs.Dot(rhs) / rhs.SqrMagnitude() * rhs;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 ProjectOnNormal(this float2 @this, float2 normal) => @this.Dot(normal) * normal;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 ProjectOnNormal(this float3 @this, float3 normal) => @this.Dot(normal) * normal;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 ProjectOnNormal(this float4 @this, float4 normal) => @this.Dot(normal) * normal;
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Reject(this float2 lhs, float2 rhs) => lhs - lhs.Project(rhs);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 RejectFromNormal(this float2 @this, float2 normal) => @this - @this.ProjectOnNormal(normal);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Reject(this float3 lhs, float3 rhs) => lhs - lhs.Project(rhs);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 RejectFromNormal(this float3 @this, float3 normal) => @this - @this.ProjectOnNormal(normal);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 Reject(this float4 lhs, float4 rhs) => lhs - lhs.Project(rhs);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 RejectFromNormal(this float4 @this, float4 normal) => @this - @this.ProjectOnNormal(normal);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 Perpendicular(this float2 vec) => new(-vec.y, vec.x);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 Cross(this float3 lhs, float3 rhs) => math.cross(lhs, rhs);
	
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this float2 a, float2 b) => (b - a).Magnitude();
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this float3 a, float3 b) => (b - a).Magnitude();
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(this float4 a, float4 b) => (b - a).Magnitude();
	#else
		// For now, nothing in this category uses Mathf or System.Math. If you need to use them, you can add them here.
	#endif
	}
}