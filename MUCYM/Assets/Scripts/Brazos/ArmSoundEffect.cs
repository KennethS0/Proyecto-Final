using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmSoundEffect : MonoBehaviour
{

    public AudioSource movementSound;
    public void MovementSound()
    {
        movementSound.Play();
    }
}
