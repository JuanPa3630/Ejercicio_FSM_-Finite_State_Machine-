//------------------------------------------------------------------------------
// <copyright file="State.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Library.Base
{
    /// <summary>
    /// Representa un estado dentro de una máquina de estados finitos.
    /// </summary>
    public class State
    {
        private readonly List<TransitionFunction> transitions = new List<TransitionFunction>();

        /// <summary>
        /// Agrega una transición desde este estado al destino indicado.
        /// </summary>
        /// <param name="input">Símbolo que activa la transición.</param>
        /// <param name="nextState">Estado siguiente.</param>
        public void AddTransition(InputSymbol input, State nextState)
        {
            this.transitions.Add(new TransitionFunction(input, nextState));
        }

        /// <summary>
        /// Obtiene el siguiente estado según la entrada recibida.
        /// </summary>
        /// <param name="input">Símbolo de entrada.</param>
        /// <returns>El estado siguiente o <c>null</c> si la entrada no se reconoce.</returns>
        public State GetNextState(InputSymbol input)
        {
            foreach (TransitionFunction transition in this.transitions)
            {
                if (transition.IsTriggeredBy(input))
                {
                    return transition.NextState;
                }
            }

            return null;
        }

        /// <summary>
        /// Ejecuta la lógica asociada al ingreso al estado.
        /// </summary>
        public virtual void OnEnter()
        {
        }

        /// <summary>
        /// Ejecuta la lógica asociada a la salida del estado.
        /// </summary>
        public virtual void OnExit()
        {
        }
    }
}
