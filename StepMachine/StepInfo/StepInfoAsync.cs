using System.Collections.Concurrent;

namespace StepMachine.StepInfo;

/// <summary>
/// 异步步数信息类
/// </summary>
public abstract class StepInfoAsync : IStepInfo
{
    /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
    protected StepInfoAsync(int step)
    {
        Step = step;
    }

    /// <summary>
    /// 步数
    /// </summary>
    public int Step { get; protected set; }

    /// <summary>
    /// 该步中存储的方法信息
    /// </summary>
    private ConcurrentDictionary<int, SubStepInfoAsync> MethodDictionary { get; set; } = new();

    /// <summary>
    /// 子步数总数
    /// </summary>
    public int SubStepCount => MethodDictionary.Count;

    /// <summary>
    /// 添加子步数
    /// </summary>
    /// <param name="method"></param>
    /// <returns></returns>
    public StepInfoAsync Then(Func<StepController, Task> method)
    {
        // 向队列中添加方法
        MethodDictionary.TryAdd(MethodDictionary.Count, new SubStepInfoAsync(MethodDictionary.Count, method));
        return this;
    }
}