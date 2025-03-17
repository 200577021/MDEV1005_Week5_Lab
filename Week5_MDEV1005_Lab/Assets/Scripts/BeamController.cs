using UnityEngine;

public class BeamController : MonoBehaviour
{

    public float speed =10.0f;
    [SerializeField] private float _timeToDestroy = 2.0f;
    void Start()
    {
        Destroy(gameObject, _timeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        MoveBeam();
    }

    private void MoveBeam()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 5);
    }
}
