using System.Windows.Forms;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public class SortListByName : SortListBox
    {
        public SortListByName(ListBox i_List)
        {
            m_List = i_List;
        }
        public override bool SwapMethod(object i_Item1, object i_Item2)
        {
            return string.Compare((i_Item1 as ISortableItem).Name, (i_Item2 as ISortableItem).Name) < 0;
        }
    }
}