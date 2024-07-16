using UnityEngine;
using UnityEngine.Events;

using Valve.VR.InteractionSystem;

public class Basket : MonoBehaviour
{
    [SerializeField] private UnityEvent onGetCorrectItem;
    [SerializeField] private UnityEvent onGetIncorrectItem;

    [SerializeField] TypeItem needType;

    [SerializeField] private bool destroyEnteredObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.TryGetComponent<Item>(out var item) && !item.transform.parent)
        {
            if (item.type == needType)
            {
                onGetCorrectItem?.Invoke();
            }
            else
                onGetIncorrectItem.Invoke();
        }

        Object objectForDestroy = null;
        if (destroyEnteredObject)
        {
            objectForDestroy = other.gameObject;
            PoolForDestroy.Instance.RemoveObject(other.gameObject);
        }
        else
            objectForDestroy = item;

        Destroy(objectForDestroy);

    }
}
