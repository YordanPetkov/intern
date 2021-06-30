using System.Collections.Generic;

namespace DPS.Logic
{
    public interface IUpdateLogic
    {
        void UpdateData(List<string> tableNames, int tableId, int rowId);
    }
}
