using UnityEngine;

public class NullableType : MonoBehaviour
{
    void Update()
    {
        CreateUser(null, null, true);
    }

    void CreateUser(string? name, int? age, bool? isCool)
    {
        name = name ?? "Unknown"; // if name is null then use as Unknown
        age = age ?? 18; //if age is null then use age = 18;
        isCool = isCool ?? false;
        Debug.Log("Name : " + name);
        Debug.Log(name + " Age is :" + age);
        

        if(isCool == false){
            Debug.Log(name + " is Cool");
        }else
        {
            Debug.Log(name + " is not Cool"); 
        }
        
    }
}
