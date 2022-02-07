using System;

namespace CustomLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<string> customLinkedList = new CustomLinkedList<string>();
            customLinkedList.AddFirst("gogi");
            customLinkedList.AddFirst("djimi");
            customLinkedList.AddFirst("pepi");
        }
    }
}
