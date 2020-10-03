using System.Windows.Forms;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public abstract class SortListBox
    {
        public ListBox m_List { get; set; }
        public abstract bool SwapMethod(ISortableItem i_Item1, ISortableItem i_Item2);
        public void Sort()
        {
            if (m_List.Items.Count > 1)
            {
                bool swapped;
                do
                {
                    int counter = m_List.Items.Count - 1;
                    swapped = false;

                    while (counter > 0)
                    {
                        if (SwapMethod(m_List.Items[counter] as ISortableItem, m_List.Items[counter - 1] as ISortableItem))
                        {
                            object temp = m_List.Items[counter];
                            m_List.Items[counter] = m_List.Items[counter - 1];
                            m_List.Items[counter - 1] = temp;
                            swapped = true;
                        }
                        counter--;
                    }
                }
                while (swapped);
            }
        }
    }
}
