using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSelector : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject referenceCube;
    // Start is called before the first frame update
    void Start()
    {
        
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
        GameObject clone = Instantiate(cube);
        clone.transform.SetParent(clone.transform, false);
        clone.transform.position = spawnPoint.transform.position;
        clone.transform.localScale = referenceCube.transform.localScale;
        clone.GetComponent<Rigidbody>().useGravity = true;
        Destroy(clone, 5f);
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
