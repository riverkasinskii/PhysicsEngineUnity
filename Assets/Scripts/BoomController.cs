using UnityEngine;

public class BoomController : MonoBehaviour
{
    [SerializeField] private float _timeToExplosion;    
    [SerializeField] private float _power;
    [SerializeField] private float _radius;
    private float _time = 0f;
       
    private void FixedUpdate()
    {
        _time -= Time.deltaTime;

        if (_time <= 0)
        {
            Boom();            
        }
    }

    private void Boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody b in blocks)
        {
            if (Vector3.Distance(transform.position, b.transform.position) < _radius)
            {
                Vector3 direction = b.transform.position - transform.position;

                b.AddForce((_radius - Vector3.Distance(transform.position, b.transform.position))
                    * _power * direction.normalized,
                    ForceMode.Impulse);
            }
        }
        _time = _timeToExplosion;

    }
}
