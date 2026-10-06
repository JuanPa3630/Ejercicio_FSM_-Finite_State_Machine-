//------------------------------------------------------------------------------
// <copyright file="TransitionFunction.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Library.Base
{
    /// <summary>
    /// Representa la relación entre un símbolo de entrada y el siguiente estado.
    /// </summary>
    public class TransitionFunction
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="TransitionFunction"/>.
        /// </summary>
        /// <param name="triggerInput">Símbolo que dispara la transición.</param>
        /// <param name="nextState">Estado destino de la transición.</param>
        public TransitionFunction(InputSymbol triggerInput, State nextState)
        {
            this.TriggerInput = triggerInput;
            this.NextState = nextState;
        }

        /// <summary>
        /// Obtiene el símbolo que activa la transición.
        /// </summary>
        public InputSymbol TriggerInput { get; }

        /// <summary>
        /// Obtiene el estado al que se transita cuando se dispara la transición.
        /// </summary>
        public State NextState { get; }

        /// <summary>
        /// Determina si la transición es disparada por el símbolo indicado.
        /// </summary>
        /// <param name="input">Símbolo de entrada a comprobar.</param>
        /// <returns><c>true</c> si la transición coincide con la entrada; en caso contrario, <c>false</c>.</returns>
        public bool IsTriggeredBy(InputSymbol input)
        {
            return this.TriggerInput == input;
        }
    }
}
