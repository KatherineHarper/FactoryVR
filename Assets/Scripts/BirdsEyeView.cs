using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VRFP
{
    public class BirdsEyeView : MonoBehaviour
    {
        public GameObject BivPlane;
        public AudioSource Pop;

        public void ShowBIView()
        {
            Pop.Play();
            BivPlane.SetActive(true);
        }
        public void HideBIView()
        {
            Pop.Play();
            BivPlane.SetActive(false);
        }
    }
}
