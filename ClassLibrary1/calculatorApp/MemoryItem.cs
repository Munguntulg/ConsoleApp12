using System.Collections.Generic;

namespace TooniiMachie.MemoryApp
{
    public class MemoryItem
    {
        public double Value { get; }

        public MemoryItem(double value)
        {
            Value = value;
        }
    }

    public class Memory
    {
        private List<MemoryItem> memoryItems = new List<MemoryItem>();

        public void Store(double value)
        {
            memoryItems.Add(new MemoryItem(value));
        }

        public List<MemoryItem> GetMemoryItems()
        {
            return memoryItems;
        }
        public void Clear()
        {
            memoryItems.Clear(); // эсвэл memoryValue = 0; гэх мэт
        }

    }
}
