using System.Runtime.CompilerServices;
#if UFP_PKG_MATHEMATICS
using Unity.Mathematics;
#endif
#if UFP_PKG_PHYSICS2D
using System.Collections.Generic;
using System.Linq;
#endif
using UnityEngine;

namespace UnityForProgrammers {
	/// <summary>Extensions to make working with Unity easier.</summary>
	public static class UnityExtensions {
		/// <summary>
		/// Makes it safe to use nullity operators on a Unity Object by making Unity's unique definition of "null" accurate.
		/// </summary>
		/// <param name="this">The object to check.</param>
		/// <returns><c>null</c> if <c>this == null</c> evaluates to <c>true</c>; otherwise, <c>this</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Object ReliableReference(this Object @this) => @this == null ? null : @this;
		
		/// <summary>
		/// Makes it safe to use nullity operators on a Unity Object by making Unity's unique definition of "null" accurate.
		/// </summary>
		/// <param name="this">The object to check.</param>
		/// <returns><c>null</c> if <c>this == null</c> evaluates to <c>true</c>; otherwise, <c>this</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Object RR(this Object @this) => @this.ReliableReference();
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Instantiate<T>(this T @this) where T : Object => Object.Instantiate(@this);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Instantiate<T>(this T @this, Vector3 position, Quaternion rotation) where T : Object => Object.Instantiate(@this, position, rotation);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Instantiate<T>(this T @this, Transform parent) where T : Object => Object.Instantiate(@this, parent);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Instantiate<T>(this T @this, Vector3 position, Quaternion rotation, Transform parent) where T : Object => Object.Instantiate(@this, position, rotation, parent);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Destroy(this Object @this) => Object.Destroy(@this);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Destroy(this Object @this, float t) => Object.Destroy(@this, t);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DestroyImmediate(this Object @this) => Object.DestroyImmediate(@this);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DestroyImmediate(this Object @this, bool allowDestroyingAssets) => Object.DestroyImmediate(@this, allowDestroyingAssets);
		
		/// <summary>Gets and assigns a component to a field.</summary>
		/// <typeparam name="TComponent">The type of component to fetch.</typeparam>
		/// <param name="this">The GameObject to fetch the component from.</param>
		/// <param name="comp">The field to assign the component to.</param>
		/// <returns>The GameObject.</returns>
		public static GameObject Link<TComponent>(this GameObject @this, ref TComponent comp) where TComponent : Component {
			comp = @this.GetComponent<TComponent>();
			return @this;
		}
		
		/// <summary>
		/// Checks if the layer mask contains the specified layer index.
		/// </summary>
		/// <param name="this">The layer mask to check.</param>
		/// <param name="layer">The index of the layer to check for.</param>
		/// <returns><c>true</c> if the layer mask contains the specified layer index; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Contains(this LayerMask @this, int layer) => ((int)@this).MaskContains(layer);
		
		/// <summary>
		/// Checks if the bit at index <c>layer</c> is true in the mask.
		/// </summary>
		/// <param name="mask">The mask to check.</param>
		/// <param name="index">The index of the bit to check.</param>
		/// <returns><c>true</c> if the bit at index <c>layer</c> is true in the mask; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool MaskContains(this int mask, int index) => mask == (mask | (1 << index));
		
		/// <summary>
		/// Creates an RGB color from HSV input.
		/// </summary>
		/// <param name="hsv">The Hue, Saturation, and Value of the color in a range of [0, 1].</param>
		/// <returns>An opaque color with HSV matching the input.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Color HSVToRGB(this Vector3 hsv) => Color.HSVToRGB(hsv.x, hsv.y, hsv.z);
		
		/// <summary>
		/// Creates an HSV vector from RGB input.
		/// </summary>
		/// <param name="rgb">The RGB color to convert.</param>
		/// <returns>A vector containing the Hue, Saturation, and Value of the input color in a range of [0, 1].</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 RGBToHSV(this Color rgb) {
			Color.RGBToHSV(rgb, out var h, out var s, out var v);
			return new(h, s, v);
		}
		
		/// <summary>
		/// Normalizes a rectangle's dimensions relative to a vector.
		/// </summary>
		/// <param name="this">The Rect instance to normalize.</param>
		/// <param name="space">The size of the space to normalize the Rect to.</param>
		/// <returns>A new Rect with normalized dimensions.</returns>
		public static Rect Normalize(this Rect @this, Vector2 space) =>
			new(@this.x / space.x, @this.y / space.y, @this.width / space.x, @this.height / space.y);
		
