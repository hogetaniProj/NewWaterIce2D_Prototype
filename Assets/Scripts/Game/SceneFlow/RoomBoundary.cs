using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class RoomBoundary : MonoBehaviour
{
    [SerializeField] private RoomMetadata roomMetadata;

    private BoxCollider2D boxCollider;

    public RoomMetadata RoomMetadata => roomMetadata;

    private void Awake()
    {
        CacheCollider();

        if (roomMetadata == null)
        {
            roomMetadata = GetComponentInParent<RoomMetadata>();
        }
    }

    private void Reset()
    {
        CacheCollider();
        boxCollider.isTrigger = true;
        roomMetadata = GetComponentInParent<RoomMetadata>();
    }

    public bool IsInside(Vector2 worldPosition)
    {
        CacheCollider();
        return boxCollider.OverlapPoint(worldPosition);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        CurrentRoomTracker tracker = CurrentRoomTracker.Instance;
        if (tracker != null)
        {
            tracker.NotifyBoundaryEnter(this, other);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        CurrentRoomTracker tracker = CurrentRoomTracker.Instance;
        if (tracker != null)
        {
            tracker.NotifyBoundaryExit(this, other);
        }
    }

    private void CacheCollider()
    {
        if (boxCollider == null)
        {
            boxCollider = GetComponent<BoxCollider2D>();
        }
    }
}
