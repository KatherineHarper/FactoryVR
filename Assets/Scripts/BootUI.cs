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
        string UsersHere;


        public void Enter()
        {
            MainManager.Instance.UserName = UserName.text;
            //CheckName();
            SceneManager.LoadScene("FactorySimulation", LoadSceneMode.Single);
        }

        void CheckName()
        {
            //if name in list
            // List<string> list = jsonList.SearchName();

            //if (userData.Contains(MainManager.Instance.UserName))
            // {
            //    SceneManager.LoadScene("FactorySimulation", LoadSceneMode.Single);
            // }
            // else { EnterDetailsPannel.SetActive(true); }
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




       // [ {Obj 1}, {Obj 2} ]
        public void GetUsersFromFile()
        {
            string path = Application.dataPath + "/" + "UsersHere" + ".json";
            if (File.Exists(path))
            {
               
                string json = File.ReadAllText(path);
               // User userData = JsonUtility.FromJson<User>(json);
                 JsonUtility.FromJsonOverwrite(json, userData);

                Debug.Log(userData.ID);
                Debug.Log(userData.UserName);


            }
        }
    }
}







