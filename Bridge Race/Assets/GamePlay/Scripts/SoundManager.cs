using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager: MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource stepSound;
    public AudioSource winSound;
    public static SoundManager ins;

    private void Awake()
    {
        ins = this;
    }

    public void PlayStepSound()
    {
        stepSound.Play();
    }

    public void PlayWinSound()
    {
        winSound.Play();
    }

}
