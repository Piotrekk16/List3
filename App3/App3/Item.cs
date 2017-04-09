namespace App3
{
    class Item
    {
        private string name;

        public Item(string name)
        {
            this.name = name;
        }

        public static Item[] items =
        {
            new Item("Vegetables"), new Item("Fruits"), new Item("Flower Buds"), new Item("Legumes"), new Item("Bulbs"), new Item("Tubers")
        };

        public override string ToString()
        {
            return name;
        }
    }
}