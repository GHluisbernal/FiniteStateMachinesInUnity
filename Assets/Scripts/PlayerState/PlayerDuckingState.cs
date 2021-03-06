using UnityEngine;

public class PlayerDuckingState : PlayerBaseState
{
    public override void EnterState(PlayerController_FSM player)
    {
        player.SetExpression(player.duckingSprite);
        player.head.localPosition = new Vector3(player.head.localPosition.x, .5f, player.head.localPosition.z);
    }

    public override void OnCollitionEnter(PlayerController_FSM player)
    {
        throw new System.NotImplementedException();
    }

    public override void Update(PlayerController_FSM player)
    {
        if (Input.GetButtonUp("Duck"))
        {

            player.head.localPosition = new Vector3(player.head.localPosition.x, .8f, player.head.localPosition.z);
            player.TransitionToState(player.IdleState);

        }
    }
}
