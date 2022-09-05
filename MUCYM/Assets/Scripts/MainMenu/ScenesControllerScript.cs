using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // Screen.orientation = ScreenOrientation.LandscapeLeft;//or right for right landscape
    }

    // Update is called once per frame
  

    public void LoadDisksGame()
    {
        SceneManager.LoadScene("DisksScene");
    }

    public void LoadFourEquations()
    {
        SceneManager.LoadScene("FourEquationsScene");
    }

    public void LoadRLHM()
    {
        SceneManager.LoadScene("Hanoi");
    }
    public void LoadCubos()
    {
        SceneManager.LoadScene("RL&HM");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadHerradura()
    {
        SceneManager.LoadScene("Herradura");
    }

    public void LoadArmMenu()
    {
        SceneManager.LoadScene("ArmMenu");
    }

    public void LoadColorSquares()
    {
        SceneManager.LoadScene("ColorSquaresScene");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
