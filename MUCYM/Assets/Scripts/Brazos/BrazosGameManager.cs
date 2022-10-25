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
        // movements = 0;
        // ui_manager.UpdateMoves(movements);

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
            animator.speed = 1;
            animator.Play("Take 001");
            MovementSoundUp();
            Debug.Log("Pressed 1");
    }
    
    public void OnButton2Press()
    {
            animator.SetFloat("Direction", -1*animationSpeed);
            animator.speed = 1.3f;
            animator.Play("Take 001");
            MovementSoundDown();
            Debug.Log("Pressed 2");
    }

    public void OnButtonTopArmPalaPress()
    {
        animator.SetFloat("Direction", 1*animationSpeed);
        animator.speed = 1;
        animator.Play("Brazo 1 Mov 1");
        MovementSoundUp();
        Debug.Log("Pressed 1");
    }

    public void OnButtonDownArmPalaPress()
    {
        animator.SetFloat("Direction", -1*animationSpeed);
        animator.speed = 1.3f;
        animator.Play("Brazo 1 Mov 1");
        MovementSoundDown();
        Debug.Log("Pressed 2");
    }

    public void OnButtonTopPalaPress()
    {
        animator.SetFloat("Direction", 1*animationSpeed);
        animator.speed = 1;
        animator.Play("Brazo 1 Mov 2");
        MovementSoundUp();
        Debug.Log("Pressed 1");
    }

    public void OnButtonDownPalaPress()
    {
        animator.SetFloat("Direction", -1*animationSpeed);
        animator.speed = 1.3f;
        animator.Play("Brazo 1 Mov 2");
        MovementSoundDown();
        Debug.Log("Pressed 2");
    }

}
