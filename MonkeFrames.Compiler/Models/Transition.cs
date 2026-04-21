namespace MonkeFrames.Compiler.Models;

/// <summary>
/// Transition data such as movement styling and duration.
/// </summary>
public struct Transition
{
    /// <summary>
    /// The type of transition to apply.
    /// </summary>
    public TransitionEffect Effect = TransitionEffect.Linear;

    /// <summary>
    /// The amount of time the transitioning lasts.
    /// </summary>
    public float Duration = 5f;

    /// <summary>
    /// Create a new Transition.
    /// </summary>
    public Transition() { }

    /// <summary>
    /// The default transition.
    /// </summary>
    public static Transition Linear => new Transition { Effect = TransitionEffect.Linear, Duration = 5f };

}

/// <summary>
/// Transition style to apply.
/// </summary>
public enum TransitionEffect
{
    /// <summary>
    /// Basic direct-line transition.
    /// </summary>
    Linear = 0,

    /// <summary>
    /// The camera stays at the keyframe's position for the entire duration of the transition.
    /// </summary>
    Cut
}