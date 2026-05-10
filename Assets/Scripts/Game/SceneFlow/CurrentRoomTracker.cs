using UnityEngine;

public class CurrentRoomTracker : MonoBehaviour
{
    [SerializeField] private RoomMetadata initialRoom;
    [SerializeField] private Transform trackedTarget;

    public static CurrentRoomTracker Instance { get; private set; }

    public RoomMetadata CurrentRoom { get; private set; }
    public string CurrentRoomID => CurrentRoom != null ? CurrentRoom.RoomID : string.Empty;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogWarning("Multiple CurrentRoomTracker instances found. The newest instance will be used.");
        }

        Instance = this;

        if (initialRoom != null)
        {
            SetCurrentRoom(initialRoom);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    public void NotifyBoundaryEnter(RoomBoundary boundary, Collider2D other)
    {
        if (!ShouldTrack(other) || boundary == null || boundary.RoomMetadata == null)
        {
            return;
        }

        SetCurrentRoom(boundary.RoomMetadata);
    }

    public void NotifyBoundaryExit(RoomBoundary boundary, Collider2D other)
    {
        if (!ShouldTrack(other) || boundary == null || boundary.RoomMetadata == null)
        {
            return;
        }

        Debug.Log($"Exited RoomBoundary: {boundary.RoomMetadata.RoomID}");
    }

    public void SetTrackedTarget(Transform target)
    {
        trackedTarget = target;
    }

    public void SetCurrentRoom(RoomMetadata room)
    {
        if (room == null || CurrentRoom == room)
        {
            return;
        }

        CurrentRoom = room;
        Debug.Log($"Current Room: {CurrentRoom.RoomID}");
    }

    private bool ShouldTrack(Collider2D other)
    {
        if (other == null)
        {
            return false;
        }

        if (trackedTarget == null)
        {
            return true;
        }

        return other.transform == trackedTarget || other.transform.IsChildOf(trackedTarget);
    }
}
