using System.Collections;
using System.Collections.Generic;
using UnityEngine.VFX;
using UnityEngine;

public class MushroomLight : MonoBehaviour
{
    //public Animator Animator;
    public GameObject GlowingMushrooms;
    public GameObject BoringAssMushrooms;
    public GameObject Fireflies;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Animator.SetTrigger("MushroomAppear");
            Fireflies.GetComponent<VisualEffect>().enabled = true;
            GlowingMushrooms.SetActive(true);
            BoringAssMushrooms.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Animator.SetTrigger("MushroomHide");
            Fireflies.GetComponent<VisualEffect>().enabled = false;
            GlowingMushrooms.SetActive(false);
            BoringAssMushrooms.SetActive(true);
        }
    }
}
