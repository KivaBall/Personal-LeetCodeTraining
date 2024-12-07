var listNode = new ListNode(1, new ListNode(1, new ListNode(2)));
Console.WriteLine(new Solution().DeleteDuplicates(listNode));


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

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (head == null)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return head;
#pragma warning restore CS8603 // Possible null reference return.
        }

        var current = head;

        while (true)
        {
            if (current.next == null)
            {
                return head;
            }

            if (current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }
    }
}