﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System.ComponentModel.DataAnnotations;

namespace Squidex.CLI.Commands.Implementation.Sync.Assets
{
    internal class AssetsModel
    {
        [Required]
        public List<AssetModel> Assets { get; set; }
    }
}
