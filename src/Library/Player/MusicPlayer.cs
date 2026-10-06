//------------------------------------------------------------------------------
// <copyright file="MusicPlayer.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using Library.Base;

namespace Library.Player
{
    /// <summary>
    /// Reproductor de música basado en una máquina de estados finitos.
    /// </summary>
    public class MusicPlayer
    {
        private readonly StateMachine stateMachine = new StateMachine();
        private readonly InputSymbol play = new PlayingSymbol();
        private readonly InputSymbol pause = new PausedSymbol();
        private readonly InputSymbol stop = new StoppedSymbol();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="MusicPlayer"/>.
        /// </summary>
        public MusicPlayer()
        {
            var stopped = new Stopped();
            var playing = new Playing();
            var paused = new Paused();

            stopped.AddTransition(this.play, playing);
            playing.AddTransition(this.pause, paused);
            playing.AddTransition(this.stop, stopped);
            paused.AddTransition(this.play, playing);
            paused.AddTransition(this.stop, stopped);

            this.stateMachine.AddState(stopped);
            this.stateMachine.AddState(playing);
            this.stateMachine.AddState(paused);
        }

        /// <summary>
        /// Obtiene el estado actual del reproductor.
        /// </summary>
        public State CurrentState
        {
            get
            {
                return this.stateMachine.CurrentState;
            }
        }

        /// <summary>
        /// Reproduce la canción actual.
        /// </summary>
        /// <returns><c>true</c> si la operación cambia el estado; en caso contrario, <c>false</c>.</returns>
        public bool Play()
        {
            return this.stateMachine.ProcessInput(this.play);
        }

        /// <summary>
        /// Pausa la reproducción actual.
        /// </summary>
        /// <returns><c>true</c> si la operación cambia el estado; en caso contrario, <c>false</c>.</returns>
        public bool Pause()
        {
            return this.stateMachine.ProcessInput(this.pause);
        }

        /// <summary>
        /// Detiene la reproducción.
        /// </summary>
        /// <returns><c>true</c> si la operación cambia el estado; en caso contrario, <c>false</c>.</returns>
        public bool Stop()
        {
            return this.stateMachine.ProcessInput(this.stop);
        }
    }
}
