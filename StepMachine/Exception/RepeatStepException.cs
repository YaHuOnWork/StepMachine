namespace StepMachine.Exception;

/// <summary>
/// 重复步数异常
/// </summary>
[Serializable]
public class RepeatStepException : System.Exception
{
    public RepeatStepException()
    {
    }

    public RepeatStepException(string message) : base(message)
    {
    }

    public RepeatStepException(string message, System.Exception inner) : base(message, inner)
    {
    }
}