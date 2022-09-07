using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class VBHandler : MonoBehaviour
{
    public Material VirtualButtonDefault;
    public Material VirtualButtonPressed;
    public float ButtonReleaseTimeDelay;
    public UnityEvent OnVirtualButtonPressed = new UnityEvent();
    public UnityEvent OnVirtualButtonReleased = new UnityEvent();


    VirtualButtonBehaviour[] mVirtualButtonBehaviours;

    void Awake()
    {
        // Register with the virtual buttons ObserverBehaviour
        mVirtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (var i = 0; i < mVirtualButtonBehaviours.Length; ++i)
        {
            mVirtualButtonBehaviours[i].RegisterOnButtonPressed(OnButtonPressed);
            mVirtualButtonBehaviours[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }

    void Destroy()
    {
        // Register with the virtual buttons ObserverBehaviour
        mVirtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (var i = 0; i < mVirtualButtonBehaviours.Length; ++i)
        {
            mVirtualButtonBehaviours[i].UnregisterOnButtonPressed(OnButtonPressed);
            mVirtualButtonBehaviours[i].UnregisterOnButtonReleased(OnButtonReleased);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Hello");
        SetVirtualButtonMaterial(VirtualButtonPressed);
        StopAllCoroutines();
        OnVirtualButtonPressed?.Invoke();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Bye");
        SetVirtualButtonMaterial(VirtualButtonDefault);
        StartCoroutine(DelayOnButtonReleasedEvent(ButtonReleaseTimeDelay));
    }

    void SetVirtualButtonMaterial(Material material)
    {
        // Set the Virtual Button material
        for (var i = 0; i < mVirtualButtonBehaviours.Length; ++i)
        {
            if (material != null)
                mVirtualButtonBehaviours[i].GetComponent<MeshRenderer>().sharedMaterial = material;
        }
    }

    IEnumerator DelayOnButtonReleasedEvent(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        OnVirtualButtonReleased?.Invoke();
    }

}