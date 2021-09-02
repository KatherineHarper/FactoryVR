using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
namespace VRFP
{
    public class NewTestScript
    {
       
        [Test]
        public void TestJasonList()
        {
            JsonList jsonList = new JsonList();
            //Assert the jasonList is not null
            List<string> list = jsonList.SearchName();
            
            Assert.IsNotNull(list);
        }


        [Test]
        public void TestTouch()
        {
            MainManager mainManager = new MainManager();
          bool Touch = mainManager.isTouching;
        

        Assert.IsFalse(Touch);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
