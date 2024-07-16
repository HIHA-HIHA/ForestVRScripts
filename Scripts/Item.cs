using UnityEngine;

public enum TypeItem
{
    brysnika,
    klukva,
    moroshka,
    malina,
    chernika,
    defaultItem,
}

public class Item : MonoBehaviour
{
    [field: SerializeField] public TypeItem type { get; private set; }

    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;

    private float speed;

    private bool hasPickUped;

    [SerializeField]
    private Rigidbody rigidbody;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    private void FixedUpdate()
    {
        if (!hasPickUped)
        {
            rigidbody.velocity = transform.forward * speed * Time.deltaTime;
        }
    }

    public void PickUp()
    {
        hasPickUped = true;
    }

    public void Drop()
    {
        rigidbody.useGravity = true;
        rigidbody.isKinematic = false;
        rigidbody.constraints = RigidbodyConstraints.None;
    }
}
