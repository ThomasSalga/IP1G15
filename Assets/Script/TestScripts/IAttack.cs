using UnityEngine;
using System.Collections;

public interface IAttack<T> {

    T MyDamage { get; set; }
    Rigidbody2D MyRigidBody { get; } // readonly 

    void Attack(Collider2D other); // not sure about the mesh collider
}
