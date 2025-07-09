namespace AppiumTests.TestData
{
    public sealed class MenuItemData
    {
        public required string Label { get; init; }
        public required string Description { get; init; }

        public override string ToString() => Label;
    }
}
