using UnityEngine;
using UnityForProgrammers;

internal sealed class FakeMonoA : MonoBehaviour {
	internal FakeMonoB reference;
	
	private void Awake() {
		this.Link(ref reference);
		reference.field = 42;
	}
}