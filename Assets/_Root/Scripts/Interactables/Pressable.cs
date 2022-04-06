using UnityEngine;
using UnityEngine.Events;

public class Pressable : MonoBehaviour
{
    [SerializeField] private UnityEvent OnPress;

  void OnTriggerEnter(Collider other)
    {
        OVRGrabber grabber = other.GetComponent<OVRGrabber>();
       
        if (grabber == null)
           return;

        OnPress?.Invoke();

        Debug.Log("DETECTING PRESS");
    }
}
