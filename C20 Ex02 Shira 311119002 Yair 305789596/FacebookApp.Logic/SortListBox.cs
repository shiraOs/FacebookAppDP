using System.Windows.Forms;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public abstract class SortListBox
    {
        public ListBox List { get; set; }
        public abstract bool SwapMethod(ISortableItem i_Item1, ISortableItem i_Item2);
        public void Sort()
        {
            if (List.Items.Count > 1)
            {
                bool swapped;
                do
                {
                    int counter = List.Items.Count - 1;
                    swapped = false;

                    while (counter > 0)
                    {
                        if (SwapMethod(List.Items[counter] as ISortableItem, List.Items[counter - 1] as ISortableItem))
                        {
                            object temp = List.Items[counter];
                            List.Items[counter] = List.Items[counter - 1];
                            List.Items[counter - 1] = temp;
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
