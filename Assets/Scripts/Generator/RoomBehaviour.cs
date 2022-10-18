using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBehaviour : MonoBehaviour
{
    public GameObject[] lanes; // 0 - Up; 1 - Down; 2 - Right; 3 - Left
    public GameObject[] doors;

    public void UpdateRoom(bool[] status) 
    {
        for (int i = 0; i < status.Length; i++)
        {
            doors[i].SetActive(!status[i]);
            lanes[i].SetActive(status[i]);
        }
    }
}
