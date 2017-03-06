using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour {

    #region member
    public bool m_blocked;
    #endregion

    // Use this for initialization
    void Start ()
    {
        m_blocked = false;
    }

    // Update is called once per frame
    void Update ()
    {
	    
	}

    //void OnTriggerStay2D(Collider2D other)
    //{
    //    if (other.tag == "Defence")
    //        if (other.GetComponent<TowerParent>().m_state == DefenceState.Placed)
    //        {
    //            m_blocked = true;
    //        }
    //}

    void BlockThis()
    {
        m_blocked = true;
    }


    void OnTriggerExit2D(Collider2D other)
    {
        m_blocked = false;
    }

}
