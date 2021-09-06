using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




namespace VRFP
{
    public class BootUI : MonoBehaviour
    {
        public GameObject EnterDetailsPannel;
        JsonList jsonList = new JsonList();
        User userData = new User();
        User user = new User();
        public Text UserName;
        public bool isViewer;
        string UsersHere;


        public void Enter()
        {
            MainManager.Instance.UserName = UserName.text;
          
            SceneManager.LoadScene("FactorySimulation", LoadSceneMode.Single);
        }
        public void EnterAsView()
        {
            MainManager.Instance.isViewer = true;
            SceneManager.LoadScene("FactorySimulation", LoadSceneMode.Single);
        }


        public void SaveUserToFile()
        {

        
            user.UserName = UserName.text;
            user.ID = 5677;
            user.isEditor = true;
     
           

       


            string json = JsonUtility.ToJson(user);
            File.WriteAllText(Application.dataPath + "/" + "UsersHere" + ".json", json);
            //Debug.Log(user.AboutUser());
            
        }




      
        public void GetUsersFromFile()
        {
            string path = Application.dataPath + "/" + "UsersHere" + ".json";
            if (File.Exists(path))
            {
               
                string json = File.ReadAllText(path);
              
                 JsonUtility.FromJsonOverwrite(json, userData);

                Debug.Log(userData.ID);
                Debug.Log(userData.UserName);


            }
        }
    }
}







