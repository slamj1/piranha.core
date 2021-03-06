/*
 * Copyright (c) 2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

using System;
using Piranha.Extend.Fields;

namespace Piranha.Extend.Blocks
{
    [BlockType(Name = "Quote", Category = "Content", Icon = "fas fa-quote-right")]
    public class QuoteBlock : Block
    {
        public TextField Body { get; set; }
    }
}
