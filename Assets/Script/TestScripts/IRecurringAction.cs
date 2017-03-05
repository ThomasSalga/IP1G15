using UnityEngine;
using System.Collections;

public interface IRecurringAction {

    float MyActionTimeGap { get; set; }

    IEnumerator RecurAction();
}
