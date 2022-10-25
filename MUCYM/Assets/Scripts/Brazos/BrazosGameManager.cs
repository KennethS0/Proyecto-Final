using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrazosGameManager : MonoBehaviour
{

    private BrazosUI_Manager ui_manager;
    private Animator animator;
    private float currentTime = 0;
    public AudioSource movementSoundUp;
    public AudioSource movementSoundDown;
    private float animationSpeed = 1;

    // [HideInInspector]
    // public int movements;

    // Start is called before the first frame update
    void Start()
    {
        ui_manager = GameObject.Find("Canvas").GetComponent<BrazosUI_Manager>();
        animator = gameObject.GetComponent<Animator>();
    }

    public void StartTimer()
    {
        ui_manager.StartTimer();
    }

    // Update is called once per frame

    public void RestartGame()
    {
        // movements = 0;
        // ui_manager.UpdateMoves(movements);
        ui_manager.ResetTimer();
    }
    
    public void MovementSoundUp()
    {
        movementSoundUp.Play();
    }

    public void MovementSoundDown()
    {
        movementSoundDown.Play();
    }

    public void OnButtonRelease()
    {
        //animator.speed = 0;
    }

    public void SetAnimationSpeed(string currentCube)
    {
        print(currentCube);
        switch (currentCube)
        {
            case "WoodCube":
                animationSpeed = 0.8f;
                break;
            case "MetalCube":
                animationSpeed = 0.5f;
                break;
            case "BlackCube":
                animationSpeed = 0.3f;
                break;
            default:
                animationSpeed = 1f;
                break;
        }
    }

    public void OnButtonPress()
    {
        animator.SetFloat("Direction", 1*animationSpeed);
        // animator.speed = 1;
        animator.PlayInFixedTime("Take 001", -1, 0);
        MovementSoundUp();
    }
    
    public void OnButton2Press()
    {
        animator.SetFloat("Direction", -1*animationSpeed);
        // animator.speed = 1.3f;
        animator.PlayInFixedTime("Take 001", -1, 1);
        MovementSoundDown();
    }

    public void OnButtonTopArmPalaPress()
    {
        animator.SetFloat("DirectionY", 1*animationSpeed);
        // animator.speed = 1;
        Debug.Log("Arm is ");
        Debug.Log(animator.GetBool("isArmUp"));
        Debug.Log("Pala is ");
        Debug.Log(animator.GetBool("isPalaUp"));
        if(!animator.GetBool("isArmUp") && animator.GetBool("isPalaUp"))
        {
            animator.PlayInFixedTime("Brazo Mov 1", -1, 0);
            MovementSoundUp();
        } 
        if(!animator.GetBool("isArmUp") && !animator.GetBool("isPalaUp"))
        {
            animator.PlayInFixedTime("Brazo Mov 2", -1, 0);
            MovementSoundUp();
        }
        animator.SetBool("isArmUp", true);
    }

    public void OnButtonDownArmPalaPress()
    {
        Debug.Log("Arm is ");
        Debug.Log(animator.GetBool("isArmUp"));
        Debug.Log("Pala is ");
        Debug.Log(animator.GetBool("isPalaUp"));
        animator.SetFloat("DirectionY", -1*animationSpeed);
        // animator.speed = 1.3f;
        if(animator.GetBool("isArmUp") && animator.GetBool("isPalaUp"))
        {
            animator.PlayInFixedTime("Brazo Mov 1", -1, 0);
            MovementSoundDown();
        }
        if(animator.GetBool("isArmUp") && !animator.GetBool("isPalaUp"))
        {
            animator.PlayInFixedTime("Brazo Mov 2", -1, 0);
            MovementSoundDown();
        }
        animator.SetBool("isArmUp", false);
    }

    public void OnButtonTopPalaPress()
    {
        Debug.Log("Arm is ");
        Debug.Log(animator.GetBool("isArmUp"));
        Debug.Log("Pala is ");
        Debug.Log(animator.GetBool("isPalaUp"));
        animator.SetFloat("DirectionX", -1*animationSpeed);
        // animator.speed = 1.3f;
        if(!animator.GetBool("isPalaUp") && animator.GetBool("isArmUp"))
        {
            animator.PlayInFixedTime("Pala Mov 1", -1, 0);
            MovementSoundUp();
        } 
        if(!animator.GetBool("isPalaUp") && !animator.GetBool("isArmUp"))
        {
            animator.PlayInFixedTime("Pala Mov 2", -1, 0);
            MovementSoundUp();
        }
        animator.SetBool("isPalaUp", true);
    }

    public void OnButtonDownPalaPress()
    {
        Debug.Log("Arm is ");
        Debug.Log(animator.GetBool("isArmUp"));
        Debug.Log("Pala is ");
        Debug.Log(animator.GetBool("isPalaUp"));
        animator.SetFloat("DirectionX", 1*animationSpeed);
        // animator.speed = 1;
        if(animator.GetBool("isPalaUp") && animator.GetBool("isArmUp"))
        {
            animator.PlayInFixedTime("Pala Mov 1", -1, 0);
            MovementSoundDown();
        } 
        if(animator.GetBool("isPalaUp") && !animator.GetBool("isArmUp"))
        {
            animator.PlayInFixedTime("Pala Mov 2", -1, 0);
            MovementSoundDown();
        }
        animator.SetBool("isPalaUp", false);
    }

}
