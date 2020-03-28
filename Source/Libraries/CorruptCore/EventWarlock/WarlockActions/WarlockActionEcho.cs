using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ceras;
using RTCV.CorruptCore.EventWarlock.Editor;

namespace RTCV.CorruptCore.EventWarlock.WarlockActions
{
    /// <summary>
    /// Example action
    /// </summary>
    [Serializable]
    [WarlockEditable]
    [Ceras.MemberConfig(TargetMember.All)]
    public class WarlockActionEcho : WarlockAction
    {
        [WarlockEditorField("Data")] string data;

        /// <summary>
        /// Parameterless consturctor for serialization. DON'T USE THIS.
        /// </summary>
        public WarlockActionEcho() { }

        public WarlockActionEcho(string data)
        {
            this.data = data;
        }

        public override void DoAction(Grimoire grimoire)
        {
            Console.WriteLine("Repeating: " + data);
        }
    }
}