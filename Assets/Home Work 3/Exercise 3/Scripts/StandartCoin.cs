namespace HomeWork3.Exercise3
{
    public class StandartCoin : Coin
    {
        protected override void AddCoin(ICointPicker cointPicker) => cointPicker.Add(Value);
    }
}

