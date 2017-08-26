using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthSharp.Assembly;
using Microsoft.CodeAnalysis;

namespace EthSharp
{
    public class EthSharpCompiler
    {
        private EthSharpCompilerContext Context { get; set; }


        public EthSharpCompiler()
        {
            Context = new EthSharpCompilerContext();
        }

        public Assembly.EthSharpAssembly Create(SyntaxTree root)
        {
            //for now just assume one class
            var rootClass = root.GetRoot().ChildNodes().FirstOrDefault(); // cast as class type
            InitializeContext();

            foreach (var classNode in rootClass.Members)
            {
                
            }

            throw new NotImplementedException();
        }

        private void InitializeContext()
        {
            //need to use uint here eventually. 

            //also need to work out why we do this to begin with

            //can use freeMemoryPointer const here

            // Compiled Contracts go here in solidity

            Context.Append(64 + 32);
            Context.Append(64);
            Context.Append(EvmInstruction.MSTORE);

            // Registering state variables goes here in solidity. Not sure if important here

            // Also resets visiting of node. Unsure how important
        }
    }
}