		/// <summary>
		/// Returns the size of a Texture as a Vector2Int.
		/// </summary>
		/// <param name="this">The Texture to get the size of.</param>
		/// <returns>A Vector2Int containing the width and height of the Texture.</returns>
		public static Vector2Int Size(this Texture @this) => new(@this.width, @this.height);
		
		/// <summary>
		/// Returns the size of a Texture as a Vector2.
		/// </summary>
		/// <param name="this">The Texture to get the size of.</param>
		/// <returns>A Vector2 containing the width and height of the Texture.</returns>
		public static Vector2 SizeToFloat(this Texture @this) => new(@this.width, @this.height);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetComponentInChildren<T>(this GameObject @this, out T component) where T : Component {
			component = @this.GetComponentInChildren<T>();
			return component != null;
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetComponentInChildren<T>(this MonoBehaviour @this, out T component) where T : Component =>
			@this.gameObject.TryGetComponentInChildren(out component);

		/// <summary>Clears a RenderTexture.</summary>
		/// <param name="this">The RenderTexture to clear.</param>
		public static void Clear(this RenderTexture @this, Color color = default) {
			RenderTexture.active = @this;
			GL.Clear(true, true, color);
			RenderTexture.active = null;
		}

		/// <summary>Converts a RenderTexture to a Texture2D. (NOTE THAT THIS USES ReadPixels, WHICH IS SLOW!)</summary>
		/// <param name="this">The RenderTexture to convert.</param>
		/// <returns>Texture2D containing the RenderTexture's data.</returns>
		public static Texture2D ConvertToTexture2D(this RenderTexture @this) { 
			Texture2D tex = new(@this.width, @this.height, TextureFormat.RGBA32, false);
			RenderTexture.active = @this;
			tex.ReadPixels(new Rect(0, 0, @this.width, @this.height), 0, 0);
			tex.Apply();
			RenderTexture.active = null;
			return tex;
		}
		
		/// <summary>Takes a sprite and generates a texture from it.</summary>
		public static Texture2D CropToTexture(this Sprite @this) {
			var cropped = new Texture2D((int)@this.rect.width, (int)@this.rect.height);

			Graphics.CopyTexture(
				@this.texture, 0, 0,
				(int)@this.rect.x, (int)@this.rect.y, (int)@this.rect.width, (int)@this.rect.height,
				cropped, 0, 0,
				0, 0
			);
			
			return cropped;
		}
		
	#if UFP_PKG_MATHEMATICS
		/// <summary>
		/// Returns the size of a Texture as an int2.
		/// </summary>
		/// <param name="this">The Texture to get the size of.</param>
		/// <returns>An int2 containing the width and height of the Texture.</returns>
		public static int2 SizeInt2(this Texture @this) => new(@this.width, @this.height);
		
		/// <summary>
		/// Returns the size of a Texture as a float2.
		/// </summary>
		/// <param name="this">The Texture to get the size of.</param>
		/// <returns>A float2 containing the width and height of the Texture.</returns>
		public static float2 SizeFloat2(this Texture @this) => new(@this.width, @this.height);
	#endif
		
	#if UFP_PKG_PHYSICS2D
		/// <summary>A blank contact filter to use when no filter is needed.</summary>
		private static readonly ContactFilter2D blankContactFilter = new();
		/// <summary>A blank collider array to use when you're not interested in the colliders themselves.</summary>
		public static readonly Collider2D[] uselessColliderArray = new Collider2D[0];
		
		/// <summary>Returns all points of contact with the rigidbody using the specified filter.</summary>
		public static IEnumerable<ContactPoint2D> GetAllContacts(this Rigidbody2D @this, ContactFilter2D filter) {
			var colliders = new List<Collider2D>();
			@this.GetAttachedColliders(colliders);
			
			IEnumerable<ContactPoint2D> ContactExtractor(Collider2D collider) {
				List<ContactPoint2D> contacts = new();
				collider.GetContacts(filter, contacts);
				return contacts;
			};
			
			return colliders.SelectMany(ContactExtractor);
		}

		/// <summary>Returns all points of contact with the rigidbody.</summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEnumerable<ContactPoint2D> GetAllContacts(this Rigidbody2D @this) =>
			@this.GetAllContacts(blankContactFilter);

		/// <summary>Checks if this collider is overlapping any other colliders using the specified filter.</summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckOverlap(this Collider2D @this, ContactFilter2D contactFilter) => 
			@this.OverlapCollider(contactFilter, uselessColliderArray) > 0;

		/// <summary>Checks if any collider in the collection is overlapping any other colliders using the specified filter.</summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckOverlap(this IEnumerable<Collider2D> @this, ContactFilter2D contactFilter) =>
			@this.Any(col => col.CheckOverlap(contactFilter));
	#endif
	}
}