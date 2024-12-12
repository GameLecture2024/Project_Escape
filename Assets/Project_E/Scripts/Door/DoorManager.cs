using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    // Door 정보를 먼저 가져와야 한다.

    public Door[] doorEntities;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheckDoorId(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CheckDoorId(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CheckDoorId(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CheckDoorId(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            CheckDoorId(4);
        }

    }

    public void CheckDoorId(int id)
    {
        foreach(var door in doorEntities)
        {
            if (door.id != id)
                continue;

            door.OpenDoor();
        }
    }
}
