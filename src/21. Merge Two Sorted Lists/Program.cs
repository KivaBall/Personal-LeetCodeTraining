var firstList = new ListNode(1, new ListNode(2, new ListNode(4, null)));
var secondList = new ListNode(1, new ListNode(3, new ListNode(4, null)));
var sol = new Solution().MergeTwoLists(firstList, secondList);
Console.WriteLine(sol);

public class Solution
{
    public ListNode MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 is null)
        {
            return list2;
        }
        else if (list2 is null)
        {
            return list1;
        }

        ref ListNode currentNode = ref list1;
        ref ListNode currentNode2 = ref list2;
        ListNode newChain;

        if (list1.val < list2.val)
        {
            currentNode = ref list1.next;
            currentNode2 = ref list2;
            newChain = new ListNode(list1.val, null);
        }
        else
        {
            currentNode = ref list1;
            currentNode2 = ref list2.next;
            newChain = new ListNode(list2.val, null);
        }

        var currentNewChain = newChain;

        while (true)
        {
            if (currentNode is null)
            {
                currentNewChain.next = currentNode2;
                return newChain;
            }
            else if (currentNode2 is null)
            {
                currentNewChain.next = currentNode;
                return newChain;
            }

            if (currentNode.val >= currentNode2.val)
            {
                currentNewChain.next = currentNode2;
                currentNewChain = currentNewChain.next;
                currentNode2 = currentNode2.next;
                currentNewChain.next = null;
            }
            else if (currentNode.val < currentNode2.val)
            {
                currentNewChain.next = currentNode;
                currentNewChain = currentNewChain.next;
                currentNode = currentNode.next;
                currentNewChain.next = null;
            }
        }

        return newChain;
    }
}

public class ListNode
{
    // ReSharper disable once InconsistentNaming
    public int val;

    // ReSharper disable once InconsistentNaming
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}