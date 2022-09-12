using System.Collections;
using UnityEngine;

public class Enum : MonoBehaviour
{
    public enum EnemyState{
        Searching,
        Attacking,
        Die
    }
    public EnemyState currentEnemyState;

    void Start(){
        currentEnemyState = EnemyState.Searching;
    }
    void Update(){
    
        switch (currentEnemyState)
        {
            case EnemyState.Searching:
            Debug.Log("Searching...");
            break;

            case EnemyState.Attacking:
            Debug.Log("Attacking...");
            break;

            case EnemyState.Die:
            Debug.Log("Die...");
            break;
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            currentEnemyState = (EnemyState)Random.Range(0,3);
        }
    }
}
