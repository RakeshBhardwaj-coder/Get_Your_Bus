using UnityEngine;

interface IDamageable<T> // generic because damage can be in float or int.
{
    // start with I keyword
    // make private method body like ();
    // make private variables as var{get; set;} 
    
    void damage(T damageAmount);
}

interface IHealable<T>{

    T health{get; set;}
    
}
