using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_animation : MonoBehaviour
{
    public VirtualButtonBehaviour vbBtnRight;
    public VirtualButtonBehaviour vbBtnLeft;
    public Animator armAnimation;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnRight.RegisterOnButtonPressed(OnButtonPressedRight);
        vbBtnRight.RegisterOnButtonReleased(OnButtonReleasedRight);
        vbBtnLeft.RegisterOnButtonPressed(OnButtonPressedLeft);
        vbBtnLeft.RegisterOnButtonReleased(OnButtonReleasedLeft);
        armAnimation.GetComponent<Animator>();
    }

    public void OnButtonPressedRight(VirtualButtonBehaviour vb)
    {
        armAnimation.Play("armAnimation");
        Debug.Log("BTN Pressed R");
    }

    public void OnButtonReleasedRight(VirtualButtonBehaviour vb)
    {
        //armAnimation.Play("none");
        Debug.Log("BTN released R");
    }

    public void OnButtonPressedLeft(VirtualButtonBehaviour vb)
    {
        armAnimation.Play("armAnimation");
        Debug.Log("BTN Pressed L");
    }

    public void OnButtonReleasedLeft(VirtualButtonBehaviour vb)
    {
        //armAnimation.Play("none");
        Debug.Log("BTN released L");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
