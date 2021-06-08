namespace UndefinedExplosions
{
    public enum MovementDirection
    {
        None,
        Left,
        Right
    }

    public interface ICharacterInput
    {
        void UpdateInput();
        MovementDirection Direction { get; }
    }
}
