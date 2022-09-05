using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmSoundEffect : MonoBehaviour
{

    public AudioSource movementSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MovementSound()
    {
        movementSound.Play();
    }
}
