using UnityEngine;

public class Player : MonoBehaviour
{
    // 플레이어 데이터 관리 

    public PlayerController controller;
    public PlayerCondition condition;

    private void Awake()
    {
        CharacterManager.Instance.Player = this;
        controller = GetComponent<PlayerController>();
        condition = GetComponent<PlayerCondition>();
    }
}
