using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip eatSound;

    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        eatSound = Resources.Load<AudioClip>("EAT");
        audioSrc = gameObject.GetComponent<AudioSource>();

    }


    public static void playEatSound()
    {
        audioSrc.PlayOneShot(eatSound);
    }
}


