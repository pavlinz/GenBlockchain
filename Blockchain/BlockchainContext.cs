﻿using System.Data.Entity;

namespace Blockchain
{
    public class BlockchainContext : DbContext
    {
        public BlockchainContext() : base("BlockchainConnection")
        {
            
        }

        public DbSet<Block> Blocks { get; set; }
    }
}
