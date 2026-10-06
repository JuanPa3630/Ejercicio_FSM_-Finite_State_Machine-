//------------------------------------------------------------------------------
// <copyright file="Stopped.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Library.Base;

namespace Library.Player
{
    /// <summary>
    /// Estado del reproductor cuando está detenido.
    /// </summary>
    public class Stopped : State
    {
        /// <inheritdoc />
        public override void OnEnter()
        {
            Console.WriteLine("Reproductor detenido.");
        }
    }
}
