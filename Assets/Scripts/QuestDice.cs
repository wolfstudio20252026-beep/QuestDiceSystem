using UnityEngine;

public class QuestDice : MonoBehaviour
{
    [Header("Modifiers")]
    public int strength = 2;
    public int charisma = 4;
    public int intelligence = 3;
    public int speed = 5;

    void Start()
    {
        CheckSkill(strength, 12);
        CheckSkill(charisma, 8);
        CheckSkill(speed, 20);
    }


    public void CheckSkill(int modifier, int difficulty)
    {
        int randomNum = Random.Range(1, 21);
        int results = randomNum + modifier;

        if (modifier >= difficulty)
        {
            Debug.Log("Ти пройшов!");
        }
        else
        {
            Debug.Log("Ти програв!");
        }
    }
}
