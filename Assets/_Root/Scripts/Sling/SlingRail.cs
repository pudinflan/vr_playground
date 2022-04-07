using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingRail : MonoBehaviour
{
	[SerializeField] private Transform _slingGrabbableTransform;

	private void Update()
	{
		transform.rotation = Quaternion.LookRotation (_slingGrabbableTransform.transform.position - transform.position);
		transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y - 90, 0);
	}
}