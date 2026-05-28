using UnityEngine;
using UnityEngine.UI;

public class SkillButtonController : MonoBehaviour
{
    [SerializeField] QuestDice questDice;
    Button btn;
    public int skillModifier;
    public int difficulty;


    private void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(() => questDice.CheckSkill(skillModifier, difficulty));
    }
}
