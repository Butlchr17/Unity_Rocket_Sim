using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataLogger : MonoBehaviour
{
    private string filepath = Path.Combine(Application.persistentDataPath, "trajectory.csv");
    private List<string> data = new List<string>();
    private float timer = 0f;
    private float logInterval = 0.1f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= logInterval)
        {
            Vector3 pos = transform.position;
            Vector3 vel = GetComponent<Rigidbody>().velocity;
            data.Add($"{Time.time}, {pos.x}, {pos.y}, {pos.z}, {vel.x}, {vel.y}, {vel.z}");
            timer = 0f;
        }
    }

    void OnApplicationQuit()
    {
        data.Insert(0, "Time, PosX, PosY, Posz, VelX, VelY, VelZ"); // Header
        File.WriteAllLines(filepath, data);
    }

}
