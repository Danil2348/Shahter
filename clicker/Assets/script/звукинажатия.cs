using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class звукинажатия : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;
    public void HoverSound()
    {
        myFx.PlayOneShot(hoverFx);
    }

    // Update is called once per frame
    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
    }
}
