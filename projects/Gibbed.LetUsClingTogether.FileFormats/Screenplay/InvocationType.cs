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

namespace Gibbed.LetUsClingTogether.FileFormats.Screenplay
{
    public enum InvocationType : byte
    {
        Unknown0 = 0,

        ATStart = 1, // AT_start

        Unknown2 = 2,

        IncomingStrongpoint = 3, // incoming_strongpoint

        Unknown4 = 4,

        ATEnd = 5, // AT_end

        Unknown6 = 6,
        Unknown7 = 7,
        Unknown8 = 8,
        Unknown9 = 9,
        Unknown10 = 10,
        Unknown11 = 11,
        Unknown12 = 12,
        Unknown13 = 13,
        Unknown14 = 14,

        WarrenReport = 15,
    }
}
