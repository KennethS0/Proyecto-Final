using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubeSelector : MonoBehaviour
{
    private string currentCube = "";
    public GameObject[] cubes;
    public UnityEvent<string> selectedCube = new UnityEvent<string>();


    private void RayCastToScreen(Vector2 position)
    {
        Ray ray = Camera.main.ScreenPointToRay(position);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {

                MoveToPlatform(hit.collider.gameObject);
        }
    }

    private void MoveToPlatform(GameObject cube)
    {
        if (currentCube == cube.name)
            currentCube = "";
        else
            currentCube = cube.name;

        foreach (GameObject aCube in cubes)
            {
                if (aCube.name == currentCube)
                {
                    aCube.SetActive(true);
                }
                else
                    aCube.SetActive(false);
            }  
        selectedCube?.Invoke(currentCube);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began)
        {
            RayCastToScreen(Input.touches[0].position);
        }


        if (Input.GetMouseButtonDown(0))
        {
            RayCastToScreen(Input.mousePosition);
        }
    }
}
