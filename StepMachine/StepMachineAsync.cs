using System.Collections.Concurrent;
using System.Text.Json.Serialization;

namespace StepMachine;

/// <summary>
/// 简单状态机
/// </summary>
public class StepMachineAsync
{
    /// <summary>
    /// 步数
    /// </summary>
    public int Step { get; set; }

    /// <summary>
    /// 恢复时步数
    /// </summary>
    [JsonIgnore]
    public int RecoverySteps { get; private set; }

    // 反序列化构造函数，由JsonSerializer自动调用
    [JsonConstructor]
    private StepMachineAsync(int step)
    {
        Step = step;
        RecoverySteps = step; // 反序列化时设为false
    }

    /// <summary>
    /// 开始构造
    /// </summary>
    /// <returns></returns>
    public StepMachineConstruct Construct()
    {
        return new StepMachineConstruct(this);
    }

    /// <summary>
    /// 
    /// </summary>
    public StepMachineAsync()
    {
        RecoverySteps = -1;
    }
    
}
