using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrazosGameManager : MonoBehaviour
{

    private BrazosUI_Manager ui_manager;

    [HideInInspector]
    public int movements;

    // Start is called before the first frame update
    void Start()
    {
        ui_manager = GameObject.Find("Canvas").GetComponent<BrazosUI_Manager>();
        movements = 0;
        ui_manager.UpdateMoves(movements);
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

    public void Test1()
    {
        Debug.Log("1");
    }
    public void Test2()
    {
        Debug.Log("2");
    }
    public void Test3()
    {
        Debug.Log("3");
    }
    public void Test4()
    {
        Debug.Log("4");
    }
}
