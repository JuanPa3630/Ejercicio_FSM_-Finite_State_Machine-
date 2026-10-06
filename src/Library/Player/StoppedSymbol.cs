//------------------------------------------------------------------------------
// <copyright file="StoppedSymbol.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using Library.Base;

namespace Library.Player
{
    /// <summary>
    /// Símbolo de entrada que representa el botón Stop.
    /// </summary>
    public class StoppedSymbol : InputSymbol
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="StoppedSymbol"/>.
        /// </summary>
        public StoppedSymbol()
            : base("Stop")
        {
        }
    }
}
