//------------------------------------------------------------------------------
// <copyright file="PlayingSymbol.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using Library.Base;

namespace Library.Player
{
    /// <summary>
    /// Símbolo de entrada que representa el botón Play.
    /// </summary>
    public class PlayingSymbol : InputSymbol
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="PlayingSymbol"/>.
        /// </summary>
        public PlayingSymbol()
            : base("Play")
        {
        }
    }
}
