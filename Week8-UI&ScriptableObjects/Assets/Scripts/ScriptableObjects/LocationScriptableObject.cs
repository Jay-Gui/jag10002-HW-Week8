using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Location", 
    menuName = "ScriptableObjects/Location", order = 0)]

public class LocationScriptableObject : ScriptableObject
{
    public string locationName = "New Place";
    public string description = "Default Description";

    public LocationScriptableObject locationUp;
    public LocationScriptableObject locationDown;
    public LocationScriptableObject locationLeft;
    public LocationScriptableObject locationRight;
}
