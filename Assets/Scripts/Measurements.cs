using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// in report.....////.....
namespace VRFP
{
    public class Measurements : MonoBehaviour
    {
        public Toggle MToggle;
        public Text MText;
        public GameObject[] MeasurementsCanvas;

        void Start()
        {
        
            
            
            MToggle.onValueChanged.AddListener(delegate {
                ToggleValueChanged(MToggle);
            });

          
            MText.text = "Measurements off";
            

        }  

        
        void ToggleValueChanged(Toggle change)
        {
            if (MToggle.isOn == true)
            {
                foreach (var item in MeasurementsCanvas)
                {
                    item.SetActive(true);
                }
            }

            if (MToggle.isOn == false)
            {
                foreach (var item in MeasurementsCanvas)
                {
                    item.SetActive(false);
                }
            }

            MText.text = "Measurements on";
        }
    }
}
