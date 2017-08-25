using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace EthSharp
{
    public class EthSharpCompiler
    {
        private EthSharpCompilerContext Context { get; set; }

        public static Assembly.EthSharpAssembly Create(SyntaxTree root)
        {
            
            throw new NotImplementedException();
        }

        private void InitializeContext()
        {
            Context.Append();
        }
    }
}
