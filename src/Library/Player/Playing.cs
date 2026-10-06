//------------------------------------------------------------------------------
// <copyright file="Playing.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Library.Base;

namespace Library.Player
{
    /// <summary>
    /// Estado del reproductor mientras se encuentra reproduciendo una canción.
    /// </summary>
    public class Playing : State
    {
        /// <inheritdoc />
        public override void OnEnter()
        {
            Console.WriteLine("Reproduciendo canción...");
        }
    }
}
