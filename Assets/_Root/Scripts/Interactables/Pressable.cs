using UnityEngine;
using UnityEngine.Events;

namespace Carnival.Interactables
{
	public class Pressable : MonoBehaviour
	{
		[SerializeField] private UnityEvent _onPressed;

		private void OnTriggerEnter(Collider other)
		{
			var grabber = other.GetComponent<OVRGrabber>();

			if (grabber == null)
			{
				return;
			}
			_onPressed?.Invoke();
 
			Debug.Log("DETECTING PRESS");
		}
	}
}