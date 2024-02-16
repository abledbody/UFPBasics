using System.Runtime.CompilerServices;

using UnityEngine;

namespace UnityForProgrammers {
	public static class UnityExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Object ReliableReference(this Object obj) => obj == null ? null : obj;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Object RR(this Object obj) => obj.ReliableReference();
		
		/// <summary>Checks if the layer mask contains the specified layer index.</summary>
		/// <param name="this">The layer mask to check.</param>
		/// <param name="layer">The index of the layer to check for.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Contains(this LayerMask @this, int layer) => ((int)@this).MaskContains(layer);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool MaskContains(this int mask, int layer) => mask == (mask | (1 << layer));

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Rect GetCanvasSpaceRect(this RectTransform @this) {
			Vector2 size = Vector2.Scale(@this.rect.size, @this.lossyScale);
			return new(
				@this.position.x - (@this.pivot.x * size.x),
				@this.position.y - (@this.pivot.y * size.y),
				size.x,
				size.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Color HSVToRGB(this Vector3 hsv) => Color.HSVToRGB(hsv.x, hsv.y, hsv.z);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 RGBToHSV(this Color rgb) {
			Color.RGBToHSV(rgb, out var h, out var s, out var v);
			return new(h, s, v);
		}
		
		public static Rect Normalize(this Rect @this, Vector2 space) => new(@this.x / space.x, @this.y / space.y, @this.width / space.x, @this.height / space.y);
		
		public static Vector2 Size(this Texture @this) => new(@this.width, @this.height);
		
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
		
	#if UFP_PKG_PHYSICS2D
		private static readonly ContactFilter2D blankContactFilter = new();
		public static readonly Collider2D[] uselessColliderArray = new Collider2D[0];
		
		/// <summary>Returns all points of contact with the rigidbody using the specified filter.</summary>
		public static IEnumerable<ContactPoint2D> GetAllContacts(this Rigidbody2D @this, ContactFilter2D filter) {
			var colliders = new List<Collider2D>();
			@this.GetAttachedColliders(colliders);
			
			IEnumerable<ContactPoint2D> ContactExtractor(Collider2D collider) {
				var contacts = new List<ContactPoint2D>();
				collider.GetContacts(filter, contacts);
				return contacts;
			};
			
			return colliders.SelectMany(ContactExtractor);
		}

		/// <summary>Returns all points of contact with the rigidbody.</summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEnumerable<ContactPoint2D> GetAllContacts(this Rigidbody2D @this) =>
			@this.GetAllContacts(blankContactFilter);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckOverlap(this Collider2D @this, ContactFilter2D contactFilter) => 
			@this.OverlapCollider(contactFilter, uselessColliderArray) > 0;


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckOverlap(this IEnumerable<Collider2D> @this, ContactFilter2D contactFilter) =>
			@this.Any(col => col.CheckOverlap(contactFilter));
	#endif
	}
}