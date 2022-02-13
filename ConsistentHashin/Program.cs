using Murmur;
using RingHash;
using System;
using System.Collections.Generic;

namespace ConsistentHashin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var replicasCount = 5;
           //var rHash = new ConsistentHash<Node>(new Murmur32(), (uint)replicasCount);
           //  act
           //rHash.AddNodes(new List<Node> { first, second });
           //var shard1 = rHash.GetShardHashForHash(44444);

        }
        public class Node
        {
            public string IPAdress { get; set; }
            public string ServerName { get; set; }

            public override string ToString()
            {
                return $"Node {ServerName}";
            }
        }

    }
}
