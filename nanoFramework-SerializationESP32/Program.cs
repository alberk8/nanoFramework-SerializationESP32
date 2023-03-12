using nanoFramework.System.Runtime.Serialization.Tests;
using System;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace nanoframework_SerializationESP32
{
    public class Program
    {
        public static void Main()
        {
            Debug.WriteLine("Hello from nanoFramework!");

            var person = TestHelper.CreatePersonOne();

            var sPerson = BinaryFormatter.Serialize(person);

            Console.WriteLine("One Person         : " + BitConverter.ToString(sPerson));

            Console.WriteLine("PersonOneSerialized: " + BitConverter.ToString(TestHelper.PersonOneSerialized));

            Thread.Sleep(Timeout.Infinite);

         
        }
    }
}
