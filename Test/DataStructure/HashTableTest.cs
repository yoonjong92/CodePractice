using System.Security.Cryptography.X509Certificates;
using DataStructures;

namespace Test.DataStructure;

public class HashTableTest
{
    [Test]
    public void Test()
    {
        var ht = new HashTable<int>(31);
        ht.Put("abc",4);
        ht.Put("afsdfd",5);
        ht.Put("123",1);
        Assert.That(ht.Get("abc"), Is.EqualTo(4), $"Failed");
    }
}