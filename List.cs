using System.Collections;
using System.Collections.Generic; // This contains library of list
using UnityEngine;

public class List : MonoBehaviour
{
   public List<int> age = new List<int>();
   public List<GameObject> gameObjects = new List<GameObject>();

   void Update(){
      if(Input.GetKeyDown(KeyCode.A)){
         // add in list
         age.Add(Random.Range(1,100));
      }
       if(Input.GetKeyDown(KeyCode.D)){
         // add in list
         age.Remove(age[Random.Range(0,age.Count)]);
      }
   }
}
