using UnityEngine;

namespace Carnival.Interactables
{
	public class Throwable : OVRGrabbable
	{
		[Header("Throw Values")] [SerializeField] 
		private float _throwSpeedMultiplier = 2f;

		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
			base.GrabEnd(linearVelocity, angularVelocity);

			var rb = gameObject.GetComponent<Rigidbody>();
			rb.AddForce(linearVelocity * _throwSpeedMultiplier);
		}
	}
}