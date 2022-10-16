using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrazosGameManager : MonoBehaviour
{

    private BrazosUI_Manager ui_manager;
    private Animator animator;
    private float currentTime = 0;

    [HideInInspector]
    public int movements;

    // Start is called before the first frame update
    void Start()
    {
        ui_manager = GameObject.Find("Canvas").GetComponent<BrazosUI_Manager>();
        movements = 0;
        ui_manager.UpdateMoves(movements);

        animator = gameObject.GetComponent<Animator>();

    }

    public void StartTimer()
    {
        ui_manager.StartTimer();
    }

    // Update is called once per frame

    public void RestartGame()
    {
        movements = 0;
        ui_manager.UpdateMoves(movements);
        ui_manager.ResetTimer();
    }

    public void OnButtonRelease()
    {
        //animator.speed = 0;
    }
    public void OnButtonPress()
    {
            animator.SetFloat("Direction", 1);
            animator.speed = 1;
            animator.Play("Take 001");
            Debug.Log("Pressed 1");
    }
    
    public void OnButton2Press()
    {
            animator.SetFloat("Direction", -1);
            animator.speed = 1.3f;
            animator.Play("Take 001");
            Debug.Log("Pressed 2");
    }

}
