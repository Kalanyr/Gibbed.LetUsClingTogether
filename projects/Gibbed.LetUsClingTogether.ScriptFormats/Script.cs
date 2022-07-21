﻿/* Copyright (c) 2022 Rick (rick 'at' gibbed 'dot' us)
 *
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System.Collections.Generic;

namespace Gibbed.LetUsClingTogether.ScriptFormats
{
    public class Script
    {
        private readonly List<Instruction> _Code;
        private readonly List<int> _Jumps;
        private readonly List<Function> _Functions;
        private readonly List<short> _Unknown18s;

        public Script()
        {
            this._Code = new List<Instruction>();
            this._Jumps = new List<int>();
            this._Functions = new List<Function>();
            this._Unknown18s = new List<short>();
        }

        public string Name { get; set; }
        public ushort TableIndex { get; set; }
        public ushort Unknown06 { get; set; }
        public List<Instruction> Code {  get { return this._Code; } }
        public uint Unknown1COffset { get; set; }
        public ushort Unknown20 { get; set; }
        public ushort Index { get; set; }
        public uint Unknown24 { get; set; }
        public uint Unknown28 { get; set; }
        public uint Unknown2C { get; set; }
        public List<int> Jumps { get { return this._Jumps; } }
        public List<Function> Functions { get { return this._Functions; } }
        public List<short> Unknown18s { get { return this._Unknown18s; } }
    }
}