


namespace test_webrtc.Entities
{
    public enum MovementType
    {
        Ground,
        Air,
        AfterDoubleJump
    }
    public enum HorizontalDirection
    {
        Left,
        Right
    }

    public static class HorizontalDirectionExtensions
    {
        public static HorizontalDirection GetInverse(this HorizontalDirection direction)
        {
            return direction == HorizontalDirection.Left ?
                HorizontalDirection.Right :
                HorizontalDirection.Left;
        }


        public static float XSign(this HorizontalDirection direction) => direction == HorizontalDirection.Left
            ? -1
            : 1;
    }
}

