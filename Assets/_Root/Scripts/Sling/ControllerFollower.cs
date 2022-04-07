using System;
using System.Linq;
using UnityEngine;


namespace Carnival.Sling
{
	public class ControllerFollower : MonoBehaviour
	{
		private Transform _leftControllerAnchor;

		private void Start() => _leftControllerAnchor
			= GameObject.Find("LeftHandAnchor").GetComponent<Transform>();
		
	}
}