namespace TipCalc.Core.Services
{
    public interface ICalculationService
    {
        public double TipAmount(double subTotal, int generosity);
    }
}
