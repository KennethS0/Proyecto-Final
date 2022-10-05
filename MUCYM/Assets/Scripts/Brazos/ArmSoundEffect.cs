using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmSoundEffect : MonoBehaviour
{

    public AudioSource movementSoundUp;
    public AudioSource movementSoundDown;
    
    public void MovementSoundUp()
    {
        movementSoundUp.Play();
    }

    public void MovementSoundDown()
    {
        movementSoundDown.Play();
    }
}
