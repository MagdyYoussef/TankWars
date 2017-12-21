using Microsoft.Xna.Framework.Audio;

namespace Engine
{
    /// <summary>
    /// Used as a layer to play certain audio in the game.
    /// </summary>
    public class SoundWrapper : GameObject
    {
        string FilePath;
        SoundEffect soundEffect;
        SoundEffectInstance soundEffectInstance;
        bool IsLooping;

        /// <summary>
        /// Creates a new instance of the sound wrapper.
        /// </summary>
        /// <param name="FilePath">File Path of the audio file.</param>
        /// <param name="IsLooping">States if the sound is looped after it finishes or not.</param>
        public SoundWrapper(string FilePath, bool IsLooping)
        {
            this.FilePath = FilePath;
            this.IsLooping = IsLooping;
        }

        public override void LoadContent()
        {
            soundEffect = EngineGame.contentManager.Load<SoundEffect>(FilePath);
            soundEffectInstance = soundEffect.Play(1, 0, 0, IsLooping);
            base.LoadContent();
        }

        /// <summary>
        /// Starts or continues playing the sound.
        /// </summary>
        public void Play()
        {
            soundEffectInstance.Play();
        }
        /// <summary>
        /// Pauses playing the sound.
        /// </summary>
        public void Pause()
        {
            soundEffectInstance.Pause();
        }
        /// <summary>
        /// Resets the sound to its initial state.
        /// </summary>
        public void Reset()
        {
            soundEffectInstance.Stop();
        }
    }
}
