using Library.Base;
using Library.Player;
using NUnit.Framework;

namespace Library.Tests
{
    public class StateMachineTests
    {
        [Test]
        public void ProcessInput_ValidTransition_ChangesCurrentState()
        {
            var initial = new TestState();
            var next = new TestState();
            var input = new TestInput("go");
            var stateMachine = new StateMachine();

            initial.AddTransition(input, next);
            stateMachine.AddState(initial);

            var result = stateMachine.ProcessInput(input);

            Assert.That(result, Is.True);
            Assert.That(stateMachine.CurrentState, Is.SameAs(next));
        }

        [Test]
        public void ProcessInput_InvalidTransition_ReturnsFalse()
        {
            var initial = new TestState();
            var input = new TestInput("go");
            var stateMachine = new StateMachine();

            stateMachine.AddState(initial);

            var result = stateMachine.ProcessInput(input);

            Assert.That(result, Is.False);
            Assert.That(stateMachine.CurrentState, Is.SameAs(initial));
        }

        [Test]
        public void ProcessInputs_SequenceWithInvalidInput_ReturnsFalse()
        {
            var initial = new TestState();
            var middle = new TestState();
            var inputOne = new TestInput("go");
            var inputTwo = new TestInput("stop");
            var stateMachine = new StateMachine();

            initial.AddTransition(inputOne, middle);
            stateMachine.AddState(initial);

            var result = stateMachine.ProcessInputs(new[] { inputOne, inputTwo });

            Assert.That(result, Is.False);
            Assert.That(stateMachine.CurrentState, Is.SameAs(middle));
        }

        [Test]
        public void MusicPlayer_PlayPauseStop_TransitionsThroughExpectedStates()
        {
            var player = new MusicPlayer();

            Assert.That(player.Play(), Is.True);
            Assert.That(player.CurrentState, Is.TypeOf<Playing>());

            Assert.That(player.Pause(), Is.True);
            Assert.That(player.CurrentState, Is.TypeOf<Paused>());

            Assert.That(player.Stop(), Is.True);
            Assert.That(player.CurrentState, Is.TypeOf<Stopped>());
        }

        private sealed class TestState : State
        {
        }

        private sealed class TestInput : InputSymbol
        {
            public TestInput(string name)
                : base(name)
            {
            }
        }
    }
}
