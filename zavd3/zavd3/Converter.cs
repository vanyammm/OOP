namespace zavd3;

class Converter
{
    private decimal usdToUahRate;
    private decimal eurToUahRate;

    public Converter(decimal usdRate, decimal eurRate)
    {
        usdToUahRate = usdRate;
        eurToUahRate = eurRate;
    }

    public decimal UahToUsd(decimal amountInUah)
    {
        return amountInUah / usdToUahRate;
    }

    public decimal UahToEur(decimal amountInUah)
    {
        return amountInUah / eurToUahRate;
    }

    public decimal UsdToUah(decimal amountInUsd)
    {
        return amountInUsd * usdToUahRate;
    }

    public decimal EurToUah(decimal amountInEur)
    {
        return amountInEur * eurToUahRate;
    }
}
