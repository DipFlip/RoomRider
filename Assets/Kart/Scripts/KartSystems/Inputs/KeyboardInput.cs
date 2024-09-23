using UnityEngine;
using UnityEngine.InputSystem;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        private KartControls inputActions;

        private void OnEnable() {
            inputActions = new KartControls();
            inputActions.Enable();
        }

        private void OnDisable() {
            inputActions.Disable();
        }

        public override InputData GenerateInput() {
            var inputData = new InputData
            {
                Accelerate = inputActions.Kart.Accelerate.ReadValue<float>() > 0,
                Brake = inputActions.Kart.Brake.ReadValue<float>() > 0,
                TurnInput = inputActions.Kart.Turn.ReadValue<Vector2>().x
            };
            return inputData;
        }
    }
}