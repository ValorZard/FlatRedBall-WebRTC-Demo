
namespace test_webrtc.Entities
{
    public interface IPlatformer : FlatRedBall.Math.IPositionable
    {
        HorizontalDirection DirectionFacing { get; }
        bool IsOnGround { get; }
        string CurrentMovementName { get; }
        float MaxAbsoluteXVelocity { get; }
        float MaxAbsoluteYVelocity { get; }
        global::FlatRedBall.Input.I1DInput HorizontalInput {get;}
    }
}