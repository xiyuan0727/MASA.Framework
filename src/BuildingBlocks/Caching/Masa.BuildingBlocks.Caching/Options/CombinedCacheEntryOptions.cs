﻿// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Caching;

public class CombinedCacheEntryOptions
{
    public CacheEntryOptions? MemoryCacheEntryOptions { get; set; }

    public CacheEntryOptions? DistributedCacheEntryOptions { get; set; }
}
