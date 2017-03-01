using UnityEngine;
using System.Collections;

public interface IMovable
{
    float MySpeed { get; set; }
    int MyDirection { get; set; }

    void Move();
    void Stop();
}

