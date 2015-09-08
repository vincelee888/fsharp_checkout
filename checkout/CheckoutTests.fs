namespace checkout

module Checkout =
    let GetPrice items = 
        0 
    
    

module CheckoutTests =
    
    open NUnit.Framework
    open Checkout


    [<Test>]
    let ``Empty Basket is Empty`` () =
        Assert.That(Checkout.GetPrice, Is.EqualTo 0)