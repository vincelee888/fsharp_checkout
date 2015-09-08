namespace checkout

module CheckoutTests =
    open NUnit.Framework

    [<Test>]
    let ``Empty Basket is Empty`` () =
        Assert.That(2 + 2, Is.EqualTo 5)