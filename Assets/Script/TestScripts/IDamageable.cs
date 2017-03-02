using UnityEngine;
using System.Collections;

public interface IDamageable<T> {

    T MyDurability { get; set; }

    void TakeDamage(T amount);
}
