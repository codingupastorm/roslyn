using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

namespace EthSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"public class SimpleStorage {
    private int storedData;

    public void Set(int x) {
        storedData = x;
    }

    public int Get(){
        return storedData;
    }
}";

            var tree = SyntaxFactory.ParseSyntaxTree(source);
            var root = tree.GetRoot();
            foreach (var child in root.ChildNodes())
            {
                Console.WriteLine(child);
            }
            var trees = new List<SyntaxTree>
            {
                SyntaxFactory.ParseSyntaxTree(source)
            };
            var compilation = CSharpCompilation.Create("assemblyname", trees);
            //compilation.
            var stream = new MemoryStream();
            compilation.Emit(stream);
            Console.ReadKey();
        }
    }
}
