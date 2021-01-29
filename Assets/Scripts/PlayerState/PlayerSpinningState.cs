using UnityEngine;

public class PlayerSpinningState : PlayerBaseState
{
    private float rotation = 0f;
    public override void EnterState(PlayerController_FSM player)
    {
        player.SetExpression(player.spinningSprite);
    }

    public override void OnCollitionEnter(PlayerController_FSM player)
    {
        player.transform.rotation = Quaternion.identity;
        player.TransitionToState(player.IdleState);
    }

    public override void Update(PlayerController_FSM player)
    {
        var amountToRotate = 900 * Time.deltaTime;
        rotation += amountToRotate;
        if (rotation < 360)
        {
            player.transform.Rotate(Vector3.up, amountToRotate);
        }
        else
        {
            player.transform.rotation = Quaternion.identity;
            player.TransitionToState(player.JumpingState);
        }
    }
}
