﻿using System.Collections.Generic;

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

        public double? Recall()
        {
            if (memoryItems.Count == 0)
                return null;
            return memoryItems[memoryItems.Count - 1].Value;
        }

        public List<MemoryItem> GetMemoryItems()
        {
            return memoryItems;
        }

        public void Clear()
        {
            memoryItems.Clear();
        }

        public void RemoveLast()
        {
            if (memoryItems.Count > 0)
                memoryItems.RemoveAt(memoryItems.Count - 1);
        }
    }
}
