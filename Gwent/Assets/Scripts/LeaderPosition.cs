using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderPosition : MonoBehaviour
{
    public GameObject leader;
    public GameObject leaderArea;
    // Start is called before the first frame update
    void Start()
    {
        GameObject boardPosition = Instantiate(leader,new Vector3(0f,0f,0f),Quaternion.identity);
        boardPosition.transform.SetParent(leaderArea.transform,false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
