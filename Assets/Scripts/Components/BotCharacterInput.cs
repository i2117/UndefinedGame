using UnityEngine;


namespace UndefinedExplosions.Components
{
    public class BotCharacterInput : ICharacterInput
    {
        public MovementDirection Direction { get; private set; }

        private const int MIN_TICKS_PER_CYCLE = 10;
        private const int MAX_TICKS_PER_CYCLE = 50;

        private int ticksBeforeNext;
        private MovementDirection currentDirection;

        public void UpdateInput()
        {
            if (ticksBeforeNext <= 0)
            {
                UpdateDirection();
            }
            ticksBeforeNext--;

            Direction = currentDirection;
        }

        private void UpdateDirection()
        {
            switch (Random.Range(-1, 2))
            {
                case -1:
                    currentDirection = MovementDirection.Left;
                    break;
                case 1:
                    currentDirection = MovementDirection.Right;
                    break;
                default:
                    currentDirection = MovementDirection.None;
                    break;
            }

            ticksBeforeNext = Random.Range(MIN_TICKS_PER_CYCLE, MAX_TICKS_PER_CYCLE + 1);
        }
    }
}
