﻿/* Copyright (c) 2020 Rick (rick 'at' gibbed 'dot' us)
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

namespace Gibbed.TacticsOgre.FileFormats.Sprite
{
    internal static class Palettes
    {
        public static readonly byte[] Default;

        static Palettes()
        {
            Default = new byte[]
            {
                0xFF, 0x00, 0xFF, 0x00,
                0x10, 0x10, 0x08, 0xFF,
                0xF8, 0xF8, 0xE9, 0xFF,
                0x30, 0x28, 0x20, 0xFF,
                0x51, 0x52, 0x49, 0xFF,
                0x73, 0x7C, 0x72, 0xFF,
                0x95, 0xA7, 0x9B, 0xFF,
                0xB4, 0xCA, 0xC0, 0xFF,
                0xCE, 0xE8, 0xE1, 0xFF,
                0x85, 0x53, 0x2A, 0xFF,
                0x9A, 0x69, 0x36, 0xFF,
                0xBC, 0x7A, 0x39, 0xFF,
                0xD0, 0x8C, 0x40, 0xFF,
                0xDC, 0xA0, 0x4E, 0xFF,
                0xF3, 0xEA, 0x7C, 0xFF,
                0xE7, 0xC5, 0x65, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x87, 0x51, 0x24, 0xFF,
                0xA7, 0x69, 0x31, 0xFF,
                0xC7, 0x82, 0x3F, 0xFF,
                0xD4, 0x8F, 0x49, 0xFF,
                0xDC, 0x9E, 0x57, 0xFF,
                0xEB, 0xCA, 0x8B, 0xFF,
                0x68, 0x4C, 0x30, 0xFF,
                0x83, 0x68, 0x32, 0xFF,
                0xA0, 0x83, 0x3B, 0xFF,
                0xBE, 0x9F, 0x45, 0xFF,
                0xDB, 0xBB, 0x4F, 0xFF,
                0xF9, 0xD7, 0x59, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x38, 0x40, 0x8F, 0xFF,
                0x52, 0x60, 0xB6, 0xFF,
                0x62, 0x84, 0xC8, 0xFF,
                0x72, 0xA8, 0xDA, 0xFF,
                0x99, 0xC8, 0xE8, 0xFF,
                0xC0, 0xE8, 0xF6, 0xFF,
                0x3A, 0x67, 0x40, 0xFF,
                0x57, 0x8E, 0x47, 0xFF,
                0x74, 0xB5, 0x4F, 0xFF,
                0x91, 0xDC, 0x57, 0xFF,
                0xA8, 0xEC, 0x62, 0xFF,
                0xE4, 0xF9, 0xA4, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0xFF,
            };
        }
    }
}