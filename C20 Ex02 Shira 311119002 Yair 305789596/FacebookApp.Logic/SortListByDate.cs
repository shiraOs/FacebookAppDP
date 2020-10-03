using System.Windows.Forms;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public class SortListByDate : SortListBox
    {
        public SortListByDate(ListBox i_List)
        {
            m_List = i_List;
        }
        public override bool SwapMethod(ISortableItem i_Item1, ISortableItem i_Item2)
        {
            return i_Item1.CreatedTime < i_Item2.CreatedTime;
        }
    }
}