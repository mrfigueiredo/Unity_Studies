using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVFXPlayer : MonoBehaviour
{
    public ParticleSystem vfxClick;

    public void OnClick()
    {
        if(vfxClick != null)
        {
            vfxClick.Play();
        }
    }
}
