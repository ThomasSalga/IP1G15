using UnityEngine;
using System.Collections;

public interface IBuyable<T> {

    T MyPrice { get; set; }
}
