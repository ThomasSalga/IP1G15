using UnityEngine;
using System.Collections;

public interface IFixable<T> : IDamageable<T>
{
    T MyMaxDurability { get; set; }

    void Fix(T amount);
}
