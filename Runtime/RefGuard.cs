using System;
using System.Runtime.CompilerServices;

/// <summary>Ensures that a reference is treated as null if it is disposed.</summary>
public readonly struct RefGuard<T> where T : class {
	private readonly T reference;
	private readonly Func<T, bool> disposedCheck;
	
	/// <summary>Creates a new RefGuard instance.</summary>
	/// <param name="reference">The reference to guard.</param>
	/// <param name="disposedCheck">A function that checks if the reference was disposed. Should return true in the case that the reference was disposed.</param>
	/// <exception cref="ArgumentNullException">Thrown when disposedCheck is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public RefGuard(T reference, Func<T, bool> disposedCheck) {
		this.reference = reference;
		this.disposedCheck = disposedCheck ?? throw new ArgumentNullException(nameof(disposedCheck));
	}
	
	/// <summary>Creates a new RefGuard instance with a default disposed check.</summary>
	/// <param name="reference">The reference to guard.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public RefGuard(T reference) {
		this.reference = reference;
		disposedCheck = r => r == null;
	}
	
	/// <summary>Returns the reference if it was not disposed, otherwise returns null.</summary
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly T Get() => disposedCheck(reference) ? default : reference;
	
	/// <summary>Performs an action on a guarded reference.</summary>
	/// <param name="action">The action to perform.</param>
	/// <returns>The RefGuard instance for chaining.</returns>
	/// <remarks>The action is always performed. The parameter will be null if the reference was disposed.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly RefGuard<T> Act(Action<T> action) {
		action(Get());
		return this;
	}
	
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator T(RefGuard<T> @this) => @this.Get();
}