using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable<float>, IHealable<float>
{
    public void damage(float damageAmount)
    {
    }

    public float health { get; set; }
}
