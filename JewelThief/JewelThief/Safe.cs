namespace JewelThief;

public class Safe
{
    private string contents = "precious jewels";
    private string safeConbination = "12345";

    public string Open(string combination)
    {
        if (combination == safeConbination) return contents;
        return "";
    }

    public void PickLock(Locksmith lockpicker)
    {
        lockpicker.Combination = safeConbination;
    }
}