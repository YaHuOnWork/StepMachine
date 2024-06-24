using System.Collections.Concurrent;
using StepMachine.StepInfo;

namespace StepMachine;

/// <summary>
/// <see cref="StepMachine"/> 构造类
/// </summary>
public class StepMachineConstruct
{
    private ConcurrentDictionary<int, StepInfoAsync> _methodDictionary = new ();
    internal StepMachineConstruct(StepMachineAsync stepMachineAsync)
    {
        
    }

    public StepInfoAsync Then(int step, Func<StepController, Task> method)
    {
        // 判断是否存在重复步数
        if (_methodDictionary.ContainsKey(step))
        {
            
        }
    }
}