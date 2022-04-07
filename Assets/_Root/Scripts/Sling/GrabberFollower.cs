using System.Linq;
using UnityEngine;


namespace Carnival.Sling
{
	public class GrabberFollower : MonoBehaviour
	{
		private OVRHand _rightHand;

		private void Start()
		{
			_rightHand = GetComponent<OVRHand>();

			var hands = FindObjectsOfType<OVRHand>();
			
		//	_rightHand = hands.FirstOrDefault(t => t.)
			//	OVRPlugin.
		}

		private void Update()
		{
			//transform.position = _grabberAnchorTransform.transform.position;
		}
	}
}
