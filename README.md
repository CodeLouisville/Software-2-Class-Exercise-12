# Software 2 - Class Exercise 7
# Goals
Make the application run asychnously

# Instructions
This exercise will not be standard.  You're going to get a few instructions which will break the application (create build errors) and you will be responsible for fixing the application.  The changes will also create some warnings regarding async methods running synchronously.  While these warnings won't prevent the application from building, they could potentially cause _runtime_ errors.

1. Update the methods in the repos to return what it originally would but wrapped in a `Task<>`.  If it's void, it will now return just a `Task` instad of void.
1. Before the return type, add the keyword `async`.
1. Add the word "Async" at the end of the method.  This is a standard in C# for asynchronous methods.
1. Update the Entity Framework Methods to use the "Async" version adding the keyword `await` before the line of code.
1. Here's the first method done for you:
    ```
    public async Task<Order> GetOrderAsync(int id)
    {
        return await _dbContext.Orders.Include(x=>x.Products).SingleOrDefaultAsync(x=>x.OrderId == id);
    }
    ```
    All the other methods should look like this.
1. When you get to the Controller, you don't have to add "Async" at the end of the method name.  Since those are "public" facing, we don't need to have the word "Async" in the route.
1. Don't forget your test. Tests support asynchronous code, so just change them the way you would the other methods.  Tip: Use the mock objects `ReturnsAsyc` method.
