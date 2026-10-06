//------------------------------------------------------------------------------
// <copyright file="StateMachine.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Library.Base
{
    /// <summary>
    /// Gestiona una colección de estados y procesa entradas para cambiar el estado activo.
    /// </summary>
    public class StateMachine
    {
        private readonly List<State> states = new List<State>();

        /// <summary>
        /// Obtiene el estado actual de la máquina.
        /// </summary>
        public State CurrentState { get; private set; }

        /// <summary>
        /// Agrega un estado a la máquina y lo deja como inicial si es el primero.
        /// </summary>
        /// <param name="state">Estado a agregar.</param>
        public void AddState(State state)
        {
            this.states.Add(state);
            if (this.CurrentState == null)
            {
                this.CurrentState = state;
                this.CurrentState.OnEnter();
            }
        }

        /// <summary>
        /// Procesa una entrada y actualiza el estado actual si la transición es válida.
        /// </summary>
        /// <param name="input">Símbolo a procesar.</param>
        /// <returns><c>true</c> si la entrada provocó una transición válida; en caso contrario, <c>false</c>.</returns>
        public bool ProcessInput(InputSymbol input)
        {
            if (this.CurrentState == null)
            {
                return false;
            }

            State nextState = this.CurrentState.GetNextState(input);
            if (nextState == null)
            {
                return false;
            }

            this.CurrentState.OnExit();
            this.CurrentState = nextState;
            this.CurrentState.OnEnter();
            return true;
        }

        /// <summary>
        /// Procesa una secuencia de entradas y retorna el resultado global.
        /// </summary>
        /// <param name="inputs">Secuencia de símbolos.</param>
        /// <returns><c>true</c> si todas las entradas fueron válidas; en caso contrario, <c>false</c>.</returns>
        public bool ProcessInputs(InputSymbol[] inputs)
        {
            bool allValid = true;
            foreach (InputSymbol input in inputs)
            {
                if (!this.ProcessInput(input))
                {
                    allValid = false;
                }
            }

            return allValid;
        }
    }
}
