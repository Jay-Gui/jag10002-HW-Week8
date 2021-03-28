using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public LocationScriptableObject currentLocation;

    public Text locationNameText;
    public Text locationDescription;

    public GameObject buttonUp;
    public GameObject buttonDown;
    public GameObject buttonLeft;
    public GameObject buttonRight;

    // Start is called before the first frame update
    void Start()
    {
        UpdateLocation();
    }

    public void MoveDirection(int dir)
    {
        switch (dir)
        {
            case 0:
                currentLocation = currentLocation.locationUp;
                break;
            case 1:
                currentLocation = currentLocation.locationDown;
                break;
            case 2:
                currentLocation = currentLocation.locationLeft;
                break;
            case 3:
                currentLocation = currentLocation.locationRight;
                break;
            default:
                break;
        }
        
        UpdateLocation();
    }

    void UpdateLocation()
    {
        locationNameText.text = currentLocation.locationName;
        locationDescription.text = currentLocation.description;

        if (currentLocation.locationRight == null)
        {
            buttonRight.SetActive(false);
        }
        else
        {
            currentLocation.locationRight.locationLeft = currentLocation;
            buttonRight.SetActive(true);
        }

        if (currentLocation.locationUp == null)
        {
            buttonUp.SetActive(false);
        }
        else 
        {
            //currentLocation.locationUp.locationDown = currentLocation;
            buttonUp.SetActive(true);
        }
        

        if (currentLocation.locationDown == null)
        {
            buttonDown.SetActive(false);
        }
        else
        {
            //currentLocation.locationDown.locationUp = currentLocation;
            buttonDown.SetActive(true);
        }

        if (currentLocation.locationLeft == null)
        {
            buttonLeft.SetActive(false);
        }
        else
        {
            currentLocation.locationLeft.locationRight = currentLocation;
            buttonLeft.SetActive(true);
        }
    }
}