using System;
using System.Security.Cryptography;
using System.Text;

namespace Blockchain
{
    // Block data of our chain
    public class Block
    {
        public int Id { get; private set; }

        public string Data { get; private set; }

        public DateTime Created { get; private set; }

        public string Hash { get; private set; }

        public string PreviousHash { get; private set; }

        public string User { get; private set; }

        public Block()
        {
            Id = 1;
            Data = "Hello, I'm genesis block";
            Created = DateTime.UtcNow;
            PreviousHash = "111111";
            User = "Admin";

            var data = GetData();
            Hash = GetHash(data);
        }

        public Block(string data, Block previousBlock, string user)
        {
            if(string.IsNullOrWhiteSpace(data)) { throw new ArgumentNullException($"Empty argument data", nameof(data)); }
            if(previousBlock == null) { throw new ArgumentNullException($"Empty argument block", nameof(previousBlock)); }
            if(string.IsNullOrWhiteSpace(user)) { throw new ArgumentNullException($"Empty argument user", nameof(user)); }

            Data = data;
            User = user;
            PreviousHash = previousBlock.Hash;
            Created = DateTime.UtcNow;
            Id = previousBlock.Id + 1;

            var blockData = GetData();
            Hash = GetHash(blockData);
        }

        private string GetData()
        {
            string result = "";
            result = Id.ToString() + Data + Created.ToString("dd.MM.yyyy HH:mm:ss:fff") + PreviousHash + User;
            return result;
        }

        private string GetHash(string data)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(data));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
    }
}
