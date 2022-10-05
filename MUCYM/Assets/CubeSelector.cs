using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSelector : MonoBehaviour
{
    public GameObject spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void RayCastToScreen(Vector2 position)
    {
        print("Touch");
        Ray ray = Camera.main.ScreenPointToRay(position);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == "WoodCube")
            {
                Debug.Log("Wood");
            }
            if (hit.collider.name == "MetalCube")
            {
                Debug.Log("Metal");
            }
            if (hit.collider.name == "BlackCube")
            {
                Debug.Log("Black");
            }
            MoveToPlatform(hit.collider.gameObject);
        }
    }

    private void MoveToPlatform(GameObject cube)
    {
        GameObject clone = Instantiate(cube);
        clone.transform.SetParent(clone.transform, false);
        clone.transform.position = spawnPoint.transform.position;
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
