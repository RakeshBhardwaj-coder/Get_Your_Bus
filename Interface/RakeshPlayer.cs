using UnityEngine;

public class RakeshPlayer : MonoBehaviour, IDamageable<int>, IHealable<int>
{
    public void damage(int damageAmount)
    {
        // you need method with public and body implementation '{}'
    }

    public int health { get; set; }
}
