using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
// Structures provide better performance as it is value type. Using a value type will result in fewer objects
//  on the managed heap, which results in lesser load on the garbage collector (GC), less frequent GC cycles,
//  and consequently better performance. However, value types have their downsides too. 
// Passing around a big struct is definitely costlier than passing a reference,
//  that's one obvious problem.

[System.Serializable]
public struct Book{ //outside the class
    public int bookId;
    public string bookTitle;
    public string bookAuthor;
  }

public class Struct : MonoBehaviour
{

    public Book unityProgramming;

    void Start(){
        unityProgramming.bookId=1;
        unityProgramming.bookTitle="Unity Advance Programming";
        unityProgramming.bookAuthor="Rakesh Bhardwaj";
    }
}
