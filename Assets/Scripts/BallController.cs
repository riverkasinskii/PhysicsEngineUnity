using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Vector3 Power;

    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(Power, ForceMode.Impulse);
    }
}
