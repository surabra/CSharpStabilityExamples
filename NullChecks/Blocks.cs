using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullChecks
{

    public class BlockFactory
    {
        private readonly List<int> _createdBlockList;
        public BlockFactory()
        {
            _createdBlockList = new List<int>();
        }

        public Blocks CreateBlock(int number)
        {
            if (_createdBlockList.Contains(number))
                return null;
            else
            {
                _createdBlockList.Add((number));
                return new Blocks(number);
            }
        }

        public void DestroyBlock(Blocks block)
        {
            _createdBlockList.Remove(block.Number);
            block.Dispose();
        }
    }
    public class Blocks :IDisposable
    {
       
        private static Random _rand = new Random(100);

        public int Number { get; set; }
        public int Score { get; private set; }

        public Blocks(int num)
        {
            Number = num;

            
            Score = _rand.Next(0, 100);
        }

        protected virtual void Dispose(bool disposing)
        {

            
        }

        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
