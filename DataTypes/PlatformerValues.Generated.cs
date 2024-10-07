#pragma warning disable

namespace test_webrtc.DataTypes
{
    public partial class PlatformerValues
    {
        public string Name;
        public float MaxSpeedX;
        public float AccelerationTimeX;
        public float DecelerationTimeX;
        public float Gravity;
        public float MaxFallSpeed;
        public float JumpVelocity;
        public float JumpApplyLength;
        public bool JumpApplyByButtonHold;
        public bool UsesAcceleration;
        public bool CanFallThroughCloudPlatforms;
        public float CloudFallThroughDistance;
        public bool IsUsingCustomDeceleration;
        public float CustomDecelerationValue;
        public bool MoveSameSpeedOnSlopes;
        public decimal UphillFullSpeedSlope;
        public decimal UphillStopSpeedSlope;
        public decimal DownhillFullSpeedSlope;
        public decimal DownhillMaxSpeedSlope;
        public decimal DownhillMaxSpeedBoostPercentage;
        public bool CanClimb;
        public float MaxClimbingSpeed;
        public int InheritOrOverwriteAsInt;
        public const string Ground = "Ground";
        public const string Air = "Air";
        public static System.Collections.Generic.List<System.String> OrderedList = new System.Collections.Generic.List<System.String>
        {
        Ground
        ,Air
        };
        
        
        public override string ToString() => Name;
    }
}
