using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Table
    {
        public TableState State { get; private set; }
        public int SeatsCount { get; }
        public int Id { get; }

        public Table(int id)
        {
            Id = id;
            State = TableState.Free;
            SeatsCount = Random.Shared.Next(2, 5);
        }

        
        public bool Set(TableState state)
        {
            if (state == State) return false;

            State = state;
            return true;
        }
    }
}
