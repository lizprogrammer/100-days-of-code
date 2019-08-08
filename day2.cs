using System;
using System.Collections.Generic;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {

  public static Node removeDuplicates(Node head){
    Node s = head;
    Node f = head.next;

    while(f != null)
    {
        if(f.data != s.data)
        {
            s.next = f;
            s = f;
        }

        f = f.next;
    }

    //  Nullify the last if there are any trailing values
    s.next = null;

    return head;


  }

	public static  Node insert(Node head,int data)
