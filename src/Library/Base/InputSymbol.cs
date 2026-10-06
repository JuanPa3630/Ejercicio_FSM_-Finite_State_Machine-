//------------------------------------------------------------------------------
// <copyright file="InputSymbol.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Library.Base
{
    /// <summary>
    /// Representa un símbolo de entrada que puede disparar una transición.
    /// </summary>
    public abstract class InputSymbol
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="InputSymbol"/>.
        /// </summary>
        /// <param name="name">Nombre del símbolo.</param>
        protected InputSymbol(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Obtiene el nombre legible del símbolo.
        /// </summary>
        public string Name { get; }

        /// <inheritdoc />
        public override string ToString()
        {
            return this.Name;
        }
    }
}
