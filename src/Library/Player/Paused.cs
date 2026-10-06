//------------------------------------------------------------------------------
// <copyright file="Paused.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Library.Base;

namespace Library.Player
{
    /// <summary>
    /// Estado del reproductor mientras la reproducción está en pausa.
    /// </summary>
    public class Paused : State
    {
        /// <inheritdoc />
        public override void OnEnter()
        {
            Console.WriteLine("Reproducción en pausa.");
        }
    }
}
