using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonHandler : MonoBehaviour
{

    public Material VirtualButtonDefault;
    public Material VirtualButtonPressed;
    public float ButtonReleaseTimeDelay;
    public UnityEvent ButtonPressed = new UnityEvent();
    public UnityEvent ButtonReleased = new UnityEvent();

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Debug.Log("Touch");
            RayCastToScreen(Input.touches[0].position);
        }


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            RayCastToScreen(Input.mousePosition);
        }
    }

    private void RayCastToScreen(Vector2 position)
    {
        Ray ray = Camera.main.ScreenPointToRay(position);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == gameObject.name)
            {
                Debug.Log("Im a button");
                OnButtonPressed();
            }
        }
    }

    public void OnButtonPressed()
    {
        Debug.Log("Hello");
        SetVirtualButtonMaterial(VirtualButtonPressed);
        StopAllCoroutines();
        ButtonPressed?.Invoke();
    }

    public void OnButtonReleased()
    {
        Debug.Log("Bye");
        SetVirtualButtonMaterial(VirtualButtonDefault);
        StartCoroutine(DelayOnButtonReleasedEvent(ButtonReleaseTimeDelay));
    }

    void SetVirtualButtonMaterial(Material material)
    {
        if (material != null)
            gameObject.GetComponent<MeshRenderer>().sharedMaterial = material;
    }


    IEnumerator DelayOnButtonReleasedEvent(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        ButtonReleased?.Invoke();
    }
}
