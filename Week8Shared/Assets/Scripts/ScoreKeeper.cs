using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int currentScore;


    public int CurrentScore
    {
        get
        {
            return currentScore;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //TODO Subscribe to OnPickup coin event
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
