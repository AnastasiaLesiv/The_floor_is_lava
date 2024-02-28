using System;
using UnityEngine;
namespace MainPlayer.UnityEngine
{
    public class Store : MonoBehaviour
    {
        private void Start()
        {
            OrderProcessor order = new OrderProcessor();
            
            order.ProcessOrder("bank teller");
            order.ProcessOrder("smartphone", "smartphone case");
            order.ProcessOrder("laptop", "keyboard", "headphone");
        }
    }
    public class OrderProcessor
{
    public void ProcessOrder(string product)
    {
        Debug.Log("Processing order for product: " + product);
    }

    public void ProcessOrder(string product1, string product2)
    {
        Debug.Log("Processing order for products: " + product1 + ", " + product2);
    }

    public void ProcessOrder(string product1, string product2, string product3)
    {
        Debug.Log("Processing order for products: " + product1 + ", " + product2 + ", " + product3);
    }
}
}