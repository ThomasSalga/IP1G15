using UnityEngine;
using System.Collections;

public interface IAttack<T> {

    T MyDamage { get; set; }
    Rigidbody2D MyRigidBody { get; } // readonly 
    GameObject MyTarget { get; set; }

    void Attack();
}
