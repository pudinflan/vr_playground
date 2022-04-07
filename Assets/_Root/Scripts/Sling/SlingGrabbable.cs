using UnityEngine;

namespace Carnival.Sling
{
	public class SlingGrabbable : OVRGrabbable
	{
		[Header("Sling Fields")]
		[SerializeField] private Transform _slingRailTransform;
		
		private void Update()
		{
			if (!isGrabbed)
			{
				return;
			}

			transform.LookAt(_slingRailTransform);
		}
	}
}
