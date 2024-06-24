namespace StepMachine.StepInfo;

/// <summary>
/// 异步子步数类
/// </summary>
internal class SubStepInfoAsync
{
    /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
    public SubStepInfoAsync(int subStep, Func<StepController, Task>? method)
    {
        SubStep = subStep;
        Method = method;
    }

    public int SubStep { get; set; }
    public Func<StepController, Task>? Method { get; set; } = null;
}