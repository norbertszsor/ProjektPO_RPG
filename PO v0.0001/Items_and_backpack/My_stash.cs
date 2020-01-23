using System.Collections.Generic;

namespace PO_v0._0001
{
    public class My_stash//ekwipunek
    {
        List<Item> _backpack;

        public My_stash()
        {
            _backpack = new List<Item>();
        }

        public void add_stash(Item _item)
        {
            if (_backpack.Count <= 20)
                this._backpack.Add(_item);
            else
                return;
        }
    }
}
