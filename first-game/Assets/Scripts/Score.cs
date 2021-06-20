using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject player;
    public Text score;
   
    void Update()
    {
        float scoreValue = player.transform.position.z / 3;
        score.text = scoreValue.ToString("0");
    }
}
