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
            //parse tree - create assembly then emit.

            var tree = SyntaxFactory.ParseSyntaxTree(source);
            var assembly = EthSharpCompiler.Create(tree);
            Console.ReadKey();
        }
    }
}
