using UnityEngine;

public class UICondition : MonoBehaviour
{
    // Condition 클래스의 속성과 메서드를 모두 가진 맴버 변수로 생성
    // 필드에서 선언만 하는 이유는 인스펙터로 연결해서 쓰기 위함이고, UI 클래스에서 속성과 메서드를 쓰지 않기 때문 
    // 현 상태 : 참조 관계는 형성되어 접근은 가능하지만, 초기화(생성) 되지 않아 해당 클래스에서 호출은 불가능함
    // 만약 게임 오브젝트로 선언하고 인스펙터로 연결한다면 참조 관계가 형성되지 않음 

    public Condition health;
    public Condition hunger;
    public Condition stamina;

    private void Start()
    {
        CharacterManager.Instance.Player.condition.uiCondition = this;
    }
}
