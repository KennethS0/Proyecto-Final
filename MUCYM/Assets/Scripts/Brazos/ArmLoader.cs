using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class ArmLoader : MonoBehaviour
{
    public void loadFixedArm(){
        SceneManager.LoadScene("BrazoPlataformaFijo");
    }
    public void loadRemovablePlatform(){
        SceneManager.LoadScene("BrazoDesmontablePlataforma");
    }
    public void loadShovelArm(){
        SceneManager.LoadScene("BrazoPala");
    }
    public void loadPlatform(){
        SceneManager.LoadScene("BrazoPlataforma");
    }
}
