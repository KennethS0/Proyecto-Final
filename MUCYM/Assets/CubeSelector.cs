using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubeSelector : MonoBehaviour
{
    public GameObject cube;
    private string currentCube = "";
    private Renderer cubeRenderer;
    public UnityEvent<string> selectedCube = new UnityEvent<string>();
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<MeshRenderer>();
    }

    private void RayCastToScreen(Vector2 position)
    {
        Ray ray = Camera.main.ScreenPointToRay(position);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == "WoodCube"|| hit.collider.name == "MetalCube"|| hit.collider.name == "BlackCube")
            {
                MoveToPlatform(hit.collider.gameObject);
            }
        }
    }

    private void MoveToPlatform(GameObject cube)
    {
        if(cube.name == currentCube)
        {
            cubeRenderer.enabled = true;
            cubeRenderer.material = cube.GetComponent<MeshRenderer>().material;
            currentCube = cube.name;
        }
        else
        {
            cubeRenderer.enabled = false;
            currentCube = "";
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
