using System;

namespace HomeWork1.Exercise4
{
    public abstract class VictoryCondition
    {
        public Action<bool> Completed;
        protected abstract void CheckConditionToComplete();
    }
}
