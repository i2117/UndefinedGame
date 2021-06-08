using UnityEngine;


namespace UndefinedExplosions.Components
{
    public class CharacterHorizontalMovement : ICharacterMovement
    {
        private readonly ICharacterInput characterInput;
        private readonly Transform characterTransform;
        private readonly float moveSpeed;

        public CharacterHorizontalMovement(ICharacterInput characterInput, Transform characterTransform, float moveSpeed)
        {
            this.characterInput = characterInput;
            this.characterTransform = characterTransform;
            this.moveSpeed = moveSpeed;
        }

        public void Tick()
        {
            if (characterInput.Direction == MovementDirection.None)
            {
                return;
            }
            var sign = characterInput.Direction == MovementDirection.Left ? -1 : 1;
            characterTransform.position += new Vector3(sign * moveSpeed * Time.deltaTime, 0, 0);
        }
    }
}
