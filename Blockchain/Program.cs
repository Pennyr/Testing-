using System;
using NBitcoin;

namespace Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            Key privateKey = new Key();
           // Console.WriteLine(privateKey);

            PubKey publicKey = privateKey.PubKey;
            Console.WriteLine(publicKey);
            Console.WriteLine(publicKey.GetAddress(Network.Main));
            Console.WriteLine(publicKey.GetAddress(Network.TestNet));

            var publicKeyHash = publicKey.Hash;
            Console.WriteLine(publicKeyHash);
        }
    }
}
