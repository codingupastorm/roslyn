using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthSharp.Assembly;

namespace EthSharp.Assembly
{
    public class AssemblyItem
    {
        public enum JumpType
        {
            Ordinary,
            IntoFunction,
            OutOfFunction
        }

        public AssemblyItemType Type { get; private set; }

        //private SourceLocation _sourceLocation;
        public Instruction Instruction { get; private set; }
        public int Data { get; set; }
        public JumpType ItemJumpType { get; set; } = JumpType.Ordinary;

        //public AssemblyItem(AssemblyItemType type, int data = 0)
        //{
        //    if (location == null)
        //        location = new SourceLocation();

        //    _type = type;
        //    Data = data;
        //    _sourceLocation = location;

        //    if (_type == AssemblyItemType.Operation)
        //    {
        //        _instruction = (Instruction)data;
        //    }
        //    else
        //    {
        //        Data = data;
        //    }
        //}
    }

    public enum AssemblyItemType
    {
        UndefinedItem,
        Operation,
        Push,
        PushString,
        PushTag,
        PushSub,
        PushSubSize,
        PushProgramSize,
        Tag,
        PushData,
        PushLibraryAddress
    };
}
