namespace Engine
{
    /// <summary>
    /// A timer class that has auto counting functions.
    /// </summary>
    public class Timer : GameObject
    {
        int TicksElapsed;
        int TargetTicks;
        bool Running;

        /// <summary>
        /// Constructs a new instance of the Timer class.
        /// </summary>
        /// <param name="TargetTicks">Ticks to restart at.</param>
        public Timer(int TargetTicks)
        {
            this.TargetTicks = TargetTicks;
            this.Running = true;
            TicksElapsed = 0;
        }
        /// <summary>
        /// Resets the timer to initial position.
        /// </summary>
        public void Reset()
        {
            TicksElapsed = 0;
        }
        /// <summary>
        /// Pauses the timer in its current position.
        /// </summary>
        public void Pause()
        {
            Running = false;
        }
        /// <summary>
        /// Continues the timer from its previous position.
        /// </summary>
        public void Contine()
        {
            Running = true;
        }
        /// <summary>
        /// checks if the ticks made has reached target ticks.
        /// </summary>
        public bool IsTimedOut()
        {
            return (TicksElapsed == TargetTicks);
        }
        /// <summary>
        /// Changes the timer Target clicks.
        /// </summary>
        public void ChangeTimer(int TargetTicks)
        {
            this.TargetTicks = TargetTicks;
        }
        public override void Update()
        {
            if (Running)
            {
                TicksElapsed++;
                if (TicksElapsed > TargetTicks)
                    Reset();
            }
            base.Update();
        }
    }
}
