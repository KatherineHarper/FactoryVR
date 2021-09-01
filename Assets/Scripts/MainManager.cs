using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VRFP
{
    public class MainManager : MonoBehaviour
    {
        public bool isTouching = false;
        public bool isEditor;
        public string UserName;
        public static MainManager Instance;

        public void Awake()
        {

            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }


            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }
}