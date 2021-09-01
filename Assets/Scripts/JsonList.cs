using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace VRFP
{
    public class JsonList
    {
        public List<string> ListOfNames = new List<string>();

        public List<string> SearchName()
        {

            DirectoryInfo dir = new DirectoryInfo(Application.dataPath);
            FileInfo[] info = dir.GetFiles("*.json");


            foreach (FileInfo item in info)
            {
                ListOfNames.Add(Path.GetFileNameWithoutExtension(item.Name));
            }
            return ListOfNames;

        }


    }
}
