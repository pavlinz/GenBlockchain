using System.Collections.Generic;

namespace Blockchain
{
    public class Chain
    {
        public List<Block> Blocks { get; private set; }

        public Block Last { get; private set; }

        public Chain()
        {
            Blocks = new List<Block>();
            var genesisBlock = new Block();
            Blocks.Add(genesisBlock);
            Last = genesisBlock;
        }

        public void Add(string data, string user)
        {
            var block = new Block(data, Last, user);
            Blocks.Add(block);
            Last = block;
        }
    }
}
