using UnityEngine;
using System.Collections;

public interface IMovable
{
    float MySpeed { get; set; }
    int MyDirection { get; set; }

    void Move(float speed, int direction);
    void Stop();
}

