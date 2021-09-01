using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VRFP
{
    public class Return : MonoBehaviour
    {
        public void ReturnButton()
        {
            SceneManager.LoadScene("Boot", LoadSceneMode.Single);
        }
    }
}
