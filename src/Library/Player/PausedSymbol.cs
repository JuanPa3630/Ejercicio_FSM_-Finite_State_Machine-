//------------------------------------------------------------------------------
// <copyright file="PausedSymbol.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using Library.Base;

namespace Library.Player
{
    /// <summary>
    /// Símbolo de entrada que representa el botón Pause.
    /// </summary>
    public class PausedSymbol : InputSymbol
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="PausedSymbol"/>.
        /// </summary>
        public PausedSymbol()
            : base("Pause")
        {
        }
    }
}
