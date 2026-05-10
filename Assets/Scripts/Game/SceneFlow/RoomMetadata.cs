using UnityEngine;

public class RoomMetadata : MonoBehaviour
{
    [Header("Area")]
    public string AreaID;

    [Header("Room")]
    public string RoomID;
    public string DisplayName;
    public int RoomIndex;
    public bool InitialRoomStateResetOnEnter;
}
