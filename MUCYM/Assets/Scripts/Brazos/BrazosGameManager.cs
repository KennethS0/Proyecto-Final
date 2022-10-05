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
        animator.Play("Take 001");
        /*animator.PlayInFixedTime("Take 001", -1, currentTime);
        animator.speed = 0.1f;
        currentTime += 0.1f;
        Debug.Log(currentTime);*/
    }

}
