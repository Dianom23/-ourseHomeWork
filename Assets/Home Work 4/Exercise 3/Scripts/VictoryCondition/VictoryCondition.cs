using System;

namespace HomeWork4.Exercise3
{
    public abstract class VictoryCondition
    {
        public Action<bool> Completed;
        protected abstract void CheckConditionToComplete();
    }
}
