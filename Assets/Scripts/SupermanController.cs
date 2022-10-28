using UnityEngine;

public class SupermanController : MonoBehaviour
{
    [SerializeField] private Vector3 _speed;
    [SerializeField] private Vector3 Power;    

    private void FixedUpdate()
    {        
        GetComponent<Rigidbody>().velocity = _speed;
    }

    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.rigidbody == true)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            collision.rigidbody.AddForce(Power, ForceMode.Impulse);
            Debug.Log($"Мы столкнулись с {collision.gameObject.name}");            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
