/*var vr = new Solution().AddTwoNumbers(
    new ListNode(2, new ListNode(4, new ListNode(3))),
    new ListNode(5, new ListNode(6, new ListNode(4)))
);*/

var vr = new Solution().AddTwoNumbers(
    new ListNode(9,
        new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))),
    new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))
);

Console.WriteLine(vr.val);
Console.WriteLine(vr.next.val);

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var hasRemainder = false;

        var node1 = l1;
        var node2 = l2;

        while (true)
        {
            node1.val += node2.val + (hasRemainder ? 1 : 0);

            if (node1.val >= 10)
            {
                hasRemainder = true;
                node1.val -= 10;
            }
            else
            {
                hasRemainder = false;
            }

            if (node1.next == null)
            {
                if (node2.next == null)
                {
                    if (hasRemainder)
                    {
                        node1.next = new ListNode(1);
                    }

                    return l1;
                }

                node1.next = node2.next;

                node1 = node1.next;

                while (node1 != null)
                {
                    node1.val += hasRemainder ? 1 : 0;

                    if (node1.val >= 10)
                    {
                        hasRemainder = true;
                        node1.val -= 10;
                    }
                    else
                    {
                        hasRemainder = false;
                    }

                    if (node1.next == null)
                    {
                        if (hasRemainder)
                        {
                            node1.next = new ListNode(1);
                            hasRemainder = false;
                        }
                    }

                    node1 = node1.next;
                }

                return l1;
            }

            if (node2.next == null)
            {
                node1 = node1.next;

                while (node1 != null)
                {
                    node1.val += hasRemainder ? 1 : 0;

                    if (node1.val >= 10)
                    {
                        hasRemainder = true;
                        node1.val -= 10;
                    }
                    else
                    {
                        hasRemainder = false;
                    }

                    if (node1.next == null)
                    {
                        if (hasRemainder)
                        {
                            node1.next = new ListNode(1);
                            hasRemainder = false;
                        }
                    }

                    node1 = node1.next;
                }

                return l1;
            }

            node1 = node1.next;
            node2 = node2.next;
        }
    }
}

public class ListNode(int val = 0, ListNode? next = null)
{
    // ReSharper disable once InconsistentNaming
    public int val = val;

    // ReSharper disable once InconsistentNaming
    public ListNode? next = next;
}