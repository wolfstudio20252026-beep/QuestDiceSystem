using TMPro;
using UnityEngine;

public class QuestDice : MonoBehaviour
{
    //[Header("Modifiers")]
    //public int strength = 2;
    //public int charisma = 4;
    //public int intelligence = 3;
    //public int speed = 5;

    //void Start()
    //{
    //    CheckSkill(strength, 12);
    //    CheckSkill(charisma, 8);
    //    CheckSkill(speed, 20);
    //}

    [SerializeField] TMP_Text textSkill;


    public void CheckSkill(int modifier, int difficulty)
    {
        Debug.Log("modifier: " + modifier);
        int randomNum = Random.Range(1, 21);
        Debug.Log("randomNum: " + randomNum);
        int results = randomNum + modifier;
        Debug.Log("results: " + results);
        Debug.Log("difficulty: " + difficulty);

        if (results >= difficulty)
        {
            textSkill.text = "Ти пройшов!";
        }
        else
        {
            textSkill.text = "Ти програв!";
        }
    }
}
