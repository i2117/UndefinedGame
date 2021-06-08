using UnityEngine;
using UndefinedExplosions.Components;


namespace UndefinedExplosions
{
    [RequireComponent(typeof(Health))]
    public class Character : MonoBehaviour
    {
        [SerializeField] private bool isPlayer;
        [SerializeField] private float defaultMoveSpeed = 2;

        private ICharacterInput characterInput;
        private ICharacterMovement characterMovement;
        private Health health;

        private void Awake()
        {
            characterInput = isPlayer ? 
                new KeyboardCharacterInput() as ICharacterInput : 
                new BotCharacterInput();

            characterMovement = new CharacterHorizontalMovement(characterInput, transform, defaultMoveSpeed);
            health = GetComponent<Health>();
        }

        private void OnEnable()
        {
            health.OnDied += Die;
        }

        private void OnDisable()
        {
            health.OnDied -= Die;
        }

        private void Update()
        {
            characterInput.UpdateInput();
            characterMovement.Tick();
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }
}
