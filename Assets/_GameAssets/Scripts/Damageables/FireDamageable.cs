using UnityEngine;

public class FireDamageable : MonoBehaviour, IDamageable
{

    [SerializeField] private float _force = 20f;
    public void GiveDamage(Rigidbody playerRigidbody, Transform playerVisualTransform)
    {
        HealthManager.Instance.Damage(1);
        playerRigidbody.AddForce(-playerVisualTransform.forward * _force, ForceMode.Impulse);
        Destroy(gameObject);
    }
}
