using UnityEngine;


namespace UndefinedExplosions.Components
{
    public class KeyboardCharacterInput : ICharacterInput
    {
        public MovementDirection Direction { get; private set; }

        public void UpdateInput()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Direction = MovementDirection.Left;
                return;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                Direction = MovementDirection.Right;
                return;
            }

            Direction = MovementDirection.None;
        }
    }
}
